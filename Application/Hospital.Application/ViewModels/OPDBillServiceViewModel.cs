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
        public int? ServiceId { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }
        public int? StaffId { get; set; }
        public string? StaffCode { get; set; }
        public string? StaffName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedOPDBillService { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedOPDBillService { get; set; }
    }
}
