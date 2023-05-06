using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.Responses;
using Hospital.Application.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Application.Commands
{
    #region User
    public class CreateUserCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public string Theme { get; set; }
        public int? AttachmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateUserCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditUserCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public string Theme { get; set; }
        public int? AttachmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditUserCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteUserCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteUserCommand(int Id)
        {
            this.Id = Id;
        }
    }

    public class ChangePasswordCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string NewEncryptPassword { get; set; }

        public ChangePasswordCommand(int Id, string newEncryptPassword)
        {
            this.Id = Id;
            NewEncryptPassword = newEncryptPassword;
        }
    }

    #endregion

    #region Role
    public class CreateRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRole { get; set; }

        public CreateRoleCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRole { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedRole { get; set; }

        public EditRoleCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteRoleCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region UserRole
    public class CreateUserRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUserRole { get; set; }

        public CreateUserRoleCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditUserRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUserRole { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUserRole { get; set; }

        public EditUserRoleCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteUserRoleCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteUserRoleCommand(int Id)
        {
            this.Id = Id;
        }
    }


	#endregion

	#region Group
	public class CreateGroupCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedGroup { get; set; }

		public CreateGroupCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditGroupCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedGroup { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedGroup { get; set; }

		public EditGroupCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteGroupCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteGroupCommand(int Id)
		{
			this.Id = Id;
		}
	}

	#endregion

	#region GroupUser
	public class CreateGroupUserCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GroupId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedGroupUser { get; set; }

		public CreateGroupUserCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditGroupUserCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GroupId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedGroupUser { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedGroupUser { get; set; }

		public EditGroupUserCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteGroupUserCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteGroupUserCommand(int Id)
		{
			this.Id = Id;
		}
	}


	#endregion

	#region FormCategory
	public class CreateFormCategoryCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public bool ShowInDashboard { get; set; } = true;
		public int Priority { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormCategory { get; set; }

		public CreateFormCategoryCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditFormCategoryCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public bool ShowInDashboard { get; set; } = true;
		public int Priority { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormCategory { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedFormCategory { get; set; }

		public EditFormCategoryCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteFormCategoryCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteFormCategoryCommand(int Id)
		{
			this.Id = Id;
		}
	}

	#endregion

	#region Form
	public class CreateFormCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int FormCategoryId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public bool ShowInMenu { get; set; } = true;
		public int Priority { get; set; }
		public string Url { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedForm { get; set; }

		public CreateFormCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditFormCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int FormCategoryId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public bool ShowInMenu { get; set; } = true;
		public int Priority { get; set; }
		public string Url { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedForm { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedForm { get; set; }

		public EditFormCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteFormCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteFormCommand(int Id)
		{
			this.Id = Id;
		}
	}


	#endregion

	#region FormAction
	public class CreateFormActionCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int FormId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public int Priority { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormAction { get; set; }

		public CreateFormActionCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditFormActionCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int FormId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public int Priority { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormAction { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedFormAction { get; set; }

		public EditFormActionCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteFormActionCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteFormActionCommand(int Id)
		{
			this.Id = Id;
		}
	}


	#endregion

	#region FormActionAccess
	public class CreateFormActionAccessCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int? UserId { get; set; }
		public int? GroupId { get; set; }
		public int FormActionId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormActionAccess { get; set; }

		public CreateFormActionAccessCommand()
		{
			this.CreatedDate = DateTime.Now;
		}
	}

	public class EditFormActionAccessCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GroupId { get; set; }
		public int FormActionId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? CreatedFormActionAccess { get; set; }
		public DateTime ModifiedDate { get; set; }
		public string? ModifiedFormActionAccess { get; set; }

		public EditFormActionAccessCommand()
		{
			this.ModifiedDate = DateTime.Now;
		}
	}

	public class DeleteFormActionAccessCommand : IRequest<CommandResponse>
	{
		public int Id { get; set; }

		public DeleteFormActionAccessCommand(int Id)
		{
			this.Id = Id;
		}
	}


	#endregion
}
