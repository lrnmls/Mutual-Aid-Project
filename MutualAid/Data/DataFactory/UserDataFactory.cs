using Microsoft.EntityFrameworkCore;
using MutualAidRefactorEFCore.Data.Entities;

namespace MutualAidRefactorEFCore.Data.DataFactory
{
    public static class UserDataFactory
    {
        private const string DefaultPassword = "MyPassword1!";

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Lauren",
                    LastName = "Miles",
                    Email = "lauren.miles@kizan.com",
                    Password = "Password1",
                    PhoneNumber = "1112223333",
                    County = "Franklin",
                    isAdmin = true
                },
                 new User
                 {
                     Id = 2,
                     FirstName = "Molly",
                     LastName = "Byrtus",
                     Email = "molly.byrtus@gmail.com",
                     Password = "Password1",
                     PhoneNumber = "2223334444",
                     County = "Franklin",
                     isAdmin = false
                 },
               new User
               {
                   Id = 3,
                   FirstName = "Jami",
                   LastName = "Miles",
                   Email = "jami.miles@gmail.com",
                   Password = "Password1",
                   PhoneNumber = "3334445555",
                   County = "Greene",
                   isAdmin = false
               },
               new User
               {
                   Id = 4,
                   FirstName = "Kensie",
                   LastName = "Hill",
                   Email = "kensie.hill@hm.com",
                   Password = "Password1",
                   PhoneNumber = "4445556666",
                   County = "Franklin",
                   isAdmin = true
               },
               new User
               {
                   Id = 5,
                   FirstName = "Jules",
                   LastName = "Toback",
                   Email = "jules.toback@covermymeds.com",
                   Password = "Password1",
                   PhoneNumber = "5556667777",
                   County = "Darke",
                   isAdmin = false
               }
               ); ;
        }
    }
}
