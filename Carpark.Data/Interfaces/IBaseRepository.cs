using Carpark.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Carpark.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAll(params string[] includes);
        Task CreateMany(IEnumerable<T> models);
        Task<PaginatedResponseModel<T>> GetPaginatedData(int pageNumber, int pageSize);

        Task<PaginatedResponseModel<T>> GetPaginatedDataByRequest(PaginatedRequestModel request, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

        Task<bool> CheckValidationByFilter(Expression<Func<T, bool>> filter);

        Task<List<T>> GetListByFilter(Expression<Func<T, bool>> filter, string sortColumnName = null, bool isDescending = false, params Expression<Func<T, object>>[] includes);

        Task<T> GetDetailByFilter(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);

        Task<T> GetById<Tid>(Tid id);

        Task<bool> IsExists<Tvalue>(string key, Tvalue value);

        Task<T> GetDetailByFilterAdvance(
            Expression<Func<T, bool>> filter,
            params string[] includes);

        Task<bool> IsExistsForUpdate<Tid>(Tid id, string key, string value);

        Task<T> Create(T model);

        Task<IEnumerable<T>> BulkInsert(IEnumerable<T> lstModel);

 

        Task Update(T model);
        Task UpdateMany(IEnumerable<T> models);
        void UpdateUnitOfWork(T model);

        Task GetAndUpdateMany(Expression<Func<T, bool>> filter, Action<T> setProperty);

        Task Delete(T model);

        Task SaveChangeAsync();
        List<T> GetListFilterAdvance(Func<T, bool> filter,
            params Expression<Func<T, object>>[] includes);
        IQueryable<T> Include(params Expression<Func<T, object>>[] includes);
    }
}
