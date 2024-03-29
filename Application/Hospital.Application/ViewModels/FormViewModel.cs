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
    public class FormViewModel
    {
        public int Id { get; set; }

		[Required]	
		public int FormCategoryId { get; set; }
		public string FormCategoryCode { get; set; }
		public string FormCategoryName { get; set; }
		public virtual FormCategoryViewModel FormCategory { get; set; }

		[Required]
		[MaxLength(50)]
		public string Code { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[Required]
		public bool ShowInMenu { get; set; } = true;

		[Required]
		public int Priority { get; set; }

		[Required]
		[MaxLength(200)]
		public string Url { get; set; }

		[MaxLength(1000)]
		public string? Description { get; set; }

		public virtual ICollection<FormActionViewModel> FormActionViewModels { get; set; }

		public DateTime CreatedDate { get; set; }
        public string? CreatedFormCategory { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedFormCategory { get; set; }
    }
}
