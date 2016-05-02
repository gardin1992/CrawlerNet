using Abot.Core;
using Abot.Crawler;
using Abot.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebCrawler crawler = new PoliteWebCrawler();

            crawler.PageCrawlCompletedAsync += crawler_PageCrawlCompletedAsync;
            //crawler.

            CrawlResult result = crawler.Crawl(new Uri("http://apps.devolv.com/spider/"));

            if (result.ErrorOccurred)
                Console.WriteLine("Crawl of {0} completed with error: {1}", result.RootUri.AbsoluteUri, result.ErrorException.Message);
            else
                Console.WriteLine("Crawl of {0} completed without error.", result.RootUri.AbsoluteUri);


            Console.ReadLine();
        }

        static void crawler_PageCrawlCompletedAsync(object sender, PageCrawlCompletedArgs e)
        {
            Console.WriteLine(e.CrawledPage.Uri);

            IEnumerable<Uri> allLinksOnPage = new HapHyperLinkParser().GetLinks(e.CrawledPage);
            IEnumerable<Uri> internalLinks = allLinksOnPage.Where(l => l.Authority == e.CrawlContext.RootUri.Authority);
            IEnumerable<Uri> externalLinks = allLinksOnPage.Except(internalLinks);
        }
    }
}
