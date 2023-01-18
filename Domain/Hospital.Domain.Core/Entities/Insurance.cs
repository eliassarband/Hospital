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
    [Table("Insurance", Schema = "Med")]
    public class Insurance : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [Range(0,100)]
        public int OPDDiscountPercent { get; set; }

        [Required]
        [Range(0, 100)]
        public int IPDDiscountPercent { get; set; }

        [Required]
        [Range(0, 100)]
        public int AdvancePaymentPercent { get; set; }

        [Required]
        [Range(0, System.Int32.MaxValue)]
        public int AdvancePaymentAmount { get; set; }

        [Required]
        [ForeignKey("InsurancePaymentTypeId")]
        public int InsurancePaymentTypeId { get; set; }
        public virtual BasicInformation InsurancePaymentType { get; set; }

        public bool NotInUse { get; set; }


    }
}
