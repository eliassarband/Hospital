using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("InsuranceAgreement", Schema = "Med")]
    public class InsuranceAgreement : BaseEntity
    {

        [Required]
        [ForeignKey("InsuranceId")]
        public int InsuranceId { get; set; }
        public virtual Insurance Insurance { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [ForeignKey("AttachmentId")]
        public int? AttachmentId { get; set; }
        public virtual Attachment? Attachment { get; set; }

        public int ShowWarningBefore { get; set; }

    }
}
