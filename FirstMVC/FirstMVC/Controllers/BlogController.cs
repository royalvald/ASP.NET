using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            /* ViewBag.Message = "welcome";
             ViewBag.s1 = "hello";

             return View();*/

            ViewData["one"] = "11111111111";
            ViewBag.two = "22222222222";
            var users = new User { Name = "3333333333" };
            TempData["four"] = "4444444444";

            return View(users);
        }

        public ActionResult ShowArticle()
        {
            return View("Article");
        }
    }
}