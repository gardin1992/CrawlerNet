using CrawlerNet.Models;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerNet
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<Config, ConfigViewModel>();
            AutoMapper.Mapper.CreateMap<ConfigViewModel, Config>();

            AutoMapper.Mapper.CreateMap<FileTypes, FileTypesViewModel>();
            AutoMapper.Mapper.CreateMap<FileTypesViewModel, FileTypes>();
            
        }
    }
}
