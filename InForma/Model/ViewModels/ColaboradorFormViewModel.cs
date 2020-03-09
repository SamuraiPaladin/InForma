using Model.Entity;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels
{
    public class ColaboradorFormViewModel
    {
        public List<Colaborador> Colaboradores { get; set; }
        public List<Funcao> Funcoes { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
