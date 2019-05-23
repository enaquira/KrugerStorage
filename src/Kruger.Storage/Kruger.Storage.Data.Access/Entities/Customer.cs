using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Product = new HashSet<Product>();
        }

        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
