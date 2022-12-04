using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("Service", Schema = "Gnr")]
    public class Service:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int? OPDRate { get; set; }

        public int? IPDRate { get; set; }

        public int? AddPercentage { get; set; }

        public int? AddAmount { get; set; }

        public int? DiscountPercentage { get; set; }

        public int? DiscountAmount { get; set;}

        public string? Remark { get; set; }

        public int Cost { get; set; }

        public bool NotInUse { get; set; }

    }
}
