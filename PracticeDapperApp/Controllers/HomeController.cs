using Microsoft.AspNetCore.Mvc;
using PracticeDapperApp.Models;
using PracticeDapperApp.Services;
using System.Threading.Tasks;

namespace PracticeDapperApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchUser()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            return View();
        }

        public async Task<IActionResult> CreateUser(UserModel userModel)
        {
            await _userService.CreateUser(userModel);
            return View("ShowUser", userModel);
        }

        public async Task<IActionResult> FindUser(string id)
        {
            var userModel = await _userService.FindUser(id);
            return View("ShowUser", userModel);
        }
    }
}
