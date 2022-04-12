using ECommerceWebAPI.DataAccessLayer;
using ECommerceWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.Repository
{
    public class CategoryRepository : IDisposable
    {
        private readonly DLCategoryRepository categoryRepositry;
        public CategoryRepository()
        {
            categoryRepositry = new DLCategoryRepository();
        }
        public async Task<List<ProductCategory>> GetAllCategories()
        {
            return await categoryRepositry.GetAllCategories();
        }
        public void Dispose()
        {

        }
    }
}
