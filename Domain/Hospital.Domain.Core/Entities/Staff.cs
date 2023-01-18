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
    [Table("Staff", Schema = "Med")]
    public class Staff : BaseEntity
    {
        
        [ForeignKey("StaffTypeId")]
        public int? StaffTypeId { get; set; }
        public virtual BasicInformation StaffType { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

       
        [ForeignKey("NamePrefixId")]
        public int? NamePrefixId { get; set; }
        public virtual BasicInformation NamePrefix { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("SpecialityId")]
        public int? SpecialityId { get; set; }
        public virtual BasicInformation? Speciality { get; set; }

        [ForeignKey("QualificationId")]
        public int? QualificationId { get; set; }
        public virtual BasicInformation? Qualification { get; set; }

        [Required]
        [MaxLength(15)]
        public string Mobile { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public virtual BasicInformation? City { get; set; }

        [ForeignKey("AreaId")]
        public int? AreaId { get; set; }
        public virtual BasicInformation? Area { get; set; }

        [MaxLength(1000)]
        public string? Address { get; set; }

        public int? OPDChargePercent { get; set; }

        public int? IPDChargePercent { get; set; }

        public int? NightOPDChargePercent { get; set; }

        public int? NightIPDChargePercent { get; set; }

        public virtual ICollection<StaffTiming> StaffTimings { get; set; }

    }
}
