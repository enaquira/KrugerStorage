using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.Models
{
    public class CustomerIndexViewModel
    {
        public int CustomerId { get; set; }
        [DisplayName("Tipo de cliente")]
        public int CustomerTypeId { get; set; }
        [DisplayName("Num. doc.")]
        public string DocumentNumber { get; set; }
        [DisplayName("Tipo doc.")]
        public int DocumentTypeId { get; set; }
        [DisplayName("Nombre")]
        public string FirstName { get; set; }
        [DisplayName("Apellido")]
        public string LastName { get; set; }
        [DisplayName("Direccion")]
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
