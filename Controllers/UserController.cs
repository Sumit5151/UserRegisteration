using Microsoft.AspNetCore.Mvc;
using UserRegisteration.DataLayer;
using UserRegisteration.Models;
using UserRegisteration.Repository;

namespace UserRegisteration.Controllers
{
    public class UserController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Registration()
        {
            UserRegisterationViewModel userRegisterationVM = new UserRegisterationViewModel();
            return View(userRegisterationVM);
        }

        [HttpPost]
        public IActionResult Registration(UserRegisterationViewModel userRegisterationVM)
        {

            if (ModelState.IsValid == true)
            {

                UserRepository userRepository = new UserRepository();
                userRepository.Save(userRegisterationVM);
                return RedirectToAction("Index");
            }
            return View(userRegisterationVM);
        }
    }
}
