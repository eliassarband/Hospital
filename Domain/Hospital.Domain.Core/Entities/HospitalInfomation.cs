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
    [Table("HospitalInformation", Schema = "Gnr")]
    public class HospitalInformation : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string? Address { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(20)]
        public string? Mobile { get; set; }

        [Required]
        public byte[] Logo { get; set; }

        [Required]
        public byte[] WhiteLogo { get; set; }

        [MaxLength(20)]
        public string? RegisterationNumber { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? BackupDirectory1 { get; set; }

        [MaxLength(100)]
        public string? BackupDirectory2 { get; set;}

        [MaxLength(20)]
        public string? CurrencyName { get; set; }

        [MaxLength(10)]
        public string? CurrencySymbol { get; set; }

        [MaxLength(20)]
        public string? CurrencyCents { get; set;}

        [Range(0, 20)]
        public int SessionTimeout { get; set; }

    }
}
