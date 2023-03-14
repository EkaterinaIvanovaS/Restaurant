using Dal.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> getFavProducts { get; set; }
        Product getObjectProduct(int productId);
    }
}