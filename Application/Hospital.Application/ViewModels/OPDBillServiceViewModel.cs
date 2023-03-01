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
    public class OPDBillServiceViewModel
    {
        public int Id { get; set; }
        public int? OPDBillId { get; set; }
        public OPDBillViewModel OPDBill { get; set; }

        [Required] 
        public int? ServiceId { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public ServiceViewModel Service { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Discount { get; set; }
        public int Amount { get; set; }

        [Required]
        public int? StaffId { get; set; }
        public string? StaffCode { get; set; }
        public string? StaffName { get; set; }
        public StaffViewModel Staff { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
