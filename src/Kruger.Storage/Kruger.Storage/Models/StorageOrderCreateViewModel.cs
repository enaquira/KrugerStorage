using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.Models
{
    public class StorageOrderCreateViewModel
    {
        [DisplayName("Producto")]
        public int ProductId { get; set; }
        [DisplayName("# de bodega disponible")]
        public int StorageId { get; set; }
        [DisplayName("Estante disponible")]
        public int RackId { get; set; }
        [DisplayName("Cantidad a guardar")]
        public short OrderQty { get; set; }
        [DisplayName("Columna estante")]
        public int ColumnNumber { get; set; }
        [DisplayName("Fila estante")]
        public int RowNumber { get; set; }
        [DisplayName("Fecha de ingreso")]
        public DateTime EntryDate { get; set; }
        [DisplayName("Fecha de salida")]
        public DateTime? DepartureDate { get; set; }
        [DisplayName("Fecha de vencimiento")]
        public DateTime DiscontinuedDate { get; set; }
        public int CustomerId { get; set; }
    }
}
