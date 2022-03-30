using System;
using System.Collections.Generic;

#nullable disable

namespace CooperativaAgroCreativa.Models.DB
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string UnityPrice { get; set; }
        public string State { get; set; }
        public DateTime? Date { get; set; }
        public string Image { get; set; }
    }
}
