using funcionaporfavor.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace funcionaporfavor.Data
{
    public class FakeDataSeeder
    {

        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new HobbyDbContext(
                      serviceProvider
                      .GetRequiredService<DbContextOptions<HobbyDbContext>>());

            if (context.Hobbies.Any()) { return; }

            var hobbies = new List<Hobby>
            {
                new Hobby{ name = "Cooking", createdAt = DateTime.Now },
                new Hobby{ name = "Listening to Music", createdAt = DateTime.Now },
                new Hobby{ name = "Drinking Beer", createdAt = DateTime.Now },
                new Hobby{ name = "Playing Guitar", createdAt = DateTime.Now },
                new Hobby{ name = "Blogging", createdAt = DateTime.Now },
                new Hobby{ name = "Vlogging", createdAt = DateTime.Now },
                new Hobby{ name = "Travelling", createdAt = DateTime.Now },
            };

           context.Hobbies.AddRange(hobbies);

            context.SaveChanges();
        }
    }
}
