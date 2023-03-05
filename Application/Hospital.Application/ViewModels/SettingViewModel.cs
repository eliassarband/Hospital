using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class SettingViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedSetting { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedSetting { get; set; }
    }
}
