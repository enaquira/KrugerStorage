using System;
using System.Collections.Generic;
using System.Text;

namespace Kruger.Storage.Data.Model
{
    public class StorageOrderModel
    {
        public int StorageOrderId { get; set; }
        public int ProductId { get; set; }
        public int RackId { get; set; }
        public short OrderQty { get; set; }
        public int ColumnNumber { get; set; }
        public int RowNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }

        public string ProductName { get; set; }
        public int StorageId { get; set; }
        public string RackName { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
