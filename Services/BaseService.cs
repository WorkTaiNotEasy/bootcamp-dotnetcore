using bootcamp_dotnetcore.Models;
using bootcamp_dotnetcore.Models.Abstractions;
using bootcamp_dotnetcore.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace bootcamp_dotnetcore.Services
{
    public class BaseService<TViewModel, TDatabaseModel> : IBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IViewModel
        where TDatabaseModel : BaseEntity
    {
        public ServiceResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<long> Delete(IEnumerable<int> idList)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<bool> Delete(int id, bool hardDelete)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<TViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<TViewModel> GetById(int id, params Expression<Func<TDatabaseModel, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<int> GetCount()
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<long> Insert<TInsertViewModel>(TInsertViewModel model) where TInsertViewModel : IViewModel
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<long> Insert<TInsertViewModel>(IEnumerable<TInsertViewModel> entities) where TInsertViewModel : IViewModel
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<TViewModel> List(int rowCount)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<long> Update<TInsertViewModel>(TInsertViewModel model) where TInsertViewModel : IViewModel
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<long> Update<TInsertViewModel>(IEnumerable<TInsertViewModel> entities) where TInsertViewModel : IViewModel
        {
            throw new NotImplementedException();
        }
    }
}
