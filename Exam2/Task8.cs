using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Exam2
{
    public class Task8
    {

        public static void RunTask8()
        {
            var inputFrom = "USD";
            var inputTo = "EUR";
            Console.WriteLine($"Task_8: \ninput: from: {inputFrom}, to: {inputTo}\noutput: {ExchangeRate(inputFrom, inputTo)}\n");
        }
        public static double ExchangeRate(string from, string to)
        {
            var curr_dict = GetCurrencyDict();
            var rate = ExchangeRate(curr_dict, from, to);
            return rate;
        }
        public static Dictionary<string, double> GetCurrencyDict()
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
        static double ExchangeRate(Dictionary<string, double> curr_dict, string from, string to)
        {
            double fromRate = curr_dict[from];
            double toRate = curr_dict[to];
            return fromRate/toRate;

        }
    }
}