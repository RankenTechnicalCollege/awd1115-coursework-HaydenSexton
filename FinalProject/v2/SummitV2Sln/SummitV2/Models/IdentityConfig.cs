using Microsoft.AspNetCore.Identity;

namespace SummitV2.Models
{
    public class IdentityConfig
    {
        public static async Task CreateAdminUserAsync(IServiceProvider provider)
        {
            //GUIDE IF YOU NEED TO MAKE YOUR OWN USER ADMIN
            // 1.LOGIN WITH BUNGIE INTO THE APP
            // 2.REPLACE userId WITH YOUR USERID IN THE DB
            // 3.RERUN APP AND LOGOUT AND LOG BACK IN

            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = provider.GetRequiredService<UserManager<ApplicationUser>>();

            string userId = "4a34051d-2930-45cd-b424-ae708724e5fb"; // (step 2) 
            string roleName = "Admin";

            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            var user = await userManager.FindByIdAsync(userId);

            if (user != null)
            {
                if (!await userManager.IsInRoleAsync(user, roleName))
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
