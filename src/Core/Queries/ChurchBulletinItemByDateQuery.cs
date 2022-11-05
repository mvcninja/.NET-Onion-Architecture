namespace CodingWithPalermo.ChurchBulletin.Core.Queries
{
    public class ChurchBulletinItemByDateQuery
    {
        public DateTime TargetDate { get; }

        public ChurchBulletinItemByDateQuery(DateTime targetDate)
        {
            TargetDate = targetDate;
        }
    }
}
