using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.IService;

namespace Web.Controllers
{
    public class ModalidadeController : Controller
    {
        private readonly IServiceRepository<Modalidade> _service;
        public ModalidadeController(IServiceRepository<Modalidade> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Adicionar(Modalidade modalidade)
        {
            if (string.IsNullOrWhiteSpace(modalidade.Descricao) || string.IsNullOrWhiteSpace(modalidade.TipoModalidade))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Adicionar(modalidade));
        }

    }
}