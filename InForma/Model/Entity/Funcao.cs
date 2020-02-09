using System.ComponentModel.DataAnnotations;
namespace Model.Entity
{
    public class Funcao
    {
        public Funcao()
        {
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório campo Modalidade")]
        public string TipoFuncao { get; set; }
        public bool Ativo { get; set; }
    }
}
