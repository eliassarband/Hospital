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
    public class OPDBillPaymentViewModel
    {
        public int Id { get; set; }
        public int? OPDBillId { get; set; }
        public OPDBillViewModel OPDBill { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        [Range(1,int.MaxValue)]
        public int Amount { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
