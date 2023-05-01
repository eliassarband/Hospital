using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("FormCategory", Schema = "Sec")]
    public class FormCategory : BaseEntity
    {
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

		public bool ShowInDashboard { get; set; } = true;

        public int Priority { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}
