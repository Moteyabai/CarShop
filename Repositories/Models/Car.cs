using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; } = null!;
    }
}
