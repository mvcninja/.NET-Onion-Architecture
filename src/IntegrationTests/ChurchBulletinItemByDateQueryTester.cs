using CodingWithPalermo.ChurchBulletin.Core.Queries;
using CodingWithPalermo.ChurchBulletin.DataAccess.Handlers;

namespace CodingWithPalermo.ChurchBulletin.IntegrationTests
{
    public class ChurchBulletinItemByDateQueryTester
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGetWithinDate()
        {
            var query = new ChurchBulletinItemByDateQuery(new DateTime(2000, 1, 1));
            var handler = new ChurchBulletinItemByDateHandler();
            handler.Handle(query);
        }
    }
}
