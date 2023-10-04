using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEApi.Models;
using System.Diagnostics;

namespace SEApi.Controllers
{
    public class HomeController : Controller
    {
        //// TODO comment for production
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<IdentityUser> _userManager;

        //// TODO comment for production
        //public HomeController(RoleManager<IdentityRole> roleManager,
        //                      UserManager<IdentityUser> userManager)
        //{
        //    _roleManager = roleManager;
        //    _userManager = userManager;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
           // // TODO comment for production
           // //Creates a role if it does not exist
           // //Good for first time launch, delete after
           //string[] roles = { "Admin", "Manager",};

           // foreach (var role in roles)
           // {
           //     var roleExitst = await _roleManager.RoleExistsAsync(role);

           //     if (roleExitst == false)
           //     {
           //         await _roleManager.CreateAsync(new IdentityRole(role));
           //     }
           // }

           // // TODO comment for production
           // // Adds roles to test account
           // var user = await _userManager.FindByEmailAsync("test@test.com");

           // if (user != null)
           // {
           //     await _userManager.AddToRoleAsync(user, "Admin");
           //     await _userManager.AddToRoleAsync(user, "Manager");
           // }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}