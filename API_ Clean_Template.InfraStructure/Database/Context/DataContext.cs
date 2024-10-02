using API__Clean_Template.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
namespace API__Clean_Template.InfraStructure.Database.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Configure The Entities here from the domain layer

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
