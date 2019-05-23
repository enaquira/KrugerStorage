using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class Product
    {
        public Product()
        {
            StorageOrder = new HashSet<StorageOrder>();
        }

        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnitMeasureCode { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual UnitMeasure SizeUnitMeasureCodeNavigation { get; set; }
        public virtual UnitMeasure WeightUnitMeasureCodeNavigation { get; set; }
        public virtual ICollection<StorageOrder> StorageOrder { get; set; }
    }
}
