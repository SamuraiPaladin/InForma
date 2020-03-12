using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Model.ViewModels;
using Service.IService;

namespace Web.Controllers
{
    public class TurmaController : Controller
    {
        private readonly IServiceTurma<Turma> _service;

        public TurmaController(IServiceTurma<Turma> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ListaCompleta());
        }
        public JsonResult Adicionar(Turma Turma)
        {
            if (VerificaSeTemCampoVazioOuNulo(Turma))
                return Json("Preenchimento obrigatório");
            else
            if (VerificaHorario(Turma))
            {
                return Json(_service.Adicionar(Turma));
            }
            else
            {
                return Json("Horario inválido");
            }
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Turma Turma)
        {
            return string.IsNullOrWhiteSpace(Turma.Descricao);
        }

        private static bool VerificaHorario(Turma Turma)
        {
            TimeSpan horarioInicial = new TimeSpan();
            TimeSpan horarioFinal = new TimeSpan();

            if (!String.IsNullOrEmpty(Turma.HorarioInicial) && !String.IsNullOrEmpty(Turma.HorarioFinal))
            {
                if (Turma.DiaDaSemana != "Sabado") {
                    var turmaHorarioInicial = Turma.HorarioInicial.Split(':');
                    var turmaHorarioFinal = Turma.HorarioFinal.Split(':');

                    if (int.Parse(turmaHorarioInicial[0]) < 8 || int.Parse(turmaHorarioInicial[0]) > 22)
                    {
                        return false;
                    }

                    horarioInicial = new TimeSpan(int.Parse(turmaHorarioInicial[0]), int.Parse(turmaHorarioInicial[1]), 0);
                    horarioFinal = new TimeSpan(int.Parse(turmaHorarioFinal[0]), int.Parse(turmaHorarioFinal[1]), 0);
                }
                else 
                {
                    var turmaHorarioInicial = Turma.HorarioInicial.Split(':');
                    var turmaHorarioFinal = Turma.HorarioFinal.Split(':');

                    if (int.Parse(turmaHorarioInicial[0]) < 8 || int.Parse(turmaHorarioInicial[0]) > 13)
                    {
                        return false;
                    }

                    horarioInicial = new TimeSpan(int.Parse(turmaHorarioInicial[0]), int.Parse(turmaHorarioInicial[1]), 0);
                    horarioFinal = new TimeSpan(int.Parse(turmaHorarioFinal[0]), int.Parse(turmaHorarioFinal[1]), 0);
                }
            }
            else
            {
                horarioInicial = new TimeSpan(00, 00, 00);
                horarioFinal = new TimeSpan(00, 00, 00);
            }

            Turma.HorarioInicial = $"{horarioInicial.ToString(@"hh\:mm")}";
            Turma.HorarioFinal = $"{horarioFinal.ToString(@"hh\:mm")}";

            return (horarioFinal - horarioInicial).Hours == 1 && (horarioFinal - horarioInicial).Minutes == 0;
        }

        public JsonResult Editar(Turma Turma, Turma TurmaEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(TurmaEditar))
                return Json("Preenchimento obrigatório");
            else
                  if (VerificaHorario(TurmaEditar))
            {
                return Json(_service.Atualizar(Turma, TurmaEditar));
            }
            else
            {
                return Json("Horario inválido");
            }
        }
        public JsonResult Deletar(Turma Turma)
        {
            if (VerificaSeTemCampoVazioOuNulo(Turma))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Deletar(Turma));
        }
        public IActionResult Cadastrar()
        {
            var viewModel = _service.ListaUnidadeEModalidade();

            return View(viewModel);
        }
    }
}