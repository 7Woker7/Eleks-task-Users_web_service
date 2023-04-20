using Microsoft.EntityFrameworkCore;
using DatabaseService.Models;

namespace DatabaseService.Data
{
    public class DatabaseServiceContext : DbContext
    {
        public DatabaseServiceContext(DbContextOptions<DatabaseServiceContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
