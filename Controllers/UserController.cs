using simple_login_registration_version_one.Models;
using Microsoft.AspNetCore.Mvc;
namespace simple_login_registration_version_one.Controllers
{
    public class User : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("Register")]
        public IActionResult Register(UserRegistration newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLogin existingUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}