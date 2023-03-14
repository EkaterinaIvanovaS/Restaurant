using Dal.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class ProductRepository : DefaultDbContext
    {
        private readonly DefaultDbContext appDBContent;

        public ProductRepository(DefaultDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public Product getObjectProduct(int productId) => appDBContent.Products.FirstOrDefault(p => p.Id == productId);
    }
}
