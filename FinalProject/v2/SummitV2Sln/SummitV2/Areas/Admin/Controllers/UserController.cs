using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SummitV2.Data;
using SummitV2.Models;
using SummitV2.Models.ViewModels;

namespace SummitV2.Areas.Admin.Controllers
{
    [Authorize(Roles="Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private Repository<ApplicationUser> users;
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<ApplicationUser> userMngr, RoleManager<IdentityRole> roleMngr, ApplicationDbContext context)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            this.context = context;
            users = new Repository<ApplicationUser>(context);
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var users = await userManager.Users.ToListAsync();

            foreach (var user in users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
            }

            UserViewModel model = new UserViewModel
            {
                Users = users,
                Roles = roleManager.Roles
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateUserVM());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateUserVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                TempData["Message"] = "User created successfully!";
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            return View(user);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConf(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            context.Users.Remove(user);
            await context.SaveChangesAsync();

            TempData["Message"] = $"User '{user.UserName}' was deleted successfully.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            return View(user);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ApplicationUser model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            user.UserName = model.UserName;
            user.Email = model.Email;
            // adding more fields here later if needed


            await users.UpdateAsync(user);
            TempData["Message"] = $"User '{user.UserName}' was updated.";
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> AddToRole(string userId, string roleName)
        {
            IdentityRole role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                TempData["message"] = $"Role '{roleName}' doesn't exist.";
            }
            else
            {
                ApplicationUser user = await userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromRole(string userId, string roleName)
        {
            ApplicationUser user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                await userManager.RemoveFromRoleAsync(user, roleName);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(string rolename)
        {
            await roleManager.CreateAsync(new IdentityRole(rolename));

            return RedirectToAction("Index");
        }
    }
}
