using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("ReportTemplate", Schema = "Gnr")]
    public class ReportTemplate : BaseEntity
    {
        [MaxLength(100)]
        public string Code { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength]
        public string? Content { get; set; }
    }
}
