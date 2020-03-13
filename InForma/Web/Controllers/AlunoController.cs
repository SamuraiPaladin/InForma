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
    public class AlunoController : Controller
    {
        private readonly IServiceAluno<Aluno> _service;

        public AlunoController(IServiceAluno<Aluno> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ListaCompleta());
        }
        public JsonResult Adicionar(Aluno Aluno)
        {
            if (VerificaSeTemCampoVazioOuNulo(Aluno))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Adicionar(Aluno));
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Aluno Aluno)
        {
            return string.IsNullOrWhiteSpace(Aluno.Nome.Trim());
        }

        public JsonResult Editar(Aluno Aluno, Aluno AlunoEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(AlunoEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Atualizar(Aluno, AlunoEditar));
        }
        public JsonResult Deletar(Aluno Aluno)
        {
            if (VerificaSeTemCampoVazioOuNulo(Aluno))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Deletar(Aluno));
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public JsonResult BuscaCep(string cep)
        {
            var aluno = _service.BuscarCEP(cep);
            return Json(aluno);
        }
    }
}