using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Entity
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome {get; set;} 
        public string DataNascimento {get; set;} 
        public string CPF {get; set;} 
        public string RG { get; set;} 
        public string Endereço { get; set;} 
        public string Telefone { get; set;} 
        public Funcao Funcao { get; set;} 
        public int FuncaoId { get; set;} 
    }
}
