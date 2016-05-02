using CrawlerNet.Models;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrawlerNet.Utilities
{
    public interface ITextManager
    {
        string GetTextByFile(string path);
        bool UpdateTextByFile(string path, string contents);
    }

    public abstract class BaseTextManager
        :ITextManager
    {
        public virtual string GetTextByFile(string path)
        {
            string result = String.Empty;

            if (File.Exists(path))
                result = File.ReadAllText(path);

            return result;
        }

        public virtual bool UpdateTextByFile(string path, string contents) 
        {
            bool result = false;

            if (File.Exists(path))
            { 
                File.WriteAllText(path, contents);
                result = true;
            }

            return result;
        }
    }

    public interface IFileContentManager
    {
        FileTypes Get();
        bool Set(FileTypes model);
    }

    public class FileContentManager
        : BaseTextManager, IFileContentManager
    {
        public static string dataRootPath { get { return "~/App_Data"; } }

        public string AudioFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "AudioFiles.txt");
        public string DataFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "DataFiles.txt");
        public string DocumentFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "DocumentFiles.txt");
        public string ExecutableFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "ExecutableFiles.txt");
        public string GraphicFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "GraphicFiles.txt");
        public string VideoFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "VideoFiles.txt");
        public string WebFilesPath = Path.Combine(HttpContext.Current.Server.MapPath(dataRootPath), "WebFiles.txt");
        
        public FileTypes Get()
        {
            var model = new FileTypes();

            model.AudioFiles = GetTextByFile(AudioFilesPath);
            model.DataFiles = GetTextByFile(DataFilesPath);
            model.DocumentFiles = GetTextByFile(DocumentFilesPath);
            model.ExecutablesFiles = GetTextByFile(ExecutableFilesPath);
            model.GraphicFiles = GetTextByFile(GraphicFilesPath);
            model.VideoFiles = GetTextByFile(VideoFilesPath);
            model.WebFiles = GetTextByFile(WebFilesPath);

            return model;
        }

        public bool Set(FileTypes viewModel)
        {
            bool result = false;

            try
            {
                UpdateTextByFile(AudioFilesPath, viewModel.AudioFiles);
                UpdateTextByFile(DataFilesPath, viewModel.DataFiles);
                UpdateTextByFile(DocumentFilesPath, viewModel.DocumentFiles);
                UpdateTextByFile(ExecutableFilesPath, viewModel.ExecutablesFiles);
                UpdateTextByFile(GraphicFilesPath, viewModel.GraphicFiles);
                UpdateTextByFile(VideoFilesPath, VideoFilesPath);
                UpdateTextByFile(WebFilesPath, viewModel.WebFiles);
                result = true;
            }
            catch (Exception)
            {   
                
            }

            return result;
        }
    }


}