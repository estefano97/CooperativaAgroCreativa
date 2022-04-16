using System;
using System.Collections.Generic;

#nullable disable

namespace CooperativaAgroCreativa.Models.DB
{
    public partial class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
