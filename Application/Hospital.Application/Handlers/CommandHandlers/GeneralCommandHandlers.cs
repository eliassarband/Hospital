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

    #region BasicInformationCategory
    public class CreateBasicInformationCategoryHandler : IRequestHandler<CreateBSCategoryCommand, CommandResponse>
    {
        private readonly IBasicInformationCategoryCommandRepository _BasicInformationCategoryCommandRepository;

        public CreateBasicInformationCategoryHandler(IBasicInformationCategoryCommandRepository BSCategoryCommandRepository)
        {
            _BasicInformationCategoryCommandRepository = BSCategoryCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateBSCategoryCommand request, CancellationToken cancellationToken)
        {
            var CategoryEntity = MapperConfig.Mapper.Map<BasicInformationCategory>(request);
            CategoryEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (CategoryEntity is null)
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
                    var newCategory = await _BasicInformationCategoryCommandRepository.AddAsync(CategoryEntity);

                    response = new CommandResponse()
                    {
                        Id = newCategory.Id,
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

    public class EditBasicInformationCategoryHandler : IRequestHandler<EditBSCategoryCommand, CommandResponse>
    {
        private readonly IBasicInformationCategoryCommandRepository _BasicInformationCategoryCommandRepository;
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public EditBasicInformationCategoryHandler(IBasicInformationCategoryCommandRepository BSCategoryCommandRepository, IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryCommandRepository = BSCategoryCommandRepository;
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditBSCategoryCommand request, CancellationToken cancellationToken)
        {
            var CategoryEntity = MapperConfig.Mapper.Map<BasicInformationCategory>(request);
            CategoryEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (CategoryEntity is null)
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
                await _BasicInformationCategoryCommandRepository.UpdateAsync(CategoryEntity);

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

            var modifiedCategory = await _BasicInformationCategoryQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedCategory.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteBasicInformationCategoryHandler : IRequestHandler<DeleteBSCategoryCommand, CommandResponse>
    {
        private readonly IBasicInformationCategoryCommandRepository _BasicInformationCategoryCommandRepository;
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public DeleteBasicInformationCategoryHandler(IBasicInformationCategoryCommandRepository BSCategoryCommandRepository, IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryCommandRepository = BSCategoryCommandRepository;
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteBSCategoryCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var CategoryEntity = await _BasicInformationCategoryQueryRepository.GetByIdAsync(request.Id);

                if (CategoryEntity.BasicInformations != null && CategoryEntity.BasicInformations.Count > 0)
                {
                    response = new CommandResponse()
                    {
                        Id = request.Id,
                        ResultType = ResultType.Warning,
                        ResultMessage = "Due to the existence of basic information, it is not possible to delete"
                    };
                }
                else
                {
                    await _BasicInformationCategoryCommandRepository.DeleteAsync(CategoryEntity);

                    response = new CommandResponse()
                    {
                        Id = request.Id,
                        ResultType = ResultType.Success,
                        ResultMessage = "Removed successfully"
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

            return response;
        }
    }

    #endregion

    #region BasicInformation
    public class CreateBasicInformationHandler : IRequestHandler<CreateBasicInformationCommand, CommandResponse>
    {
        private readonly IBasicInformationCommandRepository _BasicInformationCommandRepository;

        public CreateBasicInformationHandler(IBasicInformationCommandRepository BasicInformationCommandRepository)
        {
            _BasicInformationCommandRepository = BasicInformationCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateBasicInformationCommand request, CancellationToken cancellationToken)
        {
            var BasicInformationEntity = MapperConfig.Mapper.Map<BasicInformation>(request);
            BasicInformationEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (BasicInformationEntity is null)
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
                    var newBasicInformation = await _BasicInformationCommandRepository.AddAsync(BasicInformationEntity);

                    response = new CommandResponse()
                    {
                        Id = newBasicInformation.Id,
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

    public class EditBasicInformationHandler : IRequestHandler<EditBasicInformationCommand, CommandResponse>
    {
        private readonly IBasicInformationCommandRepository _BasicInformationCommandRepository;
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public EditBasicInformationHandler(IBasicInformationCommandRepository BasicInformationCommandRepository, IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationCommandRepository = BasicInformationCommandRepository;
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditBasicInformationCommand request, CancellationToken cancellationToken)
        {
            var BasicInformationEntity = MapperConfig.Mapper.Map<BasicInformation>(request);
            BasicInformationEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (BasicInformationEntity is null)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "There is a problem in mapper"
                };
            }

            if (!BasicInformationEntity.AllowChange)
            {
                return new CommandResponse()
                {
                    Id = 0,
                    ResultType = ResultType.Warning,
                    ResultMessage = "The selected basic information cannot be edited"
                };
            }

            try
            {
                await _BasicInformationCommandRepository.UpdateAsync(BasicInformationEntity);

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

            var modifiedBasicInformation = await _BasicInformationQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedBasicInformation.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteBasicInformationHandler : IRequestHandler<DeleteBasicInformationCommand, CommandResponse>
    {
        private readonly IBasicInformationCommandRepository _BasicInformationCommandRepository;
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public DeleteBasicInformationHandler(IBasicInformationCommandRepository BasicInformationCommandRepository, IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationCommandRepository = BasicInformationCommandRepository;
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteBasicInformationCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var BasicInformationEntity = await _BasicInformationQueryRepository.GetByIdAsync(request.Id);

                if (BasicInformationEntity.BasicInformations != null && BasicInformationEntity.BasicInformations.Count > 0)
                {
                    response = new CommandResponse()
                    {
                        Id = request.Id,
                        ResultType = ResultType.Warning,
                        ResultMessage = "Due to the existence of related basic information, it is not possible to delete"
                    };
                }
                else if (!BasicInformationEntity.AllowDelete)
                {
                    return new CommandResponse()
                    {
                        Id = 0,
                        ResultType = ResultType.Warning,
                        ResultMessage = "The selected basic information cannot be deleted"
                    };
                }
                else
                {
                    await _BasicInformationCommandRepository.DeleteAsync(BasicInformationEntity);

                    response = new CommandResponse()
                    {
                        Id = request.Id,
                        ResultType = ResultType.Success,
                        ResultMessage = "Removed successfully"
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

            return response;
        }
    }

    #endregion

    #region Department
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, CommandResponse>
    {
        private readonly IDepartmentCommandRepository _DepartmentCommandRepository;

        public CreateDepartmentHandler(IDepartmentCommandRepository DepartmentCommandRepository)
        {
            _DepartmentCommandRepository = DepartmentCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var DepartmentEntity = MapperConfig.Mapper.Map<Department>(request);
            DepartmentEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (DepartmentEntity is null)
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
                    var newDepartment = await _DepartmentCommandRepository.AddAsync(DepartmentEntity);

                    response = new CommandResponse()
                    {
                        Id = newDepartment.Id,
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

    public class EditDepartmentHandler : IRequestHandler<EditDepartmentCommand, CommandResponse>
    {
        private readonly IDepartmentCommandRepository _DepartmentCommandRepository;
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public EditDepartmentHandler(IDepartmentCommandRepository DepartmentCommandRepository, IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentCommandRepository = DepartmentCommandRepository;
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditDepartmentCommand request, CancellationToken cancellationToken)
        {
            var DepartmentEntity = MapperConfig.Mapper.Map<Department>(request);
            DepartmentEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (DepartmentEntity is null)
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
                await _DepartmentCommandRepository.UpdateAsync(DepartmentEntity);

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

            var modifiedDepartment = await _DepartmentQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedDepartment.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand, CommandResponse>
    {
        private readonly IDepartmentCommandRepository _DepartmentCommandRepository;
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public DeleteDepartmentHandler(IDepartmentCommandRepository DepartmentCommandRepository, IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentCommandRepository = DepartmentCommandRepository;
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var DepartmentEntity = await _DepartmentQueryRepository.GetByIdAsync(request.Id);


                await _DepartmentCommandRepository.DeleteAsync(DepartmentEntity);

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

    #region Service
    public class CreateServiceHandler : IRequestHandler<CreateServiceCommand, CommandResponse>
    {
        private readonly IServiceCommandRepository _ServiceCommandRepository;

        public CreateServiceHandler(IServiceCommandRepository ServiceCommandRepository)
        {
            _ServiceCommandRepository = ServiceCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var ServiceEntity = MapperConfig.Mapper.Map<Service>(request);
            ServiceEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (ServiceEntity is null)
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
                    var newService = await _ServiceCommandRepository.AddAsync(ServiceEntity);

                    response = new CommandResponse()
                    {
                        Id = newService.Id,
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

    public class EditServiceHandler : IRequestHandler<EditServiceCommand, CommandResponse>
    {
        private readonly IServiceCommandRepository _ServiceCommandRepository;
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public EditServiceHandler(IServiceCommandRepository ServiceCommandRepository, IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceCommandRepository = ServiceCommandRepository;
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditServiceCommand request, CancellationToken cancellationToken)
        {
            var ServiceEntity = MapperConfig.Mapper.Map<Service>(request);
            ServiceEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (ServiceEntity is null)
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
                await _ServiceCommandRepository.UpdateAsync(ServiceEntity);

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

            var modifiedService = await _ServiceQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedService.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteServiceHandler : IRequestHandler<DeleteServiceCommand, CommandResponse>
    {
        private readonly IServiceCommandRepository _ServiceCommandRepository;
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public DeleteServiceHandler(IServiceCommandRepository ServiceCommandRepository, IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceCommandRepository = ServiceCommandRepository;
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var ServiceEntity = await _ServiceQueryRepository.GetByIdAsync(request.Id);


                await _ServiceCommandRepository.DeleteAsync(ServiceEntity);

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

    #region RoomType
    public class CreateRoomTypeHandler : IRequestHandler<CreateRoomTypeCommand, CommandResponse>
    {
        private readonly IRoomTypeCommandRepository _RoomTypeCommandRepository;

        public CreateRoomTypeHandler(IRoomTypeCommandRepository RoomTypeCommandRepository)
        {
            _RoomTypeCommandRepository = RoomTypeCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateRoomTypeCommand request, CancellationToken cancellationToken)
        {
            var RoomTypeEntity = MapperConfig.Mapper.Map<RoomType>(request);
            RoomTypeEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoomTypeEntity is null)
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
                    var newRoomType = await _RoomTypeCommandRepository.AddAsync(RoomTypeEntity);

                    response = new CommandResponse()
                    {
                        Id = newRoomType.Id,
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

    public class EditRoomTypeHandler : IRequestHandler<EditRoomTypeCommand, CommandResponse>
    {
        private readonly IRoomTypeCommandRepository _RoomTypeCommandRepository;
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public EditRoomTypeHandler(IRoomTypeCommandRepository RoomTypeCommandRepository, IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeCommandRepository = RoomTypeCommandRepository;
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditRoomTypeCommand request, CancellationToken cancellationToken)
        {
            var RoomTypeEntity = MapperConfig.Mapper.Map<RoomType>(request);
            RoomTypeEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoomTypeEntity is null)
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
                await _RoomTypeCommandRepository.UpdateAsync(RoomTypeEntity);

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

            var modifiedRoomType = await _RoomTypeQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedRoomType.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteRoomTypeHandler : IRequestHandler<DeleteRoomTypeCommand, CommandResponse>
    {
        private readonly IRoomTypeCommandRepository _RoomTypeCommandRepository;
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public DeleteRoomTypeHandler(IRoomTypeCommandRepository RoomTypeCommandRepository, IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeCommandRepository = RoomTypeCommandRepository;
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteRoomTypeCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var RoomTypeEntity = await _RoomTypeQueryRepository.GetByIdAsync(request.Id);


                await _RoomTypeCommandRepository.DeleteAsync(RoomTypeEntity);

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

    #region Room
    public class CreateRoomHandler : IRequestHandler<CreateRoomCommand, CommandResponse>
    {
        private readonly IRoomCommandRepository _RoomCommandRepository;

        public CreateRoomHandler(IRoomCommandRepository RoomCommandRepository)
        {
            _RoomCommandRepository = RoomCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var RoomEntity = MapperConfig.Mapper.Map<Room>(request);
            RoomEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoomEntity is null)
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
                    var newRoom = await _RoomCommandRepository.AddAsync(RoomEntity);

                    response = new CommandResponse()
                    {
                        Id = newRoom.Id,
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

    public class EditRoomHandler : IRequestHandler<EditRoomCommand, CommandResponse>
    {
        private readonly IRoomCommandRepository _RoomCommandRepository;
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public EditRoomHandler(IRoomCommandRepository RoomCommandRepository, IRoomQueryRepository RoomQueryRepository)
        {
            _RoomCommandRepository = RoomCommandRepository;
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditRoomCommand request, CancellationToken cancellationToken)
        {
            var RoomEntity = MapperConfig.Mapper.Map<Room>(request);
            RoomEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RoomEntity is null)
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
                await _RoomCommandRepository.UpdateAsync(RoomEntity);

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

            var modifiedRoom = await _RoomQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedRoom.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteRoomHandler : IRequestHandler<DeleteRoomCommand, CommandResponse>
    {
        private readonly IRoomCommandRepository _RoomCommandRepository;
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public DeleteRoomHandler(IRoomCommandRepository RoomCommandRepository, IRoomQueryRepository RoomQueryRepository)
        {
            _RoomCommandRepository = RoomCommandRepository;
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var RoomEntity = await _RoomQueryRepository.GetByIdAsync(request.Id);


                await _RoomCommandRepository.DeleteAsync(RoomEntity);

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

    #region HospitalInformation
    public class CreateHospitalInformationHandler : IRequestHandler<CreateHospitalInformationCommand, CommandResponse>
    {
        private readonly IHospitalInformationCommandRepository _HospitalInformationCommandRepository;

        public CreateHospitalInformationHandler(IHospitalInformationCommandRepository HospitalInformationCommandRepository)
        {
            _HospitalInformationCommandRepository = HospitalInformationCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateHospitalInformationCommand request, CancellationToken cancellationToken)
        {
            var HospitalInformationEntity = MapperConfig.Mapper.Map<HospitalInformation>(request);
            HospitalInformationEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (HospitalInformationEntity is null)
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
                    var newHospitalInformation = await _HospitalInformationCommandRepository.AddAsync(HospitalInformationEntity);

                    response = new CommandResponse()
                    {
                        Id = newHospitalInformation.Id,
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

    public class EditHospitalInformationHandler : IRequestHandler<EditHospitalInformationCommand, CommandResponse>
    {
        private readonly IHospitalInformationCommandRepository _HospitalInformationCommandRepository;
        private readonly IHospitalInformationQueryRepository _HospitalInformationQueryRepository;

        public EditHospitalInformationHandler(IHospitalInformationCommandRepository HospitalInformationCommandRepository, IHospitalInformationQueryRepository HospitalInformationQueryRepository)
        {
            _HospitalInformationCommandRepository = HospitalInformationCommandRepository;
            _HospitalInformationQueryRepository = HospitalInformationQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditHospitalInformationCommand request, CancellationToken cancellationToken)
        {
            var HospitalInformationEntity = MapperConfig.Mapper.Map<HospitalInformation>(request);
            HospitalInformationEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (HospitalInformationEntity is null)
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
                await _HospitalInformationCommandRepository.UpdateAsync(HospitalInformationEntity);

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

            var modifiedHospitalInformation = await _HospitalInformationQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedHospitalInformation.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteHospitalInformationHandler : IRequestHandler<DeleteHospitalInformationCommand, CommandResponse>
    {
        private readonly IHospitalInformationCommandRepository _HospitalInformationCommandRepository;
        private readonly IHospitalInformationQueryRepository _HospitalInformationQueryRepository;

        public DeleteHospitalInformationHandler(IHospitalInformationCommandRepository HospitalInformationCommandRepository, IHospitalInformationQueryRepository HospitalInformationQueryRepository)
        {
            _HospitalInformationCommandRepository = HospitalInformationCommandRepository;
            _HospitalInformationQueryRepository = HospitalInformationQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteHospitalInformationCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var HospitalInformationEntity = await _HospitalInformationQueryRepository.GetByIdAsync(request.Id);


                await _HospitalInformationCommandRepository.DeleteAsync(HospitalInformationEntity);

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

    #region Attachment
    public class CreateAttachmentHandler : IRequestHandler<CreateAttachmentCommand, CommandResponse>
    {
        private readonly IAttachmentCommandRepository _AttachmentCommandRepository;

        public CreateAttachmentHandler(IAttachmentCommandRepository AttachmentCommandRepository)
        {
            _AttachmentCommandRepository = AttachmentCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
        {
            var AttachmentEntity = MapperConfig.Mapper.Map<Attachment>(request);
            AttachmentEntity.CreatedDate = DateTime.Now;


            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (AttachmentEntity is null)
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
                    var newAttachment = await _AttachmentCommandRepository.AddAsync(AttachmentEntity);

                    response = new CommandResponse()
                    {
                        Id = newAttachment.Id,
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

    public class EditAttachmentHandler : IRequestHandler<EditAttachmentCommand, CommandResponse>
    {
        private readonly IAttachmentCommandRepository _AttachmentCommandRepository;
        private readonly IAttachmentQueryRepository _AttachmentQueryRepository;

        public EditAttachmentHandler(IAttachmentCommandRepository AttachmentCommandRepository, IAttachmentQueryRepository AttachmentQueryRepository)
        {
            _AttachmentCommandRepository = AttachmentCommandRepository;
            _AttachmentQueryRepository = AttachmentQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditAttachmentCommand request, CancellationToken cancellationToken)
        {
            var AttachmentEntity = MapperConfig.Mapper.Map<Attachment>(request);
            AttachmentEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (AttachmentEntity is null)
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
                await _AttachmentCommandRepository.UpdateAsync(AttachmentEntity);

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

            var modifiedAttachment = await _AttachmentQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedAttachment.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteAttachmentHandler : IRequestHandler<DeleteAttachmentCommand, CommandResponse>
    {
        private readonly IAttachmentCommandRepository _AttachmentCommandRepository;
        private readonly IAttachmentQueryRepository _AttachmentQueryRepository;

        public DeleteAttachmentHandler(IAttachmentCommandRepository AttachmentCommandRepository, IAttachmentQueryRepository AttachmentQueryRepository)
        {
            _AttachmentCommandRepository = AttachmentCommandRepository;
            _AttachmentQueryRepository = AttachmentQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var AttachmentEntity = await _AttachmentQueryRepository.GetByIdAsync(request.Id);


                await _AttachmentCommandRepository.DeleteAsync(AttachmentEntity);

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
