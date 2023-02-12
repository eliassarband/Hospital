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
    public class OPDBillViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? PatientId { get; set; }
        public string? PatienName { get; set; }
        public string BillNo { get; set; }
        public int TotalAmount { get; set; }
        public int PayableAmount { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OPDBillServiceViewModel> OPDBillServices { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedOPDBill { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedOPDBill { get; set; }
    }
}
