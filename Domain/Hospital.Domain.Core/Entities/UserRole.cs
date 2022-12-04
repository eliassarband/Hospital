using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Domain.Core.Entities.Base;

namespace Hospital.Domain.Core.Entities
{
    [Table("UserRole", Schema = "Sec")]
    public class UserRole : BaseEntity
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
