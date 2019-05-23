using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class Rack
    {
        public Rack()
        {
            StorageOrder = new HashSet<StorageOrder>();
        }

        public int RackId { get; set; }
        public int StorageId { get; set; }
        public string Description { get; set; }
        public int ColumnQty { get; set; }
        public int RowQty { get; set; }
        public int OrderNumber { get; set; }

        public virtual Storage Storage { get; set; }
        public virtual ICollection<StorageOrder> StorageOrder { get; set; }
    }
}
