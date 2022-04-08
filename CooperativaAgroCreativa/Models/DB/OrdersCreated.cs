using System;
using System.Collections.Generic;

#nullable disable

namespace CooperativaAgroCreativa.Models.DB
{
    public partial class OrdersCreated
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Products { get; set; }
        public string IdUser { get; set; }
        public int IsAcepted { get; set; }
    }
}
