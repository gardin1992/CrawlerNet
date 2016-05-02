using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrawlerNet.Utilities
{
    public enum AlertType { Success, Info, Warning, Danger }

    public static class HtmlExtentions
    {
        public static MvcHtmlString Alert(this HtmlHelper helper, AlertType type, string text)
        {
            String result = String.Empty;

            switch (type)
            {
                case AlertType.Success: result = String.Format("<div class=\"alert alert-success\" role=\"alert\"> <strong>Heads up!</strong>{0}</div>", text);
                    break;
                case AlertType.Info: result = String.Format("<div class=\"alert alert-info\" role=\"alert\"><strong>Oh snap!</strong>{0}</div>", text);
                    break;
                case AlertType.Warning: result = String.Format("<div class=\"alert alert-warning\" role=\"alert\"> <strong>Well done!</strong> {0}</div>", text);
                    break;
                case AlertType.Danger: result = String.Format("<div class=\"alert alert-danger\" role=\"alert\"><strong>Warning!</strong>{0}</div>", text);
                    break;
                default:
                    break;
            }

            if (String.IsNullOrEmpty(text))
                result = string.Empty;

            return new MvcHtmlString(result);
        }

    }
}