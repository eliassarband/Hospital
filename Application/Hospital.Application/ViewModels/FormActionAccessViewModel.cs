using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class FormActionAccessViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserFulleName { get; set; }
        public UserViewModel User { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public GroupViewModel Group { get; set; }
		public int FormActionId { get; set; }
		public string FormActionCode { get; set; }
        public string FormActionName { get; set; }
        public FormActionViewModel FormAction { get; set; }
		public int FormId { get; set; }
		public string FormCode { get; set; }
		public string FormName { get; set; }
		public FormViewModel Form { get; set; }
		public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
