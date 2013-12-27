using DateSome.Models;
using DateSome.Models.Mapping;
using System.Data.Entity;

namespace DateSome.DataAccess
{
    public class DateSomeDbContext : DbContext
    {
        public DateSomeDbContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer<DateSomeDbContext>(new DateSomeDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("BusinessLogic");
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new MessageMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}