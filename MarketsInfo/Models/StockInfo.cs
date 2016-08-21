using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MarketsInfo.Models
{
 
    public class StockInfo
    {
        [Key]
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public decimal Open { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal Last { get; set; }
        public DateTime StockDate { get; set; }
    }

    public static class YahooFinance
    {
        public static List<StockInfo> Parse(string csvData)
        {
               
            try
            {
                List < StockInfo > stocks = new List<StockInfo>();
                string[] rows = csvData.Replace("r", "").Replace("\"", "").Split('\n');
                foreach (string row in rows)
                {
                    if (string.IsNullOrEmpty(row)) continue;
                    string[] cols = row.Split(',');
                    StockInfo s = new StockInfo();
                    s.Symbol = cols[0];
                    s.Name = cols[1];
                    s.Bid = Convert.ToDecimal(cols[2] == "N/A" ? "0" : cols[2]);
                    s.Ask = Convert.ToDecimal(cols[3] == "N/A" ? "0" : cols[3]);
                    s.Open = Convert.ToDecimal(cols[4] == "N/A" ? "0" : cols[4]);
                    s.PreviousClose = Convert.ToDecimal(cols[5] == "N/A" ? "0" : cols[5]);
                    s.Last = Convert.ToDecimal(cols[6] == "N/A" ? "0" : cols[6]);
                    s.StockDate = DateTime.Now;
                    stocks.Add(s);
                    
                }
                return stocks;
            }
            catch(Exception ex)
            {
                string error = ex.Message.ToString();
            }
            return null;
        }
    }

}