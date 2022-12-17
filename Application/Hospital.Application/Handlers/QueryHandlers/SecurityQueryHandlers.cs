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
}
