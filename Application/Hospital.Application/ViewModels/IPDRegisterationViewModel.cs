using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class IPDRegisterationViewModel
    {
        public int Id { get; set; }

        public string? IPDNo { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public virtual PatientViewModel Patient { get; set; }

        [Required]
        public int? RefferById { get; set; }
        public string RefferByName { get; set; }
        public virtual RefferByViewModel RefferBy { get; set; }

        [Required]
        public int? ConsultantInchargeId { get; set; }
        public string ConsultantInchargeName { get; set; }
        public virtual StaffViewModel ConsultantIncharge { get; set; }

        public int? SecondConsultantId { get; set; }
        public string SecondConsultantName { get; set; }
        public virtual StaffViewModel SecondConsultant { get; set; }

        public int? ThirdConsultantId { get; set; }
        public string ThirdConsultantName { get; set; }
        public virtual StaffViewModel ThirdConsultant { get; set; }

        [Required]
        public int? WardId { get; set; }
        public string WardName { get; set; }
        public virtual BasicInformationViewModel Ward { get; set; }

        [Required]
        public int? RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public virtual RoomTypeViewModel RoomType { get; set; }

        [Required]
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public virtual RoomViewModel Room { get; set; }

        [Required]
        public int? BedId { get; set; }
        public string BedName { get; set; }
        public virtual BedViewModel Bed { get; set; }

        public int? CaseTypeId { get; set; }
        public string CaseTypeName { get; set; }
        public virtual BasicInformationViewModel CaseType { get; set; }

        public string? WitnessName { get; set; }

        public int? RelationshipId { get; set; }
        public string RelationshipName { get; set; }
        public virtual BasicInformationViewModel Relationship { get; set; }

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

        public virtual ICollection<IPDRegisterationServiceViewModel> IPDRegisterationServices { get; set; }
        public virtual ICollection<IPDRegisterationRoomViewModel> IPDRegisterationRooms { get; set; }
        public virtual ICollection<IPDRegisterationPaymentViewModel> IPDRegisterationPayments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
