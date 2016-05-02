using CrawlerNet.Models;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerNet.Utilities
{
    public interface IMappingGetter
    {
        TDestination GetModel<TDestination>(IViewModel viewmodel);
        TDestination GetViewModel<TDestination>(IModel model);
        IList<TDestination> GetListModel<TDestination>(IQueryable<IViewModel> viewModelList);
        IList<TDestination> GetListViewModel<TDestination>(IQueryable<IModel> modelList);
    }

    public class MappingGetter
         : IMappingGetter
    {
        public TDestination GetModel<TDestination>(IViewModel viewModel)
        {
            return AutoMapper.Mapper.Map<TDestination>(viewModel);
        }

        public TDestination GetViewModel<TDestination>(IModel model)
        {
            return AutoMapper.Mapper.Map<TDestination>(model);
        }

        public IList<TDestination> GetListModel<TDestination>(IQueryable<IViewModel> viewModelList)
        {
            IList<TDestination> result = new List<TDestination>();

            foreach (var item in viewModelList)
            {
                result.Add(this.GetModel<TDestination>(item));
            }

            return result;
        }

        public IList<TDestination> GetListViewModel<TDestination>(IQueryable<IModel> modelList)
        {
            IList<TDestination> result = new List<TDestination>();

            foreach (var item in modelList)
            {
                result.Add(this.GetViewModel<TDestination>(item));
            }

            return result;
        }
    }
}
