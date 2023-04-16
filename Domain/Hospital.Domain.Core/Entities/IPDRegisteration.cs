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

        [ForeignKey("ConsultantInchargeId")]
        public int? ConsultantInchargeId { get; set; }
        public virtual Staff ConsultantIncharge { get; set; }

        [ForeignKey("SecondConsultantId")]
        public int? SecondConsultantId { get; set; }
        public virtual Staff SecondConsultant { get; set; }

        [ForeignKey("ThirdConsultantId")]
        public int? ThirdConsultantId { get; set; }
        public virtual Staff ThirdConsultant { get; set; }

        
        [ForeignKey("WardId")]
        public int? WardId { get; set; }
        public virtual BasicInformation Ward { get; set; }

        [ForeignKey("RoomTypeId")]
        public int? RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        [ForeignKey("RoomId")]
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }

        [ForeignKey("BedId")]
        public int? BedId { get; set; }
        public virtual Bed Bed { get; set; }

        [ForeignKey("CaseTypeId")]
        public int? CaseTypeId { get; set; }
        public virtual BasicInformation CaseType { get; set; }

        public string? WitnessName { get; set; }

        [ForeignKey("RelationshipId")]
        public int? RelationshipId { get; set; }
        public virtual BasicInformation Relationship { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public int PayableAmount { get; set; }

        public string? Details { get; set; }

        public string? Agreement { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public int? PrintCount { get; set; } = 0;

        public int? OPDBillId { get; set; } 

        public virtual ICollection<IPDRegisterationService> IPDRegisterationServices { get; set; }
        public virtual ICollection<IPDRegisterationRoom> IPDRegisterationRooms { get; set; }
        public virtual ICollection<IPDRegisterationPayment> IPDRegisterationPayments { get; set; }
    }
}
