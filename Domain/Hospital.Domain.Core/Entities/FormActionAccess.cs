using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Domain.Core.Entities.Base;

namespace Hospital.Domain.Core.Entities
{
    [Table("FormActionAccess", Schema = "Sec")]
    public class FormActionAccess : BaseEntity
    {
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("GroupId")]
        public int? GroupId { get; set; }
        public virtual Group? Group { get; set; }

		[ForeignKey("FormActionId")]
		public int FormActionId { get; set; }
		public virtual FormAction FormAction { get; set; }
	}
}
