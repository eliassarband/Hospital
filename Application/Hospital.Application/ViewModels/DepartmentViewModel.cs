using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int MainDepartmentId { get; set; }
        public string MainDepartmentName { get; set; }
        public DepartmentViewModel MainDeptartment { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
