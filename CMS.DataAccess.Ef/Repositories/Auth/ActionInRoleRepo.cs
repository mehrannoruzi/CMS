using Elk.EntityFrameworkCore;
using CMS.Domain;

namespace CMS.DataAccess.Ef
{
    public class ActionInRoleRepo : EfGenericRepo<ActionInRole>
    {
        public ActionInRoleRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}