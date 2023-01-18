using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("StaffTiming", Schema = "Med")]
    public class StaffTiming : BaseEntity
    {

        [Required]
        [ForeignKey("StaffId")]
        public int? StaffId { get; set; }
        public virtual Staff Staff { get; set; }

        [Required]
        public int WeekDayNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string WeekDayName { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

    }
}
