using CodingWithPalermo.ChurchBulletin.Core.Model;
using Shouldly;

namespace CodingWithPalermo.ChurchBulletin.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var class1 = new ChurchBulletinItem();
            class1.ShouldNotBeNull();
        }
    }
}