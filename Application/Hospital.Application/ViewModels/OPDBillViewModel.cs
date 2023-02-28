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
    public class OPDBillViewModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public PatientViewModel Patient { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int PaymentTypeId { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeStrCode { get; set; }
        public string PaymentTypeName { get; set; }
        public BasicInformationViewModel PaymentType { get; set; }


        [Required]
        [Range(1, int.MaxValue)]
        public int TotalAmount { get; set; }

        public int PayableAmount { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OPDBillServiceViewModel> OPDBillServices { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
