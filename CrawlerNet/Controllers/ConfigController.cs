using CrawlerNet.Models;
using CrawlerNet.Utilities;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrawlerNet.Controllers
{
    public class ConfigController 
        : BaseController
    {

        protected readonly IFileContentManager fileManager = null;
        public ConfigController()
        {
            this.fileManager = new FileContentManager();
        }

        public ActionResult Index()
        {
            var config = ConfigManager.GetConfig();
            ConfigViewModel configViewModel = mapper.GetViewModel<ConfigViewModel>(config);

            return View(configViewModel);
        }

        [HttpPost]
        public ActionResult Index(ConfigViewModel configViewModel)
        {
            var configModel = mapper.GetModel<Config>(configViewModel);

            try
            {
                ConfigManager.SetConfig(configModel);
                configViewModel.SuccessMsg = " Successfully Updated";
            }
            catch (Exception ex)
            {
                configViewModel.ErrorMsg = ex.Message;
            }

            return View(configViewModel);
        }

        public ActionResult File()
        {
            var fileTypes = fileManager.Get();
            FileTypesViewModel fileTypesViewModel = mapper.GetViewModel<FileTypesViewModel>(fileTypes);

            return View(fileTypesViewModel);
        }

        [HttpPost]
        public ActionResult File(FileTypesViewModel fileTypesViewModel)
        {

            var fileTypesModel = mapper.GetModel<FileTypes>(fileTypesViewModel);

            try
            {
                fileManager.Set(fileTypesModel);
                fileTypesViewModel.SuccessMsg = " Successfully Updated";
            }
            catch (Exception ex)
            {
                fileTypesViewModel.ErrorMsg = ex.Message;
            }

            return View(fileTypesViewModel);
        }


	}
}