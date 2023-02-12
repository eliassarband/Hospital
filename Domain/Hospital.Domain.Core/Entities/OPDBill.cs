using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("OPDBill", Schema = "Sec")]
    public class OPDBill : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("PatientId")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public string BillNo { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public int PayableAmount { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }


        public virtual ICollection<OPDBillService> OPDBillServices { get; set; }
    }
}
