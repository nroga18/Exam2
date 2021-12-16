using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Exam2
{
    class Task8
    {

       
        public double exchangeRate(string from, string to)
        {
            //Console.WriteLine("Enter From Currency:");
            //string from = Console.ReadLine();
            //Console.WriteLine("Enter To Currency:");
            //string to = Console.ReadLine();


            var curr_dict = getCurrencyDict();
            var rate = exchangeRate(curr_dict, from, to);
            Console.WriteLine($"exchange rate is {rate}");
            return rate;
        }
        public static Dictionary<string, double> getCurrencyDict()
        {
            string url = "http://www.nbg.ge/rss.php";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var res = new List<string>();
            foreach (SyndicationItem syndicationItem in feed.Items)
            {

                string summary = syndicationItem.Summary.Text;
                var list = summary.Split(new string[] { "<td>", "</td>" }, 100000, StringSplitOptions.RemoveEmptyEntries);
                var i = 0;
                foreach (var item in list)
                {
                    if ((i % 10 == 1) || (i % 10 == 5)) res.Add(item);
                    i++;
                }
            }
            Dictionary<string, double> curr_dict =
                       new Dictionary<string, double>();
            var ind = 0;
            while (ind != res.Count)
            {
                var currId = res[ind];
                ind++;
                var currRate = double.Parse(res[ind]);
                curr_dict.Add(currId, currRate);
                ind++;
            }
            return curr_dict;
        }
        static double exchangeRate(Dictionary<string, double> curr_dict, string from, string to)
        {
            double fromRate = curr_dict[from];
            double toRate = curr_dict[to];
            return fromRate/toRate;

        }
    }
}