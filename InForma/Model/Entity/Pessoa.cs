using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entity
{
    public class Pessoa
    {
        //entity modalidade
        public int Id { get; set; }

        public Colaborador Colaborador { get; set; }
        public int? ColaboradorId { get; set; }
        public Aluno Aluno { get; set; }
        public int? AlunoId { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo CPF")]
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

    }
}
