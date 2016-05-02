using CrawlerNet.Crawler;
using CrawlerNet.Utilities;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CrawlerNet.Controllers
{
    public class CrawlerController 
        : BaseController
    {
        public CrawlerNetScanner crawler = null;

        public CrawlerController()
        {
            this.crawler = CrawlerNetScanner.Current;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Default()
        {
            return View(new CrawlerViewModel());
        }

        [HttpPost]
        public ActionResult Default(CrawlerViewModel viewModel)
        {
            try
            {
                crawler.Crawl(viewModel);
            }
            catch (Exception ex)
            {
                viewModel.ErrorMsg = ex.Message;
            }
            return View(viewModel);
        }

        public ActionResult ExportByJson()
        {
            List<Uri> data = crawler.allLinksOnPage;

            ExportJson(data);

            return RedirectToAction("Default");
        }

        public ActionResult ExportByText()
        {
            List<Uri> data = crawler.allLinksOnPage;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Count; i++)
            {
                builder.AppendFormat("{0} --- {1} ", i + 1, data[i]);
                builder.AppendLine();
            }

            ExportText(builder.ToString());

            return RedirectToAction("Default");
        }
        public ActionResult ExportByExcel()
        {
            // data list
            List<Uri> data = crawler.allLinksOnPage;

            // data table
            DataTable dtable = new DataTable();
            dtable.Columns.Add("Order", typeof(int));
            dtable.Columns.Add("Link", typeof(string));

            for (int i = 0; i < data.Count; i++)
            {
                dtable.Rows.Add(i + 1, data[i].ToString());
            }

            ExportExcel(dtable);

            return RedirectToAction("Default");
        }
	}
}