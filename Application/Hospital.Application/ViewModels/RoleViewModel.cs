using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserRoleViewModel> UserRoles { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRole { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedRole { get; set; }
    }
}
