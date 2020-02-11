using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.IService;

namespace Web.Controllers
{
    public class UnidadeController : Controller
    {
        IServiceUnidade<Unidade> serviceRepository;

        public UnidadeController(IServiceUnidade<Unidade> serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }

        public IActionResult Index()
        {
            return View(serviceRepository.ListaCompleta());
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public JsonResult BuscaCep(string cep)
        {
            var unidade = serviceRepository.BuscarCEP(cep);
            return Json(unidade);
        }
        public JsonResult Adicionar(Unidade unidade)
        {
            if (VerificaSeTemCampoVazioOuNulo(unidade))
                return Json("Preenchimento obrigatório");
            else
                return Json(serviceRepository.Adicionar(unidade));
        }
        private bool VerificaSeTemCampoVazioOuNulo(Unidade unidade)
        {
            return string.IsNullOrEmpty(unidade.Bairro.Trim()) || string.IsNullOrEmpty(unidade.CEP.Trim()) || string.IsNullOrEmpty(unidade.Cidade.Trim()) || 
                string.IsNullOrEmpty(unidade.Descricao.Trim()) || string.IsNullOrEmpty(unidade.Endereco.Trim()) || string.IsNullOrEmpty(unidade.Estado.Trim())
                || string.IsNullOrEmpty(unidade.Numero.Trim()) || string.IsNullOrEmpty(unidade.Telefone.Trim());
        }
        public JsonResult Editar(Unidade unidade, Unidade unidadeEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(unidadeEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(serviceRepository.Atualizar(unidade, unidadeEditar));
        }
        public JsonResult Deletar(Unidade unidade)
        {
            if (VerificaSeTemCampoVazioOuNulo(unidade))
                return Json("Preenchimento obrigatório");
            else
                return Json(serviceRepository.Deletar(unidade));
        }

    }
}