using System;

namespace CMS.Domain
{
    public class UserDTO
    {
        public Guid? Token { get; set; }

        public string Fullname { get; set; }

        public long MobileNumber { get; set; }
    }
}
