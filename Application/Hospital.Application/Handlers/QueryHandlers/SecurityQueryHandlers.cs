using Hospital.Application.Mapper;
using Hospital.Application.Queries;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Handlers.QueryHandlers
{
    #region User

    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
    {
        private readonly IUserQueryRepository _UserQueryRepository;

        public GetAllUsersHandler(IUserQueryRepository UserQueryRepository)
        {
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            List<User> Users = (List<User>)await _UserQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<UserViewModel>>(Users);
        }
    }

    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUserQueryRepository _UserQueryRepository;

        public GetUserByIdHandler(IUserQueryRepository UserQueryRepository)
        {
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<UserViewModel>(await _UserQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetUserByUsernameHandler : IRequestHandler<GetUserByUsernameQuery, UserViewModel>
    {
        private readonly IUserQueryRepository _UserQueryRepository;

        public GetUserByUsernameHandler(IUserQueryRepository UserQueryRepository)
        {
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<UserViewModel> Handle(GetUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<UserViewModel>(await _UserQueryRepository.GetByUsernameAsync(request.Username));
        }
    }

    #endregion

    #region Role

    public class GetAllRolesHandler : IRequestHandler<GetAllRolesQuery, List<RoleViewModel>>
    {
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public GetAllRolesHandler(IRoleQueryRepository RoleQueryRepository)
        {
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<List<RoleViewModel>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            List<Role> Roles = (List<Role>)await _RoleQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RoleViewModel>>(Roles);
        }
    }

    public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdQuery, RoleViewModel>
    {
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public GetRoleByIdHandler(IRoleQueryRepository RoleQueryRepository)
        {
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<RoleViewModel> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoleViewModel>(await _RoleQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetRoleByCodeHandler : IRequestHandler<GetRoleByCodeQuery, RoleViewModel>
    {
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public GetRoleByCodeHandler(IRoleQueryRepository RoleQueryRepository)
        {
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<RoleViewModel> Handle(GetRoleByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoleViewModel>(await _RoleQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetRoleByNameHandler : IRequestHandler<GetRoleByNameQuery, RoleViewModel>
    {
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public GetRoleByNameHandler(IRoleQueryRepository RoleQueryRepository)
        {
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<RoleViewModel> Handle(GetRoleByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoleViewModel>(await _RoleQueryRepository.GetByNameAsync(request.Name));
        }
    }
    #endregion

    #region UserRole

    public class GetAllUserRolesHandler : IRequestHandler<GetAllUserRolesQuery, List<UserRoleViewModel>>
    {
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public GetAllUserRolesHandler(IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<List<UserRoleViewModel>> Handle(GetAllUserRolesQuery request, CancellationToken cancellationToken)
        {
            List<UserRole> UserRoles = (List<UserRole>)await _UserRoleQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<UserRoleViewModel>>(UserRoles);
        }
    }

    public class GetUserRoleByIdHandler : IRequestHandler<GetUserRoleByIdQuery, UserRoleViewModel>
    {
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public GetUserRoleByIdHandler(IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<UserRoleViewModel> Handle(GetUserRoleByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<UserRoleViewModel>(await _UserRoleQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetUserRoleByUserIdHandler : IRequestHandler<GetUserRoleByUserIdQuery, List<UserRoleViewModel>>
    {
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public GetUserRoleByUserIdHandler(IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<List<UserRoleViewModel>> Handle(GetUserRoleByUserIdQuery request, CancellationToken cancellationToken)
        {
            List<UserRole> UserRoles = (List<UserRole>)await _UserRoleQueryRepository.GetByUserIdAsync(request.UserId);

            return MapperConfig.Mapper.Map<List<UserRoleViewModel>>(UserRoles);
        }
    }

    public class GetUserRoleByRoleIdHandler : IRequestHandler<GetUserRoleByRoleIdQuery, List<UserRoleViewModel>>
    {
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public GetUserRoleByRoleIdHandler(IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<List<UserRoleViewModel>> Handle(GetUserRoleByRoleIdQuery request, CancellationToken cancellationToken)
        {
            List<UserRole> UserRoles = (List<UserRole>)await _UserRoleQueryRepository.GetByRoleIdAsync(request.RoleId);

            return MapperConfig.Mapper.Map<List<UserRoleViewModel>>(UserRoles);
        }
    }

	#endregion

	#region Group

	public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsQuery, List<GroupViewModel>>
	{
		private readonly IGroupQueryRepository _GroupQueryRepository;

		public GetAllGroupsHandler(IGroupQueryRepository GroupQueryRepository)
		{
			_GroupQueryRepository = GroupQueryRepository;
		}

		public async Task<List<GroupViewModel>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
		{
			List<Group> Groups = (List<Group>)await _GroupQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<GroupViewModel>>(Groups);
		}
	}

	public class GetGroupByIdHandler : IRequestHandler<GetGroupByIdQuery, GroupViewModel>
	{
		private readonly IGroupQueryRepository _GroupQueryRepository;

		public GetGroupByIdHandler(IGroupQueryRepository GroupQueryRepository)
		{
			_GroupQueryRepository = GroupQueryRepository;
		}

		public async Task<GroupViewModel> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<GroupViewModel>(await _GroupQueryRepository.GetByIdAsync(request.Id));
		}
	}

	#endregion

	#region GroupUser

	public class GetAllGroupUsersHandler : IRequestHandler<GetAllGroupUsersQuery, List<GroupUserViewModel>>
	{
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public GetAllGroupUsersHandler(IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<List<GroupUserViewModel>> Handle(GetAllGroupUsersQuery request, CancellationToken cancellationToken)
		{
			List<GroupUser> GroupUsers = (List<GroupUser>)await _GroupUserQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<GroupUserViewModel>>(GroupUsers);
		}
	}

	public class GetGroupUserByIdHandler : IRequestHandler<GetGroupUserByIdQuery, GroupUserViewModel>
	{
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public GetGroupUserByIdHandler(IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<GroupUserViewModel> Handle(GetGroupUserByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<GroupUserViewModel>(await _GroupUserQueryRepository.GetByIdAsync(request.Id));
		}
	}

	public class GetGroupUserByUserIdHandler : IRequestHandler<GetGroupUserByUserIdQuery, List<GroupUserViewModel>>
	{
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public GetGroupUserByUserIdHandler(IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<List<GroupUserViewModel>> Handle(GetGroupUserByUserIdQuery request, CancellationToken cancellationToken)
		{
			List<GroupUser> GroupUsers = (List<GroupUser>)await _GroupUserQueryRepository.GetByUserIdAsync(request.UserId);

			return MapperConfig.Mapper.Map<List<GroupUserViewModel>>(GroupUsers);
		}
	}

	public class GetGroupUserByGroupIdHandler : IRequestHandler<GetGroupUserByGroupIdQuery, List<GroupUserViewModel>>
	{
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public GetGroupUserByGroupIdHandler(IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<List<GroupUserViewModel>> Handle(GetGroupUserByGroupIdQuery request, CancellationToken cancellationToken)
		{
			List<GroupUser> GroupUsers = (List<GroupUser>)await _GroupUserQueryRepository.GetByGroupIdAsync(request.GroupId);

			return MapperConfig.Mapper.Map<List<GroupUserViewModel>>(GroupUsers);
		}
	}

	public class GetGroupUserByGroupIdUserIdHandler : IRequestHandler<GetGroupUserByGroupIdUserIdQuery, GroupUserViewModel>
	{
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public GetGroupUserByGroupIdUserIdHandler(IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<GroupUserViewModel> Handle(GetGroupUserByGroupIdUserIdQuery request, CancellationToken cancellationToken)
		{
			GroupUser GroupUser = (GroupUser)await _GroupUserQueryRepository.GetByGroupIdUserIdAsync(request.GroupId,request.UserId);

			return MapperConfig.Mapper.Map<GroupUserViewModel>(GroupUser);
		}
	}

	#endregion

	#region FormCategory

	public class GetAllFormCategorysHandler : IRequestHandler<GetAllFormCategorysQuery, List<FormCategoryViewModel>>
	{
		private readonly IFormCategoryQueryRepository _FormCategoryQueryRepository;

		public GetAllFormCategorysHandler(IFormCategoryQueryRepository FormCategoryQueryRepository)
		{
			_FormCategoryQueryRepository = FormCategoryQueryRepository;
		}

		public async Task<List<FormCategoryViewModel>> Handle(GetAllFormCategorysQuery request, CancellationToken cancellationToken)
		{
			List<FormCategory> FormCategorys = (List<FormCategory>)await _FormCategoryQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<FormCategoryViewModel>>(FormCategorys);
		}
	}

	public class GetFormCategoryByIdHandler : IRequestHandler<GetFormCategoryByIdQuery, FormCategoryViewModel>
	{
		private readonly IFormCategoryQueryRepository _FormCategoryQueryRepository;

		public GetFormCategoryByIdHandler(IFormCategoryQueryRepository FormCategoryQueryRepository)
		{
			_FormCategoryQueryRepository = FormCategoryQueryRepository;
		}

		public async Task<FormCategoryViewModel> Handle(GetFormCategoryByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormCategoryViewModel>(await _FormCategoryQueryRepository.GetByIdAsync(request.Id));
		}
	}

	public class GetFormCategoryByCodeHandler : IRequestHandler<GetFormCategoryByCodeQuery, FormCategoryViewModel>
	{
		private readonly IFormCategoryQueryRepository _FormCategoryQueryRepository;

		public GetFormCategoryByCodeHandler(IFormCategoryQueryRepository FormCategoryQueryRepository)
		{
			_FormCategoryQueryRepository = FormCategoryQueryRepository;
		}

		public async Task<FormCategoryViewModel> Handle(GetFormCategoryByCodeQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormCategoryViewModel>(await _FormCategoryQueryRepository.GetByCodeAsync(request.Code));
		}
	}


	#endregion

	#region Form

	public class GetAllFormsHandler : IRequestHandler<GetAllFormsQuery, List<FormViewModel>>
	{
		private readonly IFormQueryRepository _FormQueryRepository;

		public GetAllFormsHandler(IFormQueryRepository FormQueryRepository)
		{
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<List<FormViewModel>> Handle(GetAllFormsQuery request, CancellationToken cancellationToken)
		{
			List<Form> Forms = (List<Form>)await _FormQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<FormViewModel>>(Forms);
		}
	}

	public class GetFormByIdHandler : IRequestHandler<GetFormByIdQuery, FormViewModel>
	{
		private readonly IFormQueryRepository _FormQueryRepository;

		public GetFormByIdHandler(IFormQueryRepository FormQueryRepository)
		{
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<FormViewModel> Handle(GetFormByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormViewModel>(await _FormQueryRepository.GetByIdAsync(request.Id));
		}
	}

	public class GetFormByCodeHandler : IRequestHandler<GetFormByCodeQuery, FormViewModel>
	{
		private readonly IFormQueryRepository _FormQueryRepository;

		public GetFormByCodeHandler(IFormQueryRepository FormQueryRepository)
		{
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<FormViewModel> Handle(GetFormByCodeQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormViewModel>(await _FormQueryRepository.GetByCodeAsync(request.Code));
		}
	}

	public class GetFormByFormCategoryIdHandler : IRequestHandler<GetFormByFormCategoryIdQuery, List<FormViewModel>>
	{
		private readonly IFormQueryRepository _FormQueryRepository;

		public GetFormByFormCategoryIdHandler(IFormQueryRepository FormQueryRepository)
		{
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<List<FormViewModel>> Handle(GetFormByFormCategoryIdQuery request, CancellationToken cancellationToken)
		{
			List<Form> Forms = (List<Form>)await _FormQueryRepository.GetByFormCategoryIdAsync(request.FormCategoryId);

			return MapperConfig.Mapper.Map<List<FormViewModel>>(Forms);
		}
	}

	#endregion

	#region FormAction

	public class GetAllFormActionsHandler : IRequestHandler<GetAllFormActionsQuery, List<FormActionViewModel>>
	{
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public GetAllFormActionsHandler(IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<List<FormActionViewModel>> Handle(GetAllFormActionsQuery request, CancellationToken cancellationToken)
		{
			List<FormAction> FormActions = (List<FormAction>)await _FormActionQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<FormActionViewModel>>(FormActions);
		}
	}

	public class GetFormActionByIdHandler : IRequestHandler<GetFormActionByIdQuery, FormActionViewModel>
	{
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public GetFormActionByIdHandler(IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<FormActionViewModel> Handle(GetFormActionByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormActionViewModel>(await _FormActionQueryRepository.GetByIdAsync(request.Id));
		}
	}

	public class GetFormActionByFormIdCodeHandler : IRequestHandler<GetFormActionByFormIdCodeQuery, FormActionViewModel>
	{
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public GetFormActionByFormIdCodeHandler(IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<FormActionViewModel> Handle(GetFormActionByFormIdCodeQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormActionViewModel>(await _FormActionQueryRepository.GetByFormIdCodeAsync(request.FormId,request.Code));
		}
	}

	public class GetFormActionByFormIdHandler : IRequestHandler<GetFormActionByFormIdQuery, List<FormActionViewModel>>
	{
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public GetFormActionByFormIdHandler(IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<List<FormActionViewModel>> Handle(GetFormActionByFormIdQuery request, CancellationToken cancellationToken)
		{
			List<FormAction> FormActions = (List<FormAction>)await _FormActionQueryRepository.GetByFormIdAsync(request.FormId);

			return MapperConfig.Mapper.Map<List<FormActionViewModel>>(FormActions);
		}
	}

	#endregion

	#region FormActionAccess

	public class GetAllFormActionAccesssHandler : IRequestHandler<GetAllFormActionAccesssQuery, List<FormActionAccessViewModel>>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetAllFormActionAccesssHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<List<FormActionAccessViewModel>> Handle(GetAllFormActionAccesssQuery request, CancellationToken cancellationToken)
		{
			List<FormActionAccess> FormActionAccesss = (List<FormActionAccess>)await _FormActionAccessQueryRepository.GetAllAsync();

			return MapperConfig.Mapper.Map<List<FormActionAccessViewModel>>(FormActionAccesss);
		}
	}

	public class GetFormActionAccessByIdHandler : IRequestHandler<GetFormActionAccessByIdQuery, FormActionAccessViewModel>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetFormActionAccessByIdHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<FormActionAccessViewModel> Handle(GetFormActionAccessByIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormActionAccessViewModel>(await _FormActionAccessQueryRepository.GetByIdAsync(request.Id));
		}
	}

	public class GetFormActionAccessByUserIdHandler : IRequestHandler<GetFormActionAccessByUserIdQuery, List<FormActionAccessViewModel>>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetFormActionAccessByUserIdHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<List<FormActionAccessViewModel>> Handle(GetFormActionAccessByUserIdQuery request, CancellationToken cancellationToken)
		{
			List<FormActionAccess> FormActionAccesss = (List<FormActionAccess>)await _FormActionAccessQueryRepository.GetByUserIdAsync(request.UserId);

			return MapperConfig.Mapper.Map<List<FormActionAccessViewModel>>(FormActionAccesss);
		}
	}

	public class GetFormActionAccessByGroupIdHandler : IRequestHandler<GetFormActionAccessByGroupIdQuery, List<FormActionAccessViewModel>>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetFormActionAccessByGroupIdHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<List<FormActionAccessViewModel>> Handle(GetFormActionAccessByGroupIdQuery request, CancellationToken cancellationToken)
		{
			List<FormActionAccess> FormActionAccesss = (List<FormActionAccess>)await _FormActionAccessQueryRepository.GetByGroupIdAsync(request.GroupId);

			return MapperConfig.Mapper.Map<List<FormActionAccessViewModel>>(FormActionAccesss);
		}
	}

	public class GetFormActionAccessByFormCodeFormActionCodeUserIdHandler : IRequestHandler<GetFormActionAccessByFormCodeFormActionCodeUserIdQuery, FormActionAccessViewModel>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetFormActionAccessByFormCodeFormActionCodeUserIdHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<FormActionAccessViewModel> Handle(GetFormActionAccessByFormCodeFormActionCodeUserIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormActionAccessViewModel>(await _FormActionAccessQueryRepository.GetByFormCodeFormActionCodeUserIdAsync(request.FormCode, request.FormActionCode, request.UserId));
		}
	}

	public class GetFormActionAccessByFormCodeFormActionCodeGroupIdHandler : IRequestHandler<GetFormActionAccessByFormCodeFormActionCodeGroupIdQuery, FormActionAccessViewModel>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public GetFormActionAccessByFormCodeFormActionCodeGroupIdHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<FormActionAccessViewModel> Handle(GetFormActionAccessByFormCodeFormActionCodeGroupIdQuery request, CancellationToken cancellationToken)
		{
			return MapperConfig.Mapper.Map<FormActionAccessViewModel>(await _FormActionAccessQueryRepository.GetByFormCodeFormActionCodeGroupIdAsync(request.FormCode, request.FormActionCode, request.GroupId));
		}
	}

	public class CheckUserActionAccessHandler : IRequestHandler<CheckUserActionAccessQuery, bool>
	{
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public CheckUserActionAccessHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository,IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		

		public async Task<bool> Handle(CheckUserActionAccessQuery request, CancellationToken cancellationToken)
		{
			var userFormAction= await _FormActionAccessQueryRepository.GetByFormCodeFormActionCodeUserIdAsync(request.FormCode,request.FormActionCode, request.UserId);
			if (userFormAction != null)
			{
				return true;

			}

			var groupUsers = await _GroupUserQueryRepository.GetByUserIdAsync(request.UserId);
			if (groupUsers != null)
			{
				foreach(var groupUser in groupUsers)
				{
					var groupFormAction = await _FormActionAccessQueryRepository.GetByFormCodeFormActionCodeGroupIdAsync(request.FormCode, request.FormActionCode, groupUser.GroupId);
					if(groupFormAction!=null)
					{
						return true;
					}

				}
			}

			return false;
		}
	}

    public class CheckGroupActionAccessHandler : IRequestHandler<CheckGroupActionAccessQuery, bool>
    {
        private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

        public CheckGroupActionAccessHandler(IFormActionAccessQueryRepository FormActionAccessQueryRepository)
        {
            _FormActionAccessQueryRepository = FormActionAccessQueryRepository;
        }



        public async Task<bool> Handle(CheckGroupActionAccessQuery request, CancellationToken cancellationToken)
        {
            var groupFormAction = await _FormActionAccessQueryRepository.GetByFormCodeFormActionCodeGroupIdAsync(request.FormCode, request.FormActionCode, request.GroupId);
            if (groupFormAction != null)
            {
                return true;

            }

            return false;
        }
    }

    #endregion
}
