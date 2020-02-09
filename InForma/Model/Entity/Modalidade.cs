using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Entity
{
    public class Modalidade
    {
        //entity modalidade
        public Modalidade()
        {
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo Modalidade")]
        public string TipoModalidade { get; set; }
        public bool Ativo { get; set; }
    }
}
