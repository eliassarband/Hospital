using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class InsuranceAgreementViewModel
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public string InsuranceCode { get; set; }
        public string InsuranceName { get; set; }
        public virtual InsuranceViewModel Insurance { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ToDate { get; set; }
        public int? AttachmentId { get; set; }
        public string? AttachmentFullName { get; set; }
        public string? AttachmentContentType { get; set; }
        public byte[]? AttachmentContent { get; set; }
        public string? AttachmentDescription { get; set; }
        public virtual AttachmentViewModel? Attachment { get; set; }
        public int ShowWarningBefore { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
