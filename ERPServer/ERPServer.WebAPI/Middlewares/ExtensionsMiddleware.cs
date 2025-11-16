using ERPServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ERPServer.WebAPI.Middlewares
{
    public static class ExtensionsMiddleware
    {
        public static void CreateFirstUser(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any(p => p.UserName == "ilayda"))
                {
                    AppUser user = new()
                    {
                        UserName = "ilayda",
                        Email = "ilaydatech@gmail.com",
                        FirstName = "ilayda",
                        LastName = "sümer",
                        EmailConfirmed = true
                    };

                    userManager.CreateAsync(user, "1").Wait();
                }
            }
        }
    }
}
