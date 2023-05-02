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
    public class FormActionViewModel
    {
        public int Id { get; set; }

		[Required]
		public int FormId { get; set; }
		public string FormCode { get; set; }
		public string FormName { get; set; }
		public virtual FormViewModel Form { get; set; }

		[Required]
		[MaxLength(50)]
		public string Code { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[Required]
		public int Priority { get; set; }

		[MaxLength(1000)]
		public string? Description { get; set; }

		public DateTime CreatedDate { get; set; }
        public string? CreatedFormCategory { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedFormCategory { get; set; }
    }
}
