using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.Models
{
    public class ProductsComingToExpireViewModel
    {
        [DisplayName("Nombre del producto")]
        public string ProductName { get; set; }
        [DisplayName("# de la bodega")]
        public int StorageId { get; set; }
        [DisplayName("Nombre del estante")]
        public string RackName { get; set; }
        [DisplayName("Fila estante")]
        public int Row { get; set; }
        [DisplayName("Columna estante")]
        public int Column { get; set; }
        [DisplayName("Fecha de vencimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DiscontinuedDate { get; set; }
    }
}
