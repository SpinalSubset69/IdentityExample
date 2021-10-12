using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class IdentityDbContxtSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager){
            if(!userManager.Users.Any()){
                var user = new AppUser{
                    DisplayName = "Luis",
                    Email = "alastorlml@gmail.com",
                    UserName = "alastor69",
                    Address = new Address {
                        FirstName = "Luis",
                        LastName = "Garza",
                        Street = "Justo Sierra",
                        City = "El Mante",
                        State = "Tamaulipas",
                        ZipCode = "48499"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$word69");
            }
        }
    }
}