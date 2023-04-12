using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.DbModels
{
    public partial class ShopCardItem
    {
        public string IdShopCard { get; set; }

        //public int IdProduct { get; set; }  DELETE!!
        public int ProductId { get; set; }
        public double? Price { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
