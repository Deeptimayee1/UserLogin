using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
