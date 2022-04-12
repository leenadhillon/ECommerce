using ECommerceConfigHelper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDataHelper
{
    public class DbConnectionFactory : IConnectionFactoryAsync
    {
        private readonly DbProviderFactory _provider;
        private readonly string _connectionString;
        public DbConnectionFactory()
        {
            using (SqlConnection _connection = new SqlConnection())
            {
                PropertyInfo dbProviderFactoryProperty = _connection.GetType().GetProperty("DbProviderFactory", BindingFlags.NonPublic | BindingFlags.Instance);
                _provider = dbProviderFactoryProperty.GetValue(_connection) as DbProviderFactory;
            }

            _connectionString = ApplicationConfigManager.SqlConnectionString;
        }

        public async Task<SqlConnection> CreateAsync()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _connectionString;
            await connection.OpenAsync();
            return connection;
        }
    }
}
