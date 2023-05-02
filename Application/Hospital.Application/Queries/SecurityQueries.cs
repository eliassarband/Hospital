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

	#region Group
	public record GetAllGroupsQuery : IRequest<List<GroupViewModel>>
	{

	}


	public record GetGroupByIdQuery : IRequest<GroupViewModel>
	{
		public int Id { get; private set; }

		public GetGroupByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	#endregion

	#region GroupUser
	public record GetAllGroupUsersQuery : IRequest<List<GroupUserViewModel>>
	{

	}

	public record GetGroupUserByIdQuery : IRequest<GroupUserViewModel>
	{
		public int Id { get; private set; }

		public GetGroupUserByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	public record GetGroupUserByUserIdQuery : IRequest<List<GroupUserViewModel>>
	{
		public int UserId { get; private set; }

		public GetGroupUserByUserIdQuery(int UserId)
		{
			this.UserId = UserId;
		}
	}

	public record GetGroupUserByGroupIdQuery : IRequest<List<GroupUserViewModel>>
	{
		public int GroupId { get; private set; }

		public GetGroupUserByGroupIdQuery(int GroupId)
		{
			this.GroupId = GroupId;
		}
	}

	public record GetGroupUserByGroupIdUserIdQuery : IRequest<GroupUserViewModel>
	{
		public int GroupId { get; private set; }
		public int UserId { get; }

		public GetGroupUserByGroupIdUserIdQuery(int GroupId, int UserId)
		{
			this.GroupId = GroupId;
			this.UserId = UserId;
		}
	}

	#endregion

	#region FormCategory
	public record GetAllFormCategorysQuery : IRequest<List<FormCategoryViewModel>>
	{

	}


	public record GetFormCategoryByIdQuery : IRequest<FormCategoryViewModel>
	{
		public int Id { get; private set; }

		public GetFormCategoryByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	public record GetFormCategoryByCodeQuery : IRequest<FormCategoryViewModel>
	{
		public string Code { get; private set; }

		public GetFormCategoryByCodeQuery(string Code)
		{
			this.Code = Code;
		}
	}


	#endregion

	#region Form
	public record GetAllFormsQuery : IRequest<List<FormViewModel>>
	{

	}

	public record GetFormByIdQuery : IRequest<FormViewModel>
	{
		public int Id { get; private set; }

		public GetFormByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	public record GetFormByCodeQuery : IRequest<FormViewModel>
	{
		public string Code { get; private set; }

		public GetFormByCodeQuery(string Code)
		{
			this.Code = Code;
		}
	}

	public record GetFormByFormCategoryIdQuery : IRequest<List<FormViewModel>>
	{
		public int FormCategoryId { get; private set; }

		public GetFormByFormCategoryIdQuery(int FormCategoryId)
		{
			this.FormCategoryId = FormCategoryId;
		}
	}


	#endregion

	#region FormAction
	public record GetAllFormActionsQuery : IRequest<List<FormActionViewModel>>
	{

	}

	public record GetFormActionByIdQuery : IRequest<FormActionViewModel>
	{
		public int Id { get; private set; }

		public GetFormActionByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	public record GetFormActionByFormIdCodeQuery : IRequest<FormActionViewModel>
	{
		public int FormId { get; }
		public string Code { get; }
		public GetFormActionByFormIdCodeQuery(int FormId, string Code)
		{
			this.FormId = FormId;
			this.Code = Code;
		}
				
	}

	public record GetFormActionByFormIdQuery : IRequest<List<FormActionViewModel>>
	{
		public int FormId { get; private set; }

		public GetFormActionByFormIdQuery(int FormId)
		{
			this.FormId = FormId;
		}
	}


	#endregion

	#region FormActionAccess
	public record GetAllFormActionAccesssQuery : IRequest<List<FormActionAccessViewModel>>
	{

	}

	public record GetFormActionAccessByIdQuery : IRequest<FormActionAccessViewModel>
	{
		public int Id { get; private set; }

		public GetFormActionAccessByIdQuery(int Id)
		{
			this.Id = Id;
		}
	}

	public record GetFormActionAccessByUserIdQuery : IRequest<List<FormActionAccessViewModel>>
	{
		public int UserId { get; private set; }

		public GetFormActionAccessByUserIdQuery(int UserId)
		{
			this.UserId = UserId;
		}
	}

	public record GetFormActionAccessByGroupIdQuery : IRequest<List<FormActionAccessViewModel>>
	{
		public int GroupId { get; private set; }

		public GetFormActionAccessByGroupIdQuery(int GroupId)
		{
			this.GroupId = GroupId;
		}
	}

	public record GetFormActionAccessByFormCodeFormActionCodeUserIdQuery : IRequest<FormActionAccessViewModel>
	{
		public string FormCode { get; }
		public string FormActionCode { get; }
		public int UserId { get; }
		public GetFormActionAccessByFormCodeFormActionCodeUserIdQuery(string FormCode, string FormActionCode, int UserId)
		{
			this.FormCode = FormCode;
			this.FormActionCode = FormActionCode;
			this.UserId = UserId;
		}
				
	}

	public record GetFormActionAccessByFormCodeFormActionCodeGroupIdQuery : IRequest<FormActionAccessViewModel>
	{
		public string FormCode { get; }
		public string FormActionCode { get; }
		public int GroupId { get; }
		public GetFormActionAccessByFormCodeFormActionCodeGroupIdQuery(string FormCode, string FormActionCode, int GroupId)
		{
			this.FormCode = FormCode;
			this.FormActionCode = FormActionCode;
			this.GroupId = GroupId;
		}

	}

	public record CheckUserActionAccessQuery : IRequest<bool>
	{
		public string FormCode { get; }
		public string FormActionCode { get; }
		public int UserId { get; }
		public CheckUserActionAccessQuery(string FormCode, string FormActionCode, int UserId)
		{
			this.FormCode = FormCode;
			this.FormActionCode = FormActionCode;
			this.UserId = UserId;
		}

	}

	#endregion
}
