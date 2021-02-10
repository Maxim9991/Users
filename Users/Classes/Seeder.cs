using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Users.Classes
{
    public static class Seeder
    {
        public static void SeedDatabase(MyContext context)
        {
            SeedAspNetRoles(context);
            SeedAspNetUsers(context);
            SeedAspNetUserRoles(context);
        }

        private static void SeedAspNetRoles(MyContext context)
        {
            if(context.AspNetRoles.Count() == 0)
            {
                context.AspNetRoles.Add(new AspNetRoles
                {
                    Name = "Roles",
                    NormalizedName = "Roles. Inc",
                    ConcurrencyStamp = "Штамп",
                });
                context.SaveChanges();
            }
        }

        private static void SeedAspNetUsers(MyContext context)
        {
            if(context.AspNetUsers.Count() == 0)
            {
                context.AspNetUsers.Add(new AspNetUsers
                {
                    UserName = "Valera2",
                    NormalizedUserName = "Valer4ik2",
                    Email = "valera111@gmail.com2",
                    PhoneNumber = "(097) 111-22-332"
                });
                context.SaveChanges();
            }    
        }

        private static void SeedAspNetUserRoles(MyContext context)
        {
            if(context.AspNetUserRoles.Count() == 0)
            {
                context.AspNetUserRoles.Add(new AspNetUserRoles
                {
                    RoleId = 1,
                    UserId = 7
                });
                context.SaveChanges();
            }
        }
    }
}
