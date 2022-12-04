using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("User", Schema = "Sec")]
    public class User : BaseEntity
    {
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Username { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public bool Active { get; set; }

        [MaxLength(100)]
        public string Theme { get; set; }

        [ForeignKey("AttachmentId")]
        public int? AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
