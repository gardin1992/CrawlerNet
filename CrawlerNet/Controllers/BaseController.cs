using CrawlerNet.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrawlerNet.Controllers
{
    public interface IController 
    {
        void ExportJson(object data);
        void ExportExcel(DataTable data);
        void ExportText(string data);
    }

    public abstract class BaseController
        : Controller, IController
    {
        protected readonly IMappingGetter mapper = null;
        public BaseController()
        {
            this.mapper = new MappingGetter();
        }

        //Export Operation Method

        public void ExportJson(object data)
        {
            var JsonString = JsonConvert.SerializeObject(data);

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=ParsedLinks.json");
            Response.ContentType = "application/json";
            Response.Charset = "";

            StringWriter sw = new StringWriter();
            sw.Write(JsonString);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

        public void ExportExcel(DataTable data)
        {
            var grid = new GridView();
            grid.DataSource = data;
            grid.DataBind();

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=ParsedLinks.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            grid.RenderControl(htw);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

        public void ExportText(string data)
        {
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=ParsedLinks.txt");
            Response.ContentType = "application/text";
            Response.Charset = "";

            StringWriter sw = new StringWriter();
            sw.Write(data);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

	}
}