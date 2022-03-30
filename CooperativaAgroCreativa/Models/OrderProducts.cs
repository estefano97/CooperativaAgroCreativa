using System;
using System.Collections.Generic;

namespace CooperativaAgroCreativa.Models
{
    public partial class OrderProducts
    {
        public string ProductId { get; set; }
        public string Talla { get; set; }
        public int Quantity { get; set; }
    }
}