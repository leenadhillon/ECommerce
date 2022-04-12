using ECommerceDataHelper;
using ECommerceWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.DataAccessLayer
{
    public class DLCategoryRepository : DataConnectionRepository, IDisposable
    {
        public async Task<List<ProductCategory>> GetAllCategories()
        {
            return (await this.ExecuteAsync<ProductCategory>("uspProductCategory")).ToList();
        }
        public void Dispose()
        {
            base.DisposeRepository();
        }
    }
}