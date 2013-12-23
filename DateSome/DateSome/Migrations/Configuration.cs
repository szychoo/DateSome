namespace DateSome.Migrations
{
    using DateSome.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DateSome.DataAccess.DateSomeDbContext>
    {
        public Configuration()
        {
            
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DateSome.DataAccess.DateSomeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            City city1 = new City() { Name = "Poznañ" };
            City city2 = new City() { Name = "Warszawa" };
            City city3 = new City() { Name = "Wroc³aw" };
            
            context.Cities.AddOrUpdate(c => c.Name,
                new[]{city1, city2, city3
                });

            Hobby hobby1 = new Hobby() { Name = "Sport" };
            Hobby hobby2 = new Hobby() { Name = "Ksi¹¿ki" };
            Hobby hobby3 = new Hobby() { Name = "Zbieranie grzybów" };

            context.Hobbies.AddOrUpdate(h => h.Name, new[] { hobby1, hobby2, hobby3 });

            UserProfile userProfile1 = new UserProfile()
            {
                Nickname = "KaczorDonald",
                Age = 25,
                City = city1,
                Description = "Jestem Kaczor Donald",
                Hobbies = new List<Hobby>() { hobby1, hobby3},
                PartnerDescription = "Szukam swojej Daisy...",
                Picture =File.ReadAllBytes("C:\\Donald_Duck.gif")
            };

            context.UserProfiles.AddOrUpdate(up => up.Nickname, new[] { userProfile1 });
        }
    }
}
