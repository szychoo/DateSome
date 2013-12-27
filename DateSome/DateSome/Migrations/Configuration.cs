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

            UserProfile userProfile2 = new UserProfile()
            {
                Nickname = "Daisy",
                Age = 20,
                City = city1,
                Description = "Jestem Daisy",
                Hobbies = new List<Hobby>() { hobby2 },
                PartnerDescription = "Szukam swojego Kaczora Donalda..."
            };

            context.UserProfiles.AddOrUpdate(up => up.Nickname, new[] { userProfile1, userProfile2 });


            Message message1 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 1 Title",
                Text = "Message 1 text",
                Read = true,
                SendDateTime = DateTime.Now
            };

            Message message2 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 2 Title",
                Text = "Message 2 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message1
            };

            Message message3 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 3 Title",
                Text = "Message 3 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message2
            };

            Message message4 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 4 Title",
                Text = "Message 4 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message3
            };

            Message message5 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 5 Title",
                Text = "Message 5 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message4
            };

            Message message6 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 6 Title",
                Text = "Message 6 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message5
            };

            Message message7 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 7 Title",
                Text = "Message 7 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message6
            };

            Message message8 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 8 Title",
                Text = "Message 8 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message7
            };

            Message message9 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 9 Title",
                Text = "Message 9 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message8
            };

            Message message10 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 10 Title",
                Text = "Message 10 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message9
            };

            Message message11 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 11 Title",
                Text = "Message 11 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message10
            };

            Message message12 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 12 Title",
                Text = "Message 12 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message11
            };

            Message message13 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 13 Title",
                Text = "Message 13 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message12
            };

            Message message14 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 14 Title",
                Text = "Message 14 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message13
            };

            Message message15 = new Message()
            {
                Sender = userProfile1,
                Receiver = userProfile2,
                Title = "Message 15 Title",
                Text = "Message 15 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message14
            };

            Message message16 = new Message()
            {
                Sender = userProfile2,
                Receiver = userProfile1,
                Title = "Message 16 Title",
                Text = "Message 16 text",
                Read = true,
                SendDateTime = DateTime.Now,
                ReplyTo = message15
            };

            context.Messages.AddOrUpdate(m=>m.Title, message1,message2,message3,message4,
                message5,message6,message7,message8, message9, message10, message11, message12, message13, message14, message15, message16);
        }
    }
}
