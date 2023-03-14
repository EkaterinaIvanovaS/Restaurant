using Dal.DbModels;
using Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mocks
{
    public class MockProducts : IAllProducts
    {
        public IEnumerable<Product> Products
        {
            get {
                return new List<Product>
                {
                    new Product
                    {
                        Name = "Вегетарианская",
                        CategoryId = 1,
                        Price = 450
                    }
                };
            }
        }

        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectProduct(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}
