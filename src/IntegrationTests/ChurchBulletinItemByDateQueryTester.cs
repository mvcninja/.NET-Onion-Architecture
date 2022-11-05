using CodingWithPalermo.ChurchBulletin.Core.Model;
using CodingWithPalermo.ChurchBulletin.Core.Queries;
using CodingWithPalermo.ChurchBulletin.DataAccess.Handlers;
using CodingWithPalermo.ChurchBulletin.DataAccess.Mappings;
using Shouldly;

namespace CodingWithPalermo.ChurchBulletin.IntegrationTests
{
    public class ChurchBulletinItemByDateQueryTester
    {
        private static DataContext GetContext()
        {
            return new DataContext(new TestDataConfiguration());
        }
 
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGetWithinDate()
        {
            var item1 = new ChurchBulletinItem { Date = new DateTime(2000, 1, 1) };
            var item2 = new ChurchBulletinItem { Date = new DateTime(2000, 1, 2) };
            var item3 = new ChurchBulletinItem { Date = new DateTime(1999, 12, 31) };
            var item4 = new ChurchBulletinItem { Date = new DateTime(2000, 1, 1) };

            using (var context = GetContext())
            {
                context.AddRange(item1, item2, item3, item4);
                context.SaveChanges();
            }

            try
            {
                //arrange
                var query = new ChurchBulletinItemByDateQuery(new DateTime(2000, 1, 1));
                var handler = new ChurchBulletinItemByDateHandler(GetContext());

                //act
                var items = handler.Handle(query).ToArray();

                //assert
                items.Length.ShouldBe(2);
                items.ShouldContain(item1);
                items.ShouldContain(item4);
                items.ShouldNotContain(item2);
                items.ShouldNotContain(item3);
            }
            finally
            {
                using (var context = GetContext())
                {
                    context.RemoveRange(item1, item2, item3, item4);
                    context.SaveChanges();
                }
            }
        }
    }
}
