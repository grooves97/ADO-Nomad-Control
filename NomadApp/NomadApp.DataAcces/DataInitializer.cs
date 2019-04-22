using System;
using System.Collections.Generic;
using System.Data.Entity;
using NomadApp.Models;

namespace NomadApp.DataAcces
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<User> users;
        private List<Comics> comics;

        protected override void Seed(DataContext context)
        {
            users = new List<User>
            {
                new User
                {
                    FullName = "Олег Скидан",
                    IsSubscribed = true,
                    SubsSince = DateTime.Now,
                    SubsYear = 1
                }
            };

            comics = new List<Comics>
            {
                new Comics
                {
                    Name = "Avengers",
                    ReleaseDate = DateTime.Now
                }
            };
            context.Users.AddRange(users);
            context.Comics.AddRange(comics);
            base.Seed(context);
        }
    }
}
