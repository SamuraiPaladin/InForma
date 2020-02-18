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
                return Json(_service.Adicionar(Turma));
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Turma Turma)
        {
            return string.IsNullOrWhiteSpace(Turma.Descricao.Trim());
        }

        public JsonResult Editar(Turma Turma, Turma TurmaEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(TurmaEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Atualizar(Turma, TurmaEditar));
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