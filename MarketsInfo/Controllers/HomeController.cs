using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MarketsInfo.Models;


namespace MarketsInfo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var news = db.News.Include(p => p.Author)
                .OrderByDescending(p => p.date).Take(5);

            return View(news.ToList());
        }

       

        public ActionResult Markets()
        {
            

            return View();
        }
    }
}