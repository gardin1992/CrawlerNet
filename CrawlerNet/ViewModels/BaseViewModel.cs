using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerNet.ViewModels
{
    public interface IViewModel
    {

    }

    public class BaseViewModel
        : IViewModel
    {
        public Guid UniqueId { get; private set; }
        public int Id { get; set; }

        public BaseViewModel()
        {
            this.UniqueId = Guid.NewGuid();
            this.CreateDate = DateTime.Now;
            this.SuccessMsg = String.Empty;
            this.ErrorMsg = String.Empty;
        }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

        public string ErrorMsg { get; set; }
        public string SuccessMsg { get; set; }


    }
}
