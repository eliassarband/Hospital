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
    public class InsuranceViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OPDDiscountPercent { get; set; }
        public int IPDDiscountPercent { get; set; }
        public int AdvancePaymentPercent { get; set; }
        public int AdvancePaymentAmount { get; set; }
        public int InsurancePaymentTypeId { get; set; }
        public int InsurancePaymentTypeCode { get; set; }
        public string InsurancePaymentTypeStrCode { get; set; }
        public string InsurancePaymentTypeName { get; set; }
        public virtual BasicInformationViewModel InsurancePaymentType { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
