using Elk.EntityFrameworkCore;
using CMS.Domain;

namespace CMS.DataAccess.Ef
{
    public class UserInRoleRepo : EfGenericRepo<UserInRole>
    {
        public UserInRoleRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}