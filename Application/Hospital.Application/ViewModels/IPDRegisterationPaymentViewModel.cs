﻿using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class IPDRegisterationPaymentViewModel
    {
        public int Id { get; set; }

        [Required]
        public int? IPDRegisterationId { get; set; }
        public virtual IPDRegisterationViewModel IPDRegisteration { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int? PaymentTypeId { get; set; }
        public int PaymentTypeCode { get; set; }
        public string PaymentTypeStrCode { get; set; }
        public string PaymentTypeName { get; set; }
        public virtual BasicInformationViewModel PaymentType { get; set; }

        [Required]
        public int Amount { get; set; }

        public string ChequeNumber { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
