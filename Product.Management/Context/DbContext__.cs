using Microsoft.EntityFrameworkCore;
using Product.Management.Model.Command;

namespace Product.Management.Context
{
    public class DbContext__ : DbContext
    {
        public DbContext__(DbContextOptions<DbContext__> dbContextOptions ):base(dbContextOptions) { }

        public DbSet<InsertObjectModel> Product { get; set; }
    }
}
