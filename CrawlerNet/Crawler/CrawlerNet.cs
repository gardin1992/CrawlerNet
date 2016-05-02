using Abot.Core;
using Abot.Crawler;
using Abot.Poco;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CrawlerNet.Crawler
{
    public class CrawlerNetScanner
    {
        private static CrawlerNetScanner _current = null;
        private static object _lockObj = new object();

        public static CrawlerNetScanner Current
        {
            get
            {
                if (_current == null)
                {
                    lock (_lockObj)
                    {
                        if (_current == null)
                        {
                            _current = new CrawlerNetScanner();
                        }
                    }
                }

                return _current;
            }
        }
               
        public IWebCrawler crawler = null;
        public List<Uri> allLinksOnPage { get; set; }
        
        private CrawlerNetScanner()
        {
            
        }

        void crawler_PageCrawlCompleted(object sender, PageCrawlCompletedArgs e)
        {
            var AllLinksOnPage = new HapHyperLinkParser().GetLinks(e.CrawledPage);

            foreach (var item in AllLinksOnPage)
            {
                if (!allLinksOnPage.Contains(item))
                    allLinksOnPage.Add(item);
            }
        }

        public CrawlerViewModel Crawl(CrawlerViewModel viewModel)
        {
            if (!Helper.IsValidUrl(viewModel.UrlToCrawl))
            { 
                viewModel.ErrorMsg = String.Format(" Please enter mail adress");
                return viewModel;
            }

            allLinksOnPage = new List<Uri>();
            CrawlConfiguration config = new CrawlerNetConfig().Initalize();
            this.crawler = new PoliteWebCrawler(config);

            crawler.PageCrawlCompleted += crawler_PageCrawlCompleted; 
            
            // 

            CrawlResult result = crawler.Crawl(new Uri(viewModel.UrlToCrawl));

            if (result.ErrorOccurred)
                viewModel.ErrorMsg = String.Format("Crawler completed with error: {0}", result.ErrorException.Message);

            var isProd = Convert.ToBoolean(ConfigurationManager.AppSettings["IsProd"].ToString());
            if (isProd)
                viewModel.CrawledLinks.AddRange(allLinksOnPage);
            else viewModel.CrawledLinks.AddRange(allLinksOnPage.Take(10));

            viewModel.SuccessMsg = " Successfully Listed !";

            return viewModel;
        }
    }
}