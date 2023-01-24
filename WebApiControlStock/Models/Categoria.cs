using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiControlStock.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Column(TypeName = "varchar(50)")]
        
        public string Nombre { get; set; }
    }
}
