using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawlerNet.Models
{
    public class FileTypes
        :BaseModel
    {
        public string AudioFiles { get; set; }
        public string DataFiles { get; set; }
        public string DocumentFiles { get; set; }
        public string ExecutablesFiles { get; set; }
        public string GraphicFiles { get; set; }
        public string VideoFiles { get; set; }
        public string WebFiles { get; set; }
    }
}