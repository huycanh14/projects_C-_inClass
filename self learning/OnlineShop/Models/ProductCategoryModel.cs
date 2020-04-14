using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductCategoryModel
    {
        private OnlineShopDbContext context = null;
        public ProductCategoryModel()
        {
            context = new OnlineShopDbContext();
        }

        public List<ProductCategory>ListAll()
        {
            var list = context.Database.SqlQuery<ProductCategory>("Sp_ProductCategory_ListAll").ToList();
            return list;
        }
    }
}
