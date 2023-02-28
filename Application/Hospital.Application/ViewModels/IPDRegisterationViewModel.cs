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

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int? PatientId { get; set; }
        public string PatientName { get; set; }
        public virtual PatientViewModel Patient { get; set; }

        [Required]
        public int? RefferById { get; set; }
        public string RefferByName { get; set; }
        public virtual RefferByViewModel RefferBy { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public int PayableAmount { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }


        public virtual ICollection<IPDRegisterationServiceViewModel> IPDRegisterationServices { get; set; }
        public virtual ICollection<IPDRegisterationRoomViewModel> IPDRegisterationRooms { get; set; }
        public virtual ICollection<IPDRegisterationPaymentViewModel> IPDRegisterationPayments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
