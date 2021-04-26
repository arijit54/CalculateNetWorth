using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateNetWorth.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
