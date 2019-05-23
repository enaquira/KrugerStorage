using System;
using System.Collections.Generic;
using System.Text;

namespace Kruger.Storage.Data.Model
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
