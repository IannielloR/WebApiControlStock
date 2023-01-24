using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiControlStock.Models
{
    [Table("producto")]
    public class Producto
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "char(1)")]
        public string LineaProducto { get; set; }

        [Column(TypeName ="money")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set;}
    }
}
