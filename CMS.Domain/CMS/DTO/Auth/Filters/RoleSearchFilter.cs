using Elk.Core;
using CMS.Domain.Resource;
using System.ComponentModel.DataAnnotations;

namespace CMS.Domain
{
    public class RoleSearchFilter : PagingParameter
    {
        [Display(Name = nameof(Strings.NameFa), ResourceType = typeof(Strings))]
        [StringLength(30, ErrorMessageResourceName = nameof(ErrorMessage.MaxLength), ErrorMessageResourceType = typeof(ErrorMessage))]
        public string RoleNameFaF { get; set; }

        [Display(Name = nameof(Strings.NameEn), ResourceType = typeof(Strings))]
        [StringLength(30, ErrorMessageResourceName = nameof(ErrorMessage.MaxLength), ErrorMessageResourceType = typeof(ErrorMessage))]
        public string RoleNameEnF { get; set; }
    }
}
