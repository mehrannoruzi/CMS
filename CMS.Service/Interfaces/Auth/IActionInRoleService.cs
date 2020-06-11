using Elk.Core;
using System.Threading.Tasks;
using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Service
{
    public interface IActionInRoleService : IScopedInjection
    {
        Task<IResponse<ActionInRole>> AddAsync(ActionInRole model);
        Task<IResponse<bool>> DeleteAsync(int id);
        IEnumerable<ActionInRole> GetRoles(int actionId);
        IEnumerable<ActionInRole> GetActions(int roleId);
    }
}