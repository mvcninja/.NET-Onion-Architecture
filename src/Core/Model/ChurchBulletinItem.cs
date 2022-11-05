
namespace CodingWithPalermo.ChurchBulletin.Core.Model
{
    public class ChurchBulletinItem : EntityBase<ChurchBulletinItem>
    {
        public override Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Place { get; set; }
        public DateTime Date { get; set; }
    }
}
