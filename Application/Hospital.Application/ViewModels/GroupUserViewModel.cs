using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class GroupUserViewModel
    {
		public int Id { get; set; }
		[Required]
		public int UserId { get; set; }
		public string Username { get; set; }
		public string UserFulleName { get; set; }
		public UserViewModel User { get; set; }
		[Required]
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public GroupViewModel Group { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedUser { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedUser { get; set; }
	}
}
