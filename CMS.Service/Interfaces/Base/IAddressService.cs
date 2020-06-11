using System;
using Elk.Core;
using System.Threading.Tasks;
using CMS.Domain;

namespace CMS.Service
{
    public interface IAddressService
    {
        IResponse<PagingListDetails<AddressDTO>> Get(Guid userId);
        Task<IResponse<Address>> FindAsync(int id);
    }
}