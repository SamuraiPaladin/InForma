using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.IService;

namespace Web.Controllers
{
    public class ColaboradorController : Controller
    {

        private readonly IServiceColaborador<Colaborador> _service;

        public ColaboradorController(IServiceColaborador<Colaborador> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ListaCompleta());
        }
        public JsonResult Adicionar(Colaborador Colaborador)
        {
            if (VerificaSeTemCampoVazioOuNulo(Colaborador))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Adicionar(Colaborador));
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Colaborador Colaborador)
        {
            return string.IsNullOrWhiteSpace(Colaborador.Nome.Trim());
        }

        public JsonResult Editar(Colaborador Colaborador, Colaborador ColaboradorEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(ColaboradorEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Atualizar(Colaborador, ColaboradorEditar));
        }
        public JsonResult Deletar(Colaborador Colaborador)
        {
            if (VerificaSeTemCampoVazioOuNulo(Colaborador))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Deletar(Colaborador));
        }
        public IActionResult Cadastrar()
        {
            var viewModel = _service.ListaColaboradorEFuncao();

            return View(viewModel);
        }
    }
}