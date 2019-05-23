using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class StorageOrder
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

        public virtual Product Product { get; set; }
        public virtual Rack Rack { get; set; }
    }
}
