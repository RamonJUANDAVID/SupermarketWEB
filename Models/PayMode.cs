﻿namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; }  // Será la llave primaria
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<PayMode>? PayModes { get; set; } = default!;  // Propiedad de navegación
    }
}
}
