using DateSome.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using System.IO;

namespace DateSome.DataAccess
{
    public class DateSomeDbInitializer : DropCreateDatabaseAlways<DateSomeDbContext>
    {
        protected override void Seed(DateSomeDbContext context)
        {
            City city1 = new City() { Name = "Poznań" };
            City city2 = new City() { Name = "Warszawa" };
            City city3 = new City() { Name = "Wrocław" };

            context.Cities.AddOrUpdate(c => c.Name,
                new[]{city1, city2, city3
                });

            Hobby hobby1 = new Hobby() { Name = "Sport" };
            Hobby hobby2 = new Hobby() { Name = "Książki" };
            Hobby hobby3 = new Hobby() { Name = "Zbieranie grzybów" };

            context.Hobbies.AddOrUpdate(h => h.Name, new[] { hobby1, hobby2, hobby3 });

            UserProfile userProfile1 = new UserProfile()
            {
                Nickname = "KaczorDonald",
                Age = 25,
                City = city1,
                Description = "Jestem Kaczor Donald",
                Hobbies = new List<Hobby>() { hobby1, hobby3 },
                PartnerDescription = "Szukam swojej Daisy...",
                Picture = File.ReadAllBytes("C:\\Donald_Duck.gif")
            };

            context.UserProfiles.AddOrUpdate(up => up.Nickname, new[] { userProfile1 });


            base.Seed(context);
        }
    }
}