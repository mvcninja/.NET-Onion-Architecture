using DataAccess;
using Microsoft.Extensions.Configuration;

namespace IntegrationTests
{
    public class TestDataConfiguration : IDataConfiguration
    {
        public string GetConnectionString()
        {
            return "server=(LocalDb)\\MSSQLLocalDB;database=ChurchBulletin;Integrated Security=true";
        }
    }
}
