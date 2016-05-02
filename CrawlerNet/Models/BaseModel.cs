using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawlerNet.Models
{
    public interface IModel
    {

    }

    public class BaseModel
        : IModel
    {
        public Guid UniqueId { get; private set; }
        public int Id { get; set; }

        public BaseModel()
        {
            this.UniqueId = Guid.NewGuid();
            this.CreateDate = DateTime.Now;
        }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}