using Microsoft.AspNetCore.Mvc;
using UserRegisteration.DataLayer;

namespace UserRegisteration.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {

            if (ModelState.IsValid == true)
            {
                BrightDb2Context db = new BrightDb2Context();
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
