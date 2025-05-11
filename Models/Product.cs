using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        //[Key] -> Anotacion si la propiedad no se llama Id, ejemplo ProductId
        public int Id { get; set; } // será la llave primaria
        public string Name { get; set; }
        public Category Category { get; set; } //Propiedad de navegación
        [Column(TypeName = "decimal(6,2)")]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }//Será la llave foránea
        
    }
}
