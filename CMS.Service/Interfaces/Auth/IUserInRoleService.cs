using System;
using Elk.Core;
using System.Threading.Tasks;
using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Service
{
    public interface IUserInRoleService : IScopedInjection
    {
        Task<IResponse<UserInRole>> Add(UserInRole model);
        Task<IResponse<bool>> Delete(int id);
        IEnumerable<UserInRole> Get(Guid userId);
    }
}