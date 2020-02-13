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
            return View(_service.ListaCompleta());
        }
        public JsonResult Adicionar(Modalidade modalidade)
        {
            if (VerificaSeTemCampoVazioOuNulo(modalidade))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Adicionar(modalidade));
        }

        private static bool VerificaSeTemCampoVazioOuNulo(Modalidade modalidade)
        {
            return string.IsNullOrWhiteSpace(modalidade.Descricao.Trim()) || string.IsNullOrWhiteSpace(modalidade.TipoModalidade.Trim());
        }

        public JsonResult Editar(Modalidade modalidade, Modalidade modalidadeEditar)
        {
            if (VerificaSeTemCampoVazioOuNulo(modalidadeEditar))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Atualizar(modalidade, modalidadeEditar));
        }
        public JsonResult Deletar(Modalidade modalidade)
        {
            if (VerificaSeTemCampoVazioOuNulo(modalidade))
                return Json("Preenchimento obrigatório");
            else
                return Json(_service.Deletar(modalidade));
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}