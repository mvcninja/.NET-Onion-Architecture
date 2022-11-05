using CodingWithPalermo.ChurchBulletin.Core.Model;
using CodingWithPalermo.ChurchBulletin.Core.Queries;
using CodingWithPalermo.ChurchBulletin.DataAccess.Mappings;

namespace CodingWithPalermo.ChurchBulletin.DataAccess.Handlers
{
    public class ChurchBulletinItemByDateHandler
    {
        readonly DataContext _context;
        
        public ChurchBulletinItemByDateHandler(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<ChurchBulletinItem> Handle(ChurchBulletinItemByDateQuery query)
        {
            var results = _context.Set<ChurchBulletinItem>().Where(item => item.Date == query.TargetDate).AsEnumerable();
            return results;
        }
    }
}