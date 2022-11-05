using CodingWithPalermo.ChurchBulletin.DataAccess;

namespace CodingWithPalermo.ChurchBulletin.IntegrationTests
{
    public class TestDataConfiguration : IDataConfiguration
    {
        public string GetConnectionString()
        {
            return "server=(LocalDb)\\MSSQLLocalDB;database=ChurchBulletin;Integrated Security=true";
        }
    }
}
