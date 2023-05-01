using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("Form", Schema = "Sec")]
    public class Form : BaseEntity
    {
		[ForeignKey("FormCategoryId")]
		public int FormCategoryId { get; set; }
		public virtual FormCategory FormCategory { get; set; }

		[MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public bool ShowInMenu { get; set; } = true;

		public int Priority { get; set; }

        public string Url { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

		public virtual ICollection<FormAction> FormActions { get; set; }

	}
}
