using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("Group", Schema = "Sec")]
    public class Group : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }

	}
}
