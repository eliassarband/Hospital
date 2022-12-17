using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.Responses;
using Hospital.Application.ViewModels;

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
}
