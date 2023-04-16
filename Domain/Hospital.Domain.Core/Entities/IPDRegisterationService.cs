using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("IPDRegisterationService", Schema = "Med")]
    public class IPDRegisterationService : BaseEntity
    {
        [Required]
        [ForeignKey("IPDRegisterationId")]
        public int? IPDRegisterationId { get; set; }
        public virtual IPDRegisteration IPDRegisteration { get; set; }

        [Required]
        public DateTime Date { get; set; }

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


        public string? Description { get; set; }
    }
}
