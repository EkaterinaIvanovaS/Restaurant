using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.DbModels
{
    public partial class ShopCardItem
    {
        public int IdProduct { get; set; }
        public double? Price { get; set; }
        public string IdShopCard { get; set; }
        public int? ProductId { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual ShopCard IdShopCardNavigation { get; set; }
    }
}
