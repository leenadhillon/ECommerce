using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ECommerceDataHelper
{
    public interface IConnectionFactoryAsync
    {
        Task<SqlConnection> CreateAsync();
    }
}
