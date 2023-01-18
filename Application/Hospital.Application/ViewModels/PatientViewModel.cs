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
    public class PatientViewModel
    {
        public int Id { get; set; }

        public int NamePrefixId { get; set; }
        public int? NamePrefixCode { get; set; }
        public string? NamePrefixStrCode { get; set; }
        public string? NamePrefixName { get; set; }
        public virtual BasicInformationViewModel NamePrefix { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int GenderId { get; set; }
        public int? GenderCode { get; set; }
        public string? GenderStrCode { get; set; }
        public string? GenderName { get; set; }
        public virtual BasicInformationViewModel Gender { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

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

        public string? Address { get; set; }

        public int RefferById { get; set; }
        public string? RefferByCode { get; set; }
        public string? RefferByNamePrefix { get; set; }
        public string? RefferByName { get; set; }
        public virtual RefferByViewModel? RefferBy { get; set; }

        
        public string NationalIdCart { get; set; }

        public string? Occupation { get; set; }

        public int InsuranceId { get; set; }
        public string? InsuranceCode { get; set; }
        public string? InsuranceName { get; set; }
        public virtual InsuranceViewModel Insurance { get; set; }

        public string? InsuranceNumber { get; set; }

        public string? ProposalNumber { get; set; }

        public int? AttachmentId { get; set; }
        public string? AttachmentFullName { get; set; }
        public string? AttachmentContentType { get; set; }
        public byte[]? AttachmentContent { get; set; }
        public string? AttachmentDescription { get; set; }
        public AttachmentViewModel? Attachment { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
