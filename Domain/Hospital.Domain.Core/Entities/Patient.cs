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
    [Table("Patient", Schema = "Med")]
    public class Patient : BaseEntity
    {
        
        [ForeignKey("NamePrefixId")]
        public int? NamePrefixId { get; set; }
        public virtual BasicInformation NamePrefix { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("GenderId")]
        public int? GenderId { get; set; }
        public virtual BasicInformation Gender { get; set; }

        [MaxLength(100)]
        public string FatherName { get; set; }

        [Required]
        [MaxLength(15)]
        public string Mobile { get; set; }

        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public virtual BasicInformation? City { get; set; }

        [ForeignKey("AreaId")]
        public int? AreaId { get; set; }
        public virtual BasicInformation? Area { get; set; }

        [MaxLength(1000)]
        public string? Address { get; set; }

        [ForeignKey("RefferById")]
        public int? RefferById { get; set; }
        public virtual RefferBy? RefferBy { get; set; }

        [Required]
        [MaxLength(20)]
        public string NationalIdCart { get; set; }

        [MaxLength(200)]
        public string? Occupation { get; set; }

        [ForeignKey("InsuranceId")]
        public int? InsuranceId { get; set; }
        public virtual Insurance? Insurance { get; set; }

        [MaxLength(20)]
        public string? InsuranceNumber { get; set; }

        [MaxLength(20)]
        public string? ProposalNumber { get; set; }

        [ForeignKey("AttachmentId")]
        public int? AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual ICollection<OPDBill> OPDBills { get; set; }

        public virtual ICollection<IPDRegisteration> IPDRegisterations { get; set; }
    }
}
