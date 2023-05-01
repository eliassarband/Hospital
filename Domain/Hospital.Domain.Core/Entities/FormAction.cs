using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("FormAction", Schema = "Sec")]
    public class FormAction : BaseEntity
    {
		[ForeignKey("FormId")]
		public int FormId { get; set; }
		public virtual Form Form { get; set; }

		[MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Priority { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
        
    }
}
