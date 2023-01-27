using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DAL;
using DAL.Models;
using UserEFDemo.Models;

namespace UserEFDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        protected List<User> Users = new List<User>();
        public ActionResult Index()
        {
            BLL_Class bll = new BLL_Class();
            Users = bll.GetUser_BLL();
            return View(Users);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(FEUser u)
        {
            if (ModelState.IsValid)
            {


                BLL_Class bll = new BLL_Class();

                User user = new User();

                user.Name = u.Name;
                user.Password = u.Password;
                user.Email = u.Email;
               

                bll.AddUser_BLL(user);
                return RedirectToAction("index");
            }
            else
            {
                return View("Create");
            }

        }
    }

}