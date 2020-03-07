using Model.Entity;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels
{
    public class TurmaFormViewModel
    {
        public List<Turma> Turmas { get; set; }
        public Turma Turma { get; set; }
        public List<Unidade> Unidades { get; set; }
        public List<Modalidade> Modalidades { get; set; }
        public List<Colaborador> Professores { get; set; }
        public Array DiasDaSemana { get; set; }
    }
}
