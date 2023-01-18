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
    public class StaffViewModel
    {
        public int Id { get; set; }

        public int StaffTypeId { get; set; }
        public int? StaffTypeCode  {get; set; }
        public string? StaffTypeStrCode { get; set; }
        public string? StaffTypeName { get; set; }
        public virtual BasicInformationViewModel StaffType { get; set; }

        public string Code { get; set; }

        public int NamePrefixId { get; set; }
        public int? NamePrefixCode { get; set; }
        public string? NamePrefixStrCode { get; set; }
        public string? NamePrefixName { get; set; }
        public virtual BasicInformationViewModel NamePrefix { get; set; }

        public string Name { get; set; }
        
        public DateTime? DateOfJoining { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int SpecialityId { get; set; }
        public int? SpecialityCode { get; set; }
        public string? SpecialityStrCode { get; set; }
        public string? SpecialityName { get; set; }
        public virtual BasicInformationViewModel? Speciality { get; set; }

        public int QualificationId { get; set; }
        public int? QualificationCode { get; set; }
        public string? QualificationStrCode { get; set; }
        public string? QualificationName { get; set; }
        public virtual BasicInformationViewModel? Qualification { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public int CityId { get; set; }
        public int? CityCode { get; set; }
        public string? CityStrCode { get; set; }
        public string? CityName { get; set; }
        public virtual BasicInformationViewModel? City { get; set; }

        public int AreaId { get; set; }
        public int? AreaCode { get; set; }
        public string? AreaStrCode { get; set; }
        public string? AreaName { get; set; }
        public virtual BasicInformationViewModel? Area { get; set; }

        public string Address { get; set; }

        public int OPDChargePercent { get; set; }

        public int IPDChargePercent { get; set; }

        public int NightOPDChargePercent { get; set; }

        public int NightIPDChargePercent { get; set; }

        public virtual ICollection<StaffTimingViewModel> StaffTimings { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
