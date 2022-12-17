using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.ViewModels;

namespace Hospital.Application.Queries
{
    #region User
    public record GetAllUsersQuery : IRequest<List<UserViewModel>>
    {

    }

    public record GetUserByIdQuery : IRequest<UserViewModel>
    {
        public int Id { get; private set; }

        public GetUserByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetUserByUsernameQuery : IRequest<UserViewModel>
    {
        public string Username { get; private set; }

        public GetUserByUsernameQuery(string Username)
        {
            this.Username = Username;
        }
    }

    #endregion

    #region Role
    public record GetAllRolesQuery : IRequest<List<RoleViewModel>>
    {

    }


    public record GetRoleByIdQuery : IRequest<RoleViewModel>
    {
        public int Id { get; private set; }

        public GetRoleByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetRoleByCodeQuery : IRequest<RoleViewModel>
    {
        public string Code { get; private set; }

        public GetRoleByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }

    public record GetRoleByNameQuery : IRequest<RoleViewModel>
    {
        public string Name { get; private set; }

        public GetRoleByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region UserRole
    public record GetAllUserRolesQuery : IRequest<List<UserRoleViewModel>>
    {

    }

    public record GetUserRoleByIdQuery : IRequest<UserRoleViewModel>
    {
        public int Id { get; private set; }

        public GetUserRoleByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetUserRoleByUserIdQuery : IRequest<List<UserRoleViewModel>>
    {
        public int UserId { get; private set; }

        public GetUserRoleByUserIdQuery(int UserId)
        {
            this.UserId = UserId;
        }
    }

    public record GetUserRoleByRoleIdQuery : IRequest<List<UserRoleViewModel>>
    {
        public int RoleId { get; private set; }

        public GetUserRoleByRoleIdQuery(int RoleId)
        {
            this.RoleId = RoleId;
        }
    }

    #endregion
}
