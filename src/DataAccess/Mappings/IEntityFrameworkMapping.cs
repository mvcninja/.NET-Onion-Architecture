using Microsoft.EntityFrameworkCore;

namespace DataAccess.Mappings
{
    // Interface that enforces a Map method is implemented
    public interface IEntityFrameworkMapping
    {
        void Map(ModelBuilder builder);
    }
}
