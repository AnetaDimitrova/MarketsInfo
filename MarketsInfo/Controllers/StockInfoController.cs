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
    public class StockInfoController : Controller
    {
        // GET: StockInfo
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult CommoditiesFutures()
        {


            string csvData;
            string symbols = "ZG=F, CL=F";
            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=" + symbols + "&f=snbaopl1");
                List<StockInfo> stocks = YahooFinance.Parse(csvData);

                return View(stocks);


            }
        }

        public ActionResult Indices()
        {


            string csvData;
            string symbols = "^DJI, ^GSPC, ^IXIC,^BATSK, ^GDAXI, ^N225, ^HSI, ^FCHI, ^NZ50, ^KLSE";
            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=" + symbols + "&f=snbaopl1");
                List<StockInfo> stocks = YahooFinance.Parse(csvData);

                return View(stocks);
            }

        }

        public ActionResult Forex()
        {


            string csvData;
            string symbols = "EURUSD=X, CNY=X, CAD=X, CHF=X, EUR=X, GBPUSD=X";
            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=" + symbols + "&f=snbaopl1");
                List<StockInfo> stocks = YahooFinance.Parse(csvData);

                return View(stocks);
            }
        }

        public ActionResult StockQuotes()
        {


            string csvData;
            string symbols = "AAPL, GOOG, MSFT";
            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=" + symbols + "&f=snbaopl1");
                List<StockInfo> stocks = YahooFinance.Parse(csvData);

                return View(stocks);
            }
        }
    }
}