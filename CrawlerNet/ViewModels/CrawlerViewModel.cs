using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawlerNet.ViewModels
{
    public class CrawlerViewModel
        :BaseViewModel
    {
        public CrawlerViewModel()
        {
            this.CrawledLinks = new List<Uri>();
        }

        public string UrlToCrawl { get; set; }

        public List<Uri> CrawledLinks { get; set; } 

    }
}