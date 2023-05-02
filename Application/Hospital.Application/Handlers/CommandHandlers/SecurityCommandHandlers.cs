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

    #region UserRole
    public class CreateUserRoleHandler : IRequestHandler<CreateUserRoleCommand, CommandResponse>
    {
        private readonly IUserRoleCommandRepository _UserRoleCommandRepository;

        public CreateUserRoleHandler(IUserRoleCommandRepository UserRoleCommandRepository)
        {
            _UserRoleCommandRepository = UserRoleCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var UserRoleEntity = MapperConfig.Mapper.Map<UserRole>(request);
            UserRoleEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (UserRoleEntity is null)
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
                    var newUserRole = await _UserRoleCommandRepository.AddAsync(UserRoleEntity);

                    response = new CommandResponse()
                    {
                        Id = newUserRole.Id,
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

    public class EditUserRoleHandler : IRequestHandler<EditUserRoleCommand, CommandResponse>
    {
        private readonly IUserRoleCommandRepository _UserRoleCommandRepository;
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public EditUserRoleHandler(IUserRoleCommandRepository UserRoleCommandRepository, IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleCommandRepository = UserRoleCommandRepository;
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditUserRoleCommand request, CancellationToken cancellationToken)
        {
            var UserRoleEntity = MapperConfig.Mapper.Map<UserRole>(request);
            UserRoleEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (UserRoleEntity is null)
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
                await _UserRoleCommandRepository.UpdateAsync(UserRoleEntity);

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

            var modifiedUserRole = await _UserRoleQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedUserRole.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteUserRoleHandler : IRequestHandler<DeleteUserRoleCommand, CommandResponse>
    {
        private readonly IUserRoleCommandRepository _UserRoleCommandRepository;
        private readonly IUserRoleQueryRepository _UserRoleQueryRepository;

        public DeleteUserRoleHandler(IUserRoleCommandRepository UserRoleCommandRepository, IUserRoleQueryRepository UserRoleQueryRepository)
        {
            _UserRoleCommandRepository = UserRoleCommandRepository;
            _UserRoleQueryRepository = UserRoleQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteUserRoleCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var UserRoleEntity = await _UserRoleQueryRepository.GetByIdAsync(request.Id);


                await _UserRoleCommandRepository.DeleteAsync(UserRoleEntity);

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

	#region Group
	public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, CommandResponse>
	{
		private readonly IGroupCommandRepository _GroupCommandRepository;

		public CreateGroupHandler(IGroupCommandRepository GroupCommandRepository)
		{
			_GroupCommandRepository = GroupCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
		{
			var GroupEntity = MapperConfig.Mapper.Map<Group>(request);
			GroupEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (GroupEntity is null)
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
					var newGroup = await _GroupCommandRepository.AddAsync(GroupEntity);

					response = new CommandResponse()
					{
						Id = newGroup.Id,
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

	public class EditGroupHandler : IRequestHandler<EditGroupCommand, CommandResponse>
	{
		private readonly IGroupCommandRepository _GroupCommandRepository;
		private readonly IGroupQueryRepository _GroupQueryRepository;

		public EditGroupHandler(IGroupCommandRepository GroupCommandRepository, IGroupQueryRepository GroupQueryRepository)
		{
			_GroupCommandRepository = GroupCommandRepository;
			_GroupQueryRepository = GroupQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditGroupCommand request, CancellationToken cancellationToken)
		{
			var GroupEntity = MapperConfig.Mapper.Map<Group>(request);
			GroupEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (GroupEntity is null)
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
				await _GroupCommandRepository.UpdateAsync(GroupEntity);

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

			var modifiedGroup = await _GroupQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedGroup.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, CommandResponse>
	{
		private readonly IGroupCommandRepository _GroupCommandRepository;
		private readonly IGroupQueryRepository _GroupQueryRepository;

		public DeleteGroupHandler(IGroupCommandRepository GroupCommandRepository, IGroupQueryRepository GroupQueryRepository)
		{
			_GroupCommandRepository = GroupCommandRepository;
			_GroupQueryRepository = GroupQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var GroupEntity = await _GroupQueryRepository.GetByIdAsync(request.Id);


				await _GroupCommandRepository.DeleteAsync(GroupEntity);

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

	#region GroupUser
	public class CreateGroupUserHandler : IRequestHandler<CreateGroupUserCommand, CommandResponse>
	{
		private readonly IGroupUserCommandRepository _GroupUserCommandRepository;

		public CreateGroupUserHandler(IGroupUserCommandRepository GroupUserCommandRepository)
		{
			_GroupUserCommandRepository = GroupUserCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateGroupUserCommand request, CancellationToken cancellationToken)
		{
			var GroupUserEntity = MapperConfig.Mapper.Map<GroupUser>(request);
			GroupUserEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (GroupUserEntity is null)
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
					var newGroupUser = await _GroupUserCommandRepository.AddAsync(GroupUserEntity);

					response = new CommandResponse()
					{
						Id = newGroupUser.Id,
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

	public class EditGroupUserHandler : IRequestHandler<EditGroupUserCommand, CommandResponse>
	{
		private readonly IGroupUserCommandRepository _GroupUserCommandRepository;
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public EditGroupUserHandler(IGroupUserCommandRepository GroupUserCommandRepository, IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserCommandRepository = GroupUserCommandRepository;
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditGroupUserCommand request, CancellationToken cancellationToken)
		{
			var GroupUserEntity = MapperConfig.Mapper.Map<GroupUser>(request);
			GroupUserEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (GroupUserEntity is null)
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
				await _GroupUserCommandRepository.UpdateAsync(GroupUserEntity);

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

			var modifiedGroupUser = await _GroupUserQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedGroupUser.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteGroupUserHandler : IRequestHandler<DeleteGroupUserCommand, CommandResponse>
	{
		private readonly IGroupUserCommandRepository _GroupUserCommandRepository;
		private readonly IGroupUserQueryRepository _GroupUserQueryRepository;

		public DeleteGroupUserHandler(IGroupUserCommandRepository GroupUserCommandRepository, IGroupUserQueryRepository GroupUserQueryRepository)
		{
			_GroupUserCommandRepository = GroupUserCommandRepository;
			_GroupUserQueryRepository = GroupUserQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteGroupUserCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var GroupUserEntity = await _GroupUserQueryRepository.GetByIdAsync(request.Id);


				await _GroupUserCommandRepository.DeleteAsync(GroupUserEntity);

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

	#region FormCategory
	public class CreateFormCategoryHandler : IRequestHandler<CreateFormCategoryCommand, CommandResponse>
	{
		private readonly IFormCategoryCommandRepository _FormCategoryCommandRepository;

		public CreateFormCategoryHandler(IFormCategoryCommandRepository FormCategoryCommandRepository)
		{
			_FormCategoryCommandRepository = FormCategoryCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateFormCategoryCommand request, CancellationToken cancellationToken)
		{
			var FormCategoryEntity = MapperConfig.Mapper.Map<FormCategory>(request);
			FormCategoryEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormCategoryEntity is null)
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
					var newFormCategory = await _FormCategoryCommandRepository.AddAsync(FormCategoryEntity);

					response = new CommandResponse()
					{
						Id = newFormCategory.Id,
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

	public class EditFormCategoryHandler : IRequestHandler<EditFormCategoryCommand, CommandResponse>
	{
		private readonly IFormCategoryCommandRepository _FormCategoryCommandRepository;
		private readonly IFormCategoryQueryRepository _FormCategoryQueryRepository;

		public EditFormCategoryHandler(IFormCategoryCommandRepository FormCategoryCommandRepository, IFormCategoryQueryRepository FormCategoryQueryRepository)
		{
			_FormCategoryCommandRepository = FormCategoryCommandRepository;
			_FormCategoryQueryRepository = FormCategoryQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditFormCategoryCommand request, CancellationToken cancellationToken)
		{
			var FormCategoryEntity = MapperConfig.Mapper.Map<FormCategory>(request);
			FormCategoryEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormCategoryEntity is null)
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
				await _FormCategoryCommandRepository.UpdateAsync(FormCategoryEntity);

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

			var modifiedFormCategory = await _FormCategoryQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedFormCategory.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteFormCategoryHandler : IRequestHandler<DeleteFormCategoryCommand, CommandResponse>
	{
		private readonly IFormCategoryCommandRepository _FormCategoryCommandRepository;
		private readonly IFormCategoryQueryRepository _FormCategoryQueryRepository;

		public DeleteFormCategoryHandler(IFormCategoryCommandRepository FormCategoryCommandRepository, IFormCategoryQueryRepository FormCategoryQueryRepository)
		{
			_FormCategoryCommandRepository = FormCategoryCommandRepository;
			_FormCategoryQueryRepository = FormCategoryQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteFormCategoryCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var FormCategoryEntity = await _FormCategoryQueryRepository.GetByIdAsync(request.Id);


				await _FormCategoryCommandRepository.DeleteAsync(FormCategoryEntity);

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

	#region Form
	public class CreateFormHandler : IRequestHandler<CreateFormCommand, CommandResponse>
	{
		private readonly IFormCommandRepository _FormCommandRepository;

		public CreateFormHandler(IFormCommandRepository FormCommandRepository)
		{
			_FormCommandRepository = FormCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateFormCommand request, CancellationToken cancellationToken)
		{
			var FormEntity = MapperConfig.Mapper.Map<Form>(request);
			FormEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormEntity is null)
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
					var newForm = await _FormCommandRepository.AddAsync(FormEntity);

					response = new CommandResponse()
					{
						Id = newForm.Id,
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

	public class EditFormHandler : IRequestHandler<EditFormCommand, CommandResponse>
	{
		private readonly IFormCommandRepository _FormCommandRepository;
		private readonly IFormQueryRepository _FormQueryRepository;

		public EditFormHandler(IFormCommandRepository FormCommandRepository, IFormQueryRepository FormQueryRepository)
		{
			_FormCommandRepository = FormCommandRepository;
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditFormCommand request, CancellationToken cancellationToken)
		{
			var FormEntity = MapperConfig.Mapper.Map<Form>(request);
			FormEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormEntity is null)
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
				await _FormCommandRepository.UpdateAsync(FormEntity);

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

			var modifiedForm = await _FormQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedForm.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteFormHandler : IRequestHandler<DeleteFormCommand, CommandResponse>
	{
		private readonly IFormCommandRepository _FormCommandRepository;
		private readonly IFormQueryRepository _FormQueryRepository;

		public DeleteFormHandler(IFormCommandRepository FormCommandRepository, IFormQueryRepository FormQueryRepository)
		{
			_FormCommandRepository = FormCommandRepository;
			_FormQueryRepository = FormQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteFormCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var FormEntity = await _FormQueryRepository.GetByIdAsync(request.Id);


				await _FormCommandRepository.DeleteAsync(FormEntity);

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

	#region FormAction
	public class CreateFormActionHandler : IRequestHandler<CreateFormActionCommand, CommandResponse>
	{
		private readonly IFormActionCommandRepository _FormActionCommandRepository;

		public CreateFormActionHandler(IFormActionCommandRepository FormActionCommandRepository)
		{
			_FormActionCommandRepository = FormActionCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateFormActionCommand request, CancellationToken cancellationToken)
		{
			var FormActionEntity = MapperConfig.Mapper.Map<FormAction>(request);
			FormActionEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormActionEntity is null)
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
					var newFormAction = await _FormActionCommandRepository.AddAsync(FormActionEntity);

					response = new CommandResponse()
					{
						Id = newFormAction.Id,
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

	public class EditFormActionHandler : IRequestHandler<EditFormActionCommand, CommandResponse>
	{
		private readonly IFormActionCommandRepository _FormActionCommandRepository;
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public EditFormActionHandler(IFormActionCommandRepository FormActionCommandRepository, IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionCommandRepository = FormActionCommandRepository;
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditFormActionCommand request, CancellationToken cancellationToken)
		{
			var FormActionEntity = MapperConfig.Mapper.Map<FormAction>(request);
			FormActionEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormActionEntity is null)
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
				await _FormActionCommandRepository.UpdateAsync(FormActionEntity);

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

			var modifiedFormAction = await _FormActionQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedFormAction.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteFormActionHandler : IRequestHandler<DeleteFormActionCommand, CommandResponse>
	{
		private readonly IFormActionCommandRepository _FormActionCommandRepository;
		private readonly IFormActionQueryRepository _FormActionQueryRepository;

		public DeleteFormActionHandler(IFormActionCommandRepository FormActionCommandRepository, IFormActionQueryRepository FormActionQueryRepository)
		{
			_FormActionCommandRepository = FormActionCommandRepository;
			_FormActionQueryRepository = FormActionQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteFormActionCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var FormActionEntity = await _FormActionQueryRepository.GetByIdAsync(request.Id);


				await _FormActionCommandRepository.DeleteAsync(FormActionEntity);

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

	#region FormActionAccess
	public class CreateFormActionAccessHandler : IRequestHandler<CreateFormActionAccessCommand, CommandResponse>
	{
		private readonly IFormActionAccessCommandRepository _FormActionAccessCommandRepository;

		public CreateFormActionAccessHandler(IFormActionAccessCommandRepository FormActionAccessCommandRepository)
		{
			_FormActionAccessCommandRepository = FormActionAccessCommandRepository;
		}

		public async Task<CommandResponse> Handle(CreateFormActionAccessCommand request, CancellationToken cancellationToken)
		{
			var FormActionAccessEntity = MapperConfig.Mapper.Map<FormActionAccess>(request);
			FormActionAccessEntity.CreatedDate = DateTime.Now;


			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormActionAccessEntity is null)
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
					var newFormActionAccess = await _FormActionAccessCommandRepository.AddAsync(FormActionAccessEntity);

					response = new CommandResponse()
					{
						Id = newFormActionAccess.Id,
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

	public class EditFormActionAccessHandler : IRequestHandler<EditFormActionAccessCommand, CommandResponse>
	{
		private readonly IFormActionAccessCommandRepository _FormActionAccessCommandRepository;
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public EditFormActionAccessHandler(IFormActionAccessCommandRepository FormActionAccessCommandRepository, IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessCommandRepository = FormActionAccessCommandRepository;
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<CommandResponse> Handle(EditFormActionAccessCommand request, CancellationToken cancellationToken)
		{
			var FormActionAccessEntity = MapperConfig.Mapper.Map<FormActionAccess>(request);
			FormActionAccessEntity.ModifiedDate = DateTime.Now;
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			if (FormActionAccessEntity is null)
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
				await _FormActionAccessCommandRepository.UpdateAsync(FormActionAccessEntity);

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

			var modifiedFormActionAccess = await _FormActionAccessQueryRepository.GetByIdAsync(request.Id);

			response = new CommandResponse()
			{
				Id = modifiedFormActionAccess.Id,
				ResultType = ResultType.Success,
				ResultMessage = "Updated successfully"
			};

			return response;
		}
	}

	public class DeleteFormActionAccessHandler : IRequestHandler<DeleteFormActionAccessCommand, CommandResponse>
	{
		private readonly IFormActionAccessCommandRepository _FormActionAccessCommandRepository;
		private readonly IFormActionAccessQueryRepository _FormActionAccessQueryRepository;

		public DeleteFormActionAccessHandler(IFormActionAccessCommandRepository FormActionAccessCommandRepository, IFormActionAccessQueryRepository FormActionAccessQueryRepository)
		{
			_FormActionAccessCommandRepository = FormActionAccessCommandRepository;
			_FormActionAccessQueryRepository = FormActionAccessQueryRepository;
		}

		public async Task<CommandResponse> Handle(DeleteFormActionAccessCommand request, CancellationToken cancellationToken)
		{
			CommandResponse response = new CommandResponse()
			{
				Id = 0,
				ResultType = ResultType.None,
				ResultMessage = "Unknown"
			};

			try
			{
				var FormActionAccessEntity = await _FormActionAccessQueryRepository.GetByIdAsync(request.Id);


				await _FormActionAccessCommandRepository.DeleteAsync(FormActionAccessEntity);

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
