using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class HospitalInformationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public byte[] Logo { get; set; }
        public byte[] WhiteLogo { get; set; }
        public string? RegisterationNumber { get; set; }
        public string? Email { get; set; }
        public string? BackupDirectory1 { get; set; }
        public string? BackupDirectory2 { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencySymbol { get; set; }
        public string? CurrencyCents { get; set; }
        public int SessionTimeout { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
