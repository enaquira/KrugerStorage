using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customer = new HashSet<Customer>();
        }

        public int CustomerTypeId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
