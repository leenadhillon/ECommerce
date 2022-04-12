using ECommerceDataHelper;
using ECommerceWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.DataAccessLayer
{
    public class DLProductAttributeRepository : DataConnectionRepository, IDisposable
    {
        public async Task<List<ProductAttribute>> GetAllProductAttribute(SqlParameter[] parameter)
        {
            return (await this.ExecuteAsync<ProductAttribute>("uspGetProductAttribute", parameter)).ToList();
        }
        public void Dispose()
        {
            base.DisposeRepository();
        }
    }
}
