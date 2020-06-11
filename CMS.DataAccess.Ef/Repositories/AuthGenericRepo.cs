using Elk.EntityFrameworkCore;

namespace CMS.DataAccess.Ef
{
    public class AuthGenericRepo<T> : EfGenericRepo<T> where T : class
    {
        public AuthGenericRepo(AuthDbContext authDbContext) : base(authDbContext) { }
    }
}