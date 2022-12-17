using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public string Theme { get; set; }
        public int? AttachmentId { get; set; }
        public string? AttachmentFullName { get; set; }
        public string? AttachmentContentType { get; set; }
        public byte[]? AttachmentContent { get; set; }
        public string? AttachmentDescription { get; set; }
        public AttachmentViewModel? Attachment { get; set; }
        public virtual ICollection<UserRoleViewModel> UserRoles { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
