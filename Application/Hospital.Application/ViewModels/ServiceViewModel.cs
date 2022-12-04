using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public virtual DepartmentViewModel Department { get; set; }
        public int OPDRate { get; set; }
        public int IPDRate { get; set; }
        public int AddPercentage { get; set; }
        public int AddAmount { get; set; }
        public int DiscountPercentage { get; set; }
        public int DiscountAmount { get; set; }
        public string Remark { get; set; }
        public int Cost { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
