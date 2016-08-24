using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MarketsInfo.Models;
using System.Net;
using System.Text;
using System.IO;


namespace MarketsInfo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var news = db.News.Include(p => p.Author)
                .Include(n => n.Comments).OrderByDescending(n => n.date).Take(5).ToList();
            return View(news.ToList());
        }




        public ActionResult Markets()
        {


            string csvData;
            string symbols = "EURUSD=X, AAPL, GOOG, MSFT, ^DJI, ^IXIC, CL=F";
            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=" + symbols + "&f=snbaopl1");
                List<StockInfo> stocks = YahooFinance.Parse(csvData);

                return View(stocks);


            }
        }


       


        public ActionResult test()
        {
            return View();
        }

       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var news = db.News.Include(n => n.Author).Include(n => n.Comments).FirstOrDefault(n => n.Id == id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

    }
}