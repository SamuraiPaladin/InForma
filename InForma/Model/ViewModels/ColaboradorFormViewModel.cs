using Model.Entity;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels
{
    public class ColaboradorFormViewModel
    {
        public ICollection<Colaborador> Colaboradores { get; set; }
        public ICollection<Funcao> Funcoes { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
