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
    public class StaffTimingViewModel
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string? StaffCode{ get; set; }
        public string? StaffName { get; set; }
        public virtual StaffViewModel Staff { get; set; }
        public int WeekDayNo { get; set; }
        public string WeekDayName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
