using System;
using System.Collections.Generic;

#nullable disable

namespace CooperativaAgroCreativa.Models.DB
{
    public partial class UserOrder
    {
        public string UserId { get; set; }
        public string OrderProducts { get; set; }
    }
}
