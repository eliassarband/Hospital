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
    public class IPDRegisterationRoomViewModel
    {
        public int Id { get; set; }

       
        public int? IPDRegisterationId { get; set; }
        public virtual IPDRegisterationViewModel IPDRegisteration { get; set; }

        [Required]
        public DateTime Date { get; set; }=DateTime.Now;

        public DateTime? ToDate { get; set; }

        [Required]
        public int? BedId { get; set; }
        public string BedCode { get; set; }
        public string BedName { get; set; }
        public virtual BedViewModel Bed { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Days { get; set; } = 1;

        
        public int Rate { get; set; }

        
        public int Amount { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
