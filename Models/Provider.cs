namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; }  // Será la llave primaria
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Provider>? Providers { get; set; } = default!;  // Propiedad de navegación
    }
}
