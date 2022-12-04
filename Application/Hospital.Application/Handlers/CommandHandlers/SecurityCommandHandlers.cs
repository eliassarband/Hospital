using Hospital.Application.Commands;
using Hospital.Application.Mapper;
using Hospital.Application.Responses;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Commands;
using Hospital.Domain.Core.Repositories.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Handlers.CommandHandlers
{
    #region User
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, CommandResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        private readonly IUserQueryRepository _UserQueryRepository;

        public CreateUserHandler(IUserCommandRepository UserCommandRepository, IUserQueryRepository UserQueryRepository)
        {
            _UserCommandRepository = UserCommandRepository;
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<CommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var UserEntity = MapperConfig.Mapper.Map<User>(request);
            UserEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (UserEntity is null)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "There is a problem in mapper"
                };
            }
            else
            {
                try
                {
                    var existUser = await _UserQueryRepository.GetByUsernameAsync(UserEntity.Username);

                    if (existUser != null)
                    {
                        response = new CommandResponse()
                        {
                            Id = 0,
                            ResultType = ResultType.Success,
                            ResultMessage = "The entered username is duplicate"
                        };
                    }
                    else
                    {
                        var newUser = await _UserCommandRepository.AddAsync(UserEntity);

                        response = new CommandResponse()
                        {
                            Id = newUser.Id,
                            ResultType = ResultType.Success,
                            ResultMessage = "Saved successfully"
                        };
                    }

                }
                catch (Exception exp)
                {
                    return new CommandResponse()
                    {
                        Id = -1,
                        ResultType = ResultType.Error,
                        ResultMessage = "Error in operation\n" + exp.Message
                    };
                }

            }

            return response;
        }
    }

    public class EditUserHandler : IRequestHandler<EditUserCommand, CommandResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        private readonly IUserQueryRepository _UserQueryRepository;

        public EditUserHandler(IUserCommandRepository UserCommandRepository, IUserQueryRepository UserQueryRepository)
        {
            _UserCommandRepository = UserCommandRepository;
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var UserEntity = MapperConfig.Mapper.Map<User>(request);
            UserEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (UserEntity is null)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "There is a problem in mapper"
                };
            }

            try
            {
                var existUser = await _UserQueryRepository.GetByUsernameAsync(UserEntity.Username);

                if (existUser != null && existUser.Id != UserEntity.Id)
                {
                    response = new CommandResponse()
                    {
                        Id = 0,
                        ResultType = ResultType.Success,
                        ResultMessage = "The entered username is duplicate"
                    };
                }
                else
                {
                    await _UserCommandRepository.UpdateAsync(UserEntity);
                }

            }
            catch (Exception exp)
            {
                return new CommandResponse()
                {
                    Id = -1,
                    ResultType = ResultType.Error,
                    ResultMessage = "Error in operation\n" + exp.Message
                };
            }

            var modifiedUser = await _UserQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedUser.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, CommandResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        private readonly IUserQueryRepository _UserQueryRepository;

        public DeleteUserHandler(IUserCommandRepository UserCommandRepository, IUserQueryRepository UserQueryRepository)
        {
            _UserCommandRepository = UserCommandRepository;
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var UserEntity = await _UserQueryRepository.GetByIdAsync(request.Id);


                await _UserCommandRepository.DeleteAsync(UserEntity);

                response = new CommandResponse()
                {
                    Id = request.Id,
                    ResultType = ResultType.Success,
                    ResultMessage = "Removed successfully"
                };

            }
            catch (Exception exp)
            {
                return new CommandResponse()
                {
                    Id = -1,
                    ResultType = ResultType.Error,
                    ResultMessage = "Error in operation\n" + exp.Message
                };
            }

            return response;
        }
    }

    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, CommandResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;

        public ChangePasswordHandler(IUserCommandRepository UserCommandRepository)
        {
            _UserCommandRepository = UserCommandRepository;
        }

        public async Task<CommandResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {

                await _UserCommandRepository.ChangePasswordAsync(request.Id, request.NewEncryptPassword);

                response = new CommandResponse()
                {
                    Id = request.Id,
                    ResultType = ResultType.Success,
                    ResultMessage = "Updated successfully"
                };

            }
            catch (Exception exp)
            {
                return new CommandResponse()
                {
                    Id = -1,
                    ResultType = ResultType.Error,
                    ResultMessage = "Error in operation\n" + exp.Message
                };
            }

            return response;
        }
    }

    #endregion

    #region Role
    public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, CommandResponse>
    {
        private readonly IRoleCommandRepository _RoleCommandRepository;

        public CreateRoleHandler(IRoleCommandRepository RoleCommandRepository)
        {
            _RoleCommandRepository = RoleCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var RoleEntity = MapperConfig.Mapper.Map<Role>(request);
            RoleEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoleEntity is null)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "There is a problem in mapper"
                };
            }
            else
            {
                try
                {
                    var newRole = await _RoleCommandRepository.AddAsync(RoleEntity);

                    response = new CommandResponse()
                    {
                        Id = newRole.Id,
                        ResultType = ResultType.Success,
                        ResultMessage = "Saved successfully"
                    };

                }
                catch (Exception exp)
                {
                    return new CommandResponse()
                    {
                        Id = -1,
                        ResultType = ResultType.Error,
                        ResultMessage = "Error in operation\n" + exp.Message
                    };
                }

            }

            return response;
        }
    }

    public class EditRoleHandler : IRequestHandler<EditRoleCommand, CommandResponse>
    {
        private readonly IRoleCommandRepository _RoleCommandRepository;
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public EditRoleHandler(IRoleCommandRepository RoleCommandRepository, IRoleQueryRepository RoleQueryRepository)
        {
            _RoleCommandRepository = RoleCommandRepository;
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditRoleCommand request, CancellationToken cancellationToken)
        {
            var RoleEntity = MapperConfig.Mapper.Map<Role>(request);
            RoleEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoleEntity is null)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "There is a problem in mapper"
                };
            }

            try
            {
                await _RoleCommandRepository.UpdateAsync(RoleEntity);

            }
            catch (Exception exp)
            {
                return new CommandResponse()
                {
                    Id = -1,
                    ResultType = ResultType.Error,
                    ResultMessage = "Error in operation\n" + exp.Message
                };
            }

            var modifiedRole = await _RoleQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedRole.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, CommandResponse>
    {
        private readonly IRoleCommandRepository _RoleCommandRepository;
        private readonly IRoleQueryRepository _RoleQueryRepository;

        public DeleteRoleHandler(IRoleCommandRepository RoleCommandRepository, IRoleQueryRepository RoleQueryRepository)
        {
            _RoleCommandRepository = RoleCommandRepository;
            _RoleQueryRepository = RoleQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var RoleEntity = await _RoleQueryRepository.GetByIdAsync(request.Id);


                await _RoleCommandRepository.DeleteAsync(RoleEntity);

                response = new CommandResponse()
                {
                    Id = request.Id,
                    ResultType = ResultType.Success,
                    ResultMessage = "Removed successfully"
                };

            }
            catch (Exception exp)
            {
                return new CommandResponse()
                {
                    Id = -1,
                    ResultType = ResultType.Error,
                    ResultMessage = "Error in operation\n" + exp.Message
                };
            }

            return response;
        }
    }

    #endregion
}
