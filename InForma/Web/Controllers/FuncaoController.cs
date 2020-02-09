using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.IService;

namespace Web.Controllers
{
    public class FuncaoController : Controller
    {
        private readonly IServiceRepository<Funcao> _service;
        public FuncaoController(IServiceRepository<Funcao> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ListaCompleta());
        }
        public JsonResult Adicionar(Funcao funcao)
        {
            if (VerificaSeTemCampoVazioOuNulo(funcao))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Adicionar(funcao));
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Funcao funcao)
        {
            return string.IsNullOrWhiteSpace(funcao.Descricao) || string.IsNullOrWhiteSpace(funcao.TipoFuncao);
        }

        public JsonResult Editar(Funcao funcao, Funcao funcaoEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(funcaoEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Atualizar(funcao, funcaoEditar));
        }
        public JsonResult Deletar(Funcao funcao)
        {
            if (VerificaSeTemCampoVazioOuNulo(funcao))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Deletar(funcao));
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}