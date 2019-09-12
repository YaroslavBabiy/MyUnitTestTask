using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using HtmlAgilityPack;

namespace MyUnitTestTask
{
    public class Context
    {
        public static async void GetHtmlAsync()
        {
            var collection = new List<string>();
            var url = "https://www.booking.com/searchresults.en-us.html?label=gen173nr-1FCAEoggI46AdIM1gEaOkBiAEBmAEpuAEXyAEM2AEB6AEB-AELiAIBqAIDuAKAiunrBcACAQ&lang=en-us&sid=5011154a9d347be58cbb69e5b81eaf7a&sb=1&src=index&src_elem=sb&error_url=https%3A%2F%2Fwww.booking.com%2Findex.html%3Flabel%3Dgen173nr-1FCAEoggI46AdIM1gEaOkBiAEBmAEpuAEXyAEM2AEB6AEB-AELiAIBqAIDuAKAiunrBcACAQ%3Bsid%3D5011154a9d347be58cbb69e5b81eaf7a%3Bsb_price_type%3Dtotal%26%3B&ss=New+York&is_ski_area=0&checkin_month=05&checkin_monthday=01&checkin_year=2020&checkout_month=05&checkout_monthday=30&checkout_year=2020&group_adults=2&group_children=0&no_rooms=1&b_h4u_keep_filters=&from_sf=1";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var CityList = htmlDocument.DocumentNode.SelectNodes("//a[contains(@class, "bui-link")]").
                Where(x => x.Attributes["class"].Value.Contains(("bui-link")));
            foreach (var item in CityList)
            {
                if (item != null)
                {
                    collection.Add(item.LastChild.InnerText.Trim().Replace("-", ""));
                }
                Console.WriteLine("empty");
            }
        }
    }
}
