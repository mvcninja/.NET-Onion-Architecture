using Microsoft.EntityFrameworkCore;

namespace CodingWithPalermo.ChurchBulletin.DataAccess.Mappings
{
    // Interface that enforces a Map method is implemented
    public interface IEntityFrameworkMapping
    {
        void Map(ModelBuilder builder);
    }
}
