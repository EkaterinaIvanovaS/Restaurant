using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DbModels
{
    public partial class Order
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Adress { get; set; }
        public string NumberOfPhone { get; set; }
        public List<OrderToProduct> orderToProducts { get; set; }
    }
}
