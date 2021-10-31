using System.Data.Entity;

namespace Asp_DotNet_MVC_WebApplication_Authorization.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=con")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}