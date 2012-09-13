using MVC3_1.CustomMvcFeatures.Filters;
using MVC3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Logon()
        {
            return View();
        }

        public ActionResult Logon2(int id = 5)
        {
            return View(id);
        }

        [HttpGet]
        public ActionResult UserInfo()
        {
            var u = new UserInfoModel { FirstName = "first name", LastName = "last name", UserID = 3, Categories = this.GetCategories()};
            return View(u);
        }

        [HttpPost]
        public ActionResult UserInfo(UserInfoModel model)
        {
            model.Categories = this.GetCategories();

            return View(model);
        }

        private IEnumerable<CategoryModel> GetCategories()
        {
            return new[]
            {
                new CategoryModel { CategoryID = 1, Name = "Employee" },
                new CategoryModel { CategoryID = 2, Name = "Player" },
                new CategoryModel { CategoryID = 3, Name = "Boss" }
            };
        }
    }
}
