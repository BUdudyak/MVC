using Microsoft.AspNetCore.Mvc;
using MVC_login.Models;
using System.Collections.Generic;

namespace MVC_login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Check(UserModel model)
        {
            if(model.Login == null || model.Password == null)
            {
                return RedirectToAction("Index");
            }

            foreach(var item in GetUsers())
            {
                if(model.Login == item.Login && model.Password == item.Password)
                {
                    model.IsAdmin = item.IsAdmin;
                    model.IsLogged = true;
                    break;
                }
            }

            return View("Check", model);
        }

        public List<UserModel> GetUsers()
        {
            return new List<UserModel>
            {
                new UserModel() { Login = "Bogdanchek", Password = "Pupsik", IsAdmin = true},
                new UserModel() { Login = "Vadim ne smatri", Password = "123456", IsAdmin = false},
                new UserModel() { Login = "admin", Password = "admin", IsAdmin = true},
                new UserModel() { Login = "Gigached", Password = "000000", IsAdmin = false},
                new UserModel() { Login = "NeSuperUser", Password = "neadmin", IsAdmin = false},
                new UserModel() { Login = "neBogdanchek", Password = "nePupsik", IsAdmin = false}
            };
        }
    }
}
