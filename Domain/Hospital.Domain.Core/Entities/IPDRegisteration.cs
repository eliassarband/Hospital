using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("IPDRegisteration", Schema = "Med")]
    public class IPDRegisteration : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("PatientId")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("RefferById")]
        public int? RefferById { get; set; }
        public virtual RefferBy RefferBy { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public int PayableAmount { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }


        public virtual ICollection<IPDRegisterationService> IPDRegisterationServices { get; set; }
        public virtual ICollection<IPDRegisterationRoom> IPDRegisterationRooms { get; set; }
        public virtual ICollection<IPDRegisterationPayment> IPDRegisterationPayments { get; set; }
    }
}
