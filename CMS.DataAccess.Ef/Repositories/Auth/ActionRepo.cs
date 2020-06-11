using Elk.EntityFrameworkCore;
using CMS.Domain;

namespace CMS.DataAccess.Ef
{
    public class ActionRepo : EfGenericRepo<Action>
    {
        public ActionRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}