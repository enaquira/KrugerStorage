using System;
using System.Collections.Generic;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class Storage
    {
        public Storage()
        {
            Rack = new HashSet<Rack>();
        }

        public int StorageId { get; set; }
        public int ProductCategoryId { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        public int RacksWidthQty { get; set; }
        public int RacksLenghtQty { get; set; }

        public virtual ICollection<Rack> Rack { get; set; }
    }
}
