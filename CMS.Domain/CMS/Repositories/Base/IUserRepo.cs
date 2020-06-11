using Elk.Core;
using System.Threading.Tasks;

namespace CMS.Domain
{
    public interface IUserRepo : IGenericRepo<User>, IScopedInjection
    {}
}
