using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class userController : Controller
    {
        public userTable usrtbl=new userTable();


        
        [HttpPost]
        public ActionResult About(userTable Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }
    }
}
