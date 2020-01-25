using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace InForma.Controllers.Modalidade
{
    public class ModalidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public void SendEmail(string Email)
        {
            CadastroService msg = new CadastroService(Email);
            msg.SaveColaborador();   
        }
    }
}