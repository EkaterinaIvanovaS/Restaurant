using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.DbModels
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public double? Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
