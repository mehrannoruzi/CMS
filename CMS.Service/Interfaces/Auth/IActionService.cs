using Elk.Core;
using System.Threading.Tasks;
using CMS.Domain;
using System.Collections.Generic;
using Action = CMS.Domain.Action;

namespace CMS.Service
{
    public interface IActionService : IScopedInjection
    {
        Task<IResponse<Action>> AddAsync(Action model);
        Task<IResponse<Action>> FindAsync(int actionId);
        Task<IResponse<Action>> UpdateAsync(Action model);
        Task<IResponse<bool>> DeleteAsync(int actionId);
        IDictionary<object, object> Get(bool justParents = false);
        PagingListDetails<Action> Get(ActionSearchFilter filter);
        IDictionary<object, object> Search(string query, int take = 10);
    }
}