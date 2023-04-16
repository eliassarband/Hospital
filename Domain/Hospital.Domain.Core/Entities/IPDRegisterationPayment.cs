using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("IPDRegisterationPayment", Schema = "Med")]
    public class IPDRegisterationPayment : BaseEntity
    {
        [Required]
        [ForeignKey("IPDRegisterationId")]
        public int? IPDRegisterationId { get; set; }
        public virtual IPDRegisteration IPDRegisteration { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("PaymentTypeId")]
        public int? PaymentTypeId { get; set; }
        public virtual BasicInformation PaymentType { get; set; }

        [Required]
        public int Amount { get; set; }

        public string? ChequeNumber { get; set; }

        public string? Description { get; set; }
    }
}
