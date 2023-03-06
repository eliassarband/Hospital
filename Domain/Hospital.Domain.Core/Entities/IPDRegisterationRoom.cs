using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("IPDRegisterationRoom", Schema = "Med")]
    public class IPDRegisterationRoom : BaseEntity
    {
        [Required]
        [ForeignKey("IPDRegisterationId")]
        public int? IPDRegisterationId { get; set; }
        public virtual IPDRegisteration IPDRegisteration { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("BedId")]
        public int? BedId { get; set; }
        public virtual Bed Bed { get; set; }

        [Required]
        public int Days { get; set; }

        [Required]
        public int Rate { get; set; }

        [Required]
        public int Amount { get; set; }

        public string Description { get; set; }
    }
}
