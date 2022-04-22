using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_crud_backend.Models
{
    [Table("Produto")]
    public class Produto
    {   
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
