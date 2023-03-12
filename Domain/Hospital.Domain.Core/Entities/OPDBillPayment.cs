using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("OPDBillPayment", Schema = "Med")]
    public class OPDBillPayment : BaseEntity
    {
        [Required]
        [ForeignKey("OPDBillId")]
        public int? OPDBillId { get; set; }
        public virtual OPDBill OPDBill { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Amount { get; set; }

        public string? Description { get; set; }

    }
}
