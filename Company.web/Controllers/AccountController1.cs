using Microsoft.AspNetCore.Mvc;

namespace Company.web.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
