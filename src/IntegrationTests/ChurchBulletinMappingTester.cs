using CodingWithPalermo.ChurchBulletin.Core.Model;
using CodingWithPalermo.ChurchBulletin.DataAccess.Mappings;
using Shouldly;

namespace CodingWithPalermo.ChurchBulletin.IntegrationTests
{
    public class ChurchBulletinMappingTester
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldMapChurchBulletin()
        {
            var bulletin = new ChurchBulletinItem();
            bulletin.Name = "Worship service";
            bulletin.Place = "Sanctuary";
            bulletin.Date = new DateTime(2022, 1, 1);

            using (var context = new DataContext(new TestDataConfiguration()))
            {
                context.Add(bulletin);
                context.SaveChanges();
            }

            ChurchBulletinItem? actual;
            using (var context = new DataContext(new TestDataConfiguration()))
            {
                actual = context.Set<ChurchBulletinItem>()
                    .SingleOrDefault(b => b == bulletin);
            }

            actual.ShouldNotBeNull();
            actual.Id.ShouldBe(bulletin.Id);
            actual.ShouldBe(bulletin);
            actual.Name.ShouldBe(bulletin.Name);
            actual.Place.ShouldBe(bulletin.Place);
            actual.Date.ShouldBe(bulletin.Date);
        }
    }
}