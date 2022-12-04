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
}
