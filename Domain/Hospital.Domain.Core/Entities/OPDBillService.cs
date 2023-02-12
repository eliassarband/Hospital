using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("OPDBillService", Schema = "Sec")]
    public class OPDBillService : BaseEntity
    {
        [Required]
        [ForeignKey("OPDBillId")]
        public int? OPDBillId { get; set; }
        public virtual OPDBill OPDBill { get; set; }

        [Required]
        [ForeignKey("ServiceId")]
        public int? ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Rate { get; set; }

        public int Discount { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        [ForeignKey("StaffId")]
        public int? StaffId { get; set; }
        public virtual Staff Staff { get; set; }

    }
}
