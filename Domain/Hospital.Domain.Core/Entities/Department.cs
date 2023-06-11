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
    [Table("Department", Schema = "Gnr")]
    public class Department:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public bool IsMain { get; set; }

        [ForeignKey("MainDepartmentId")]
        public int? MainDepartmentId { get; set; }
        public virtual Department? MainDepartment { get; set; }

        public bool NotInUse { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<IPDRegisterationPayment> IPDRegisterationPayments { get; set; }

    }
}
