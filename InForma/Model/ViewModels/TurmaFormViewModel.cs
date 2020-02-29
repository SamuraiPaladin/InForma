using Model.Entity;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels
{
    public class TurmaFormViewModel
    {
        public ICollection<Turma> Turmas { get; set; }
        public Turma Turma { get; set; }
        public ICollection<Unidade> Unidades { get; set; }
        public ICollection<Modalidade> Modalidades { get; set; }
        public ICollection<Colaborador> Professores { get; set; }
        public Array DiasDaSemana { get; set; }
    }
}
