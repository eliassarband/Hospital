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

    #region Insurance
    public class CreateInsuranceHandler : IRequestHandler<CreateInsuranceCommand, CommandResponse>
    {
        private readonly IInsuranceCommandRepository _InsuranceCommandRepository;

        public CreateInsuranceHandler(IInsuranceCommandRepository InsuranceCommandRepository)
        {
            _InsuranceCommandRepository = InsuranceCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateInsuranceCommand request, CancellationToken cancellationToken)
        {
            var InsuranceEntity = MapperConfig.Mapper.Map<Insurance>(request);
            InsuranceEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (InsuranceEntity is null)
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
                    var newInsurance = await _InsuranceCommandRepository.AddAsync(InsuranceEntity);

                    response = new CommandResponse()
                    {
                        Id = newInsurance.Id,
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

    public class EditInsuranceHandler : IRequestHandler<EditInsuranceCommand, CommandResponse>
    {
        private readonly IInsuranceCommandRepository _InsuranceCommandRepository;
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public EditInsuranceHandler(IInsuranceCommandRepository InsuranceCommandRepository, IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceCommandRepository = InsuranceCommandRepository;
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditInsuranceCommand request, CancellationToken cancellationToken)
        {
            var InsuranceEntity = MapperConfig.Mapper.Map<Insurance>(request);
            InsuranceEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (InsuranceEntity is null)
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
                await _InsuranceCommandRepository.UpdateAsync(InsuranceEntity);

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

            var modifiedInsurance = await _InsuranceQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedInsurance.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteInsuranceHandler : IRequestHandler<DeleteInsuranceCommand, CommandResponse>
    {
        private readonly IInsuranceCommandRepository _InsuranceCommandRepository;
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public DeleteInsuranceHandler(IInsuranceCommandRepository InsuranceCommandRepository, IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceCommandRepository = InsuranceCommandRepository;
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteInsuranceCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var InsuranceEntity = await _InsuranceQueryRepository.GetByIdAsync(request.Id);

                await _InsuranceCommandRepository.DeleteAsync(InsuranceEntity);

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

    #region InsuranceAgreement
    public class CreateInsuranceAgreementHandler : IRequestHandler<CreateInsuranceAgreementCommand, CommandResponse>
    {
        private readonly IInsuranceAgreementCommandRepository _InsuranceAgreementCommandRepository;

        public CreateInsuranceAgreementHandler(IInsuranceAgreementCommandRepository InsuranceAgreementCommandRepository)
        {
            _InsuranceAgreementCommandRepository = InsuranceAgreementCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateInsuranceAgreementCommand request, CancellationToken cancellationToken)
        {
            var InsuranceAgreementEntity = MapperConfig.Mapper.Map<InsuranceAgreement>(request);
            InsuranceAgreementEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (InsuranceAgreementEntity is null)
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
                    var newInsuranceAgreement = await _InsuranceAgreementCommandRepository.AddAsync(InsuranceAgreementEntity);

                    response = new CommandResponse()
                    {
                        Id = newInsuranceAgreement.Id,
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

    public class EditInsuranceAgreementHandler : IRequestHandler<EditInsuranceAgreementCommand, CommandResponse>
    {
        private readonly IInsuranceAgreementCommandRepository _InsuranceAgreementCommandRepository;
        private readonly IInsuranceAgreementQueryRepository _InsuranceAgreementQueryRepository;

        public EditInsuranceAgreementHandler(IInsuranceAgreementCommandRepository InsuranceAgreementCommandRepository, IInsuranceAgreementQueryRepository InsuranceAgreementQueryRepository)
        {
            _InsuranceAgreementCommandRepository = InsuranceAgreementCommandRepository;
            _InsuranceAgreementQueryRepository = InsuranceAgreementQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditInsuranceAgreementCommand request, CancellationToken cancellationToken)
        {
            var InsuranceAgreementEntity = MapperConfig.Mapper.Map<InsuranceAgreement>(request);
            InsuranceAgreementEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (InsuranceAgreementEntity is null)
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
                await _InsuranceAgreementCommandRepository.UpdateAsync(InsuranceAgreementEntity);

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

            var modifiedInsuranceAgreement = await _InsuranceAgreementQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedInsuranceAgreement.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteInsuranceAgreementHandler : IRequestHandler<DeleteInsuranceAgreementCommand, CommandResponse>
    {
        private readonly IInsuranceAgreementCommandRepository _InsuranceAgreementCommandRepository;
        private readonly IInsuranceAgreementQueryRepository _InsuranceAgreementQueryRepository;

        public DeleteInsuranceAgreementHandler(IInsuranceAgreementCommandRepository InsuranceAgreementCommandRepository, IInsuranceAgreementQueryRepository InsuranceAgreementQueryRepository)
        {
            _InsuranceAgreementCommandRepository = InsuranceAgreementCommandRepository;
            _InsuranceAgreementQueryRepository = InsuranceAgreementQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteInsuranceAgreementCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var InsuranceAgreementEntity = await _InsuranceAgreementQueryRepository.GetByIdAsync(request.Id);

                await _InsuranceAgreementCommandRepository.DeleteAsync(InsuranceAgreementEntity);

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

    #region Staff
    public class CreateStaffHandler : IRequestHandler<CreateStaffCommand, CommandResponse>
    {
        private readonly IStaffCommandRepository _StaffCommandRepository;

        public CreateStaffHandler(IStaffCommandRepository StaffCommandRepository)
        {
            _StaffCommandRepository = StaffCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            var StaffEntity = MapperConfig.Mapper.Map<Staff>(request);
            StaffEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (StaffEntity is null)
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
                    var newStaff = await _StaffCommandRepository.AddAsync(StaffEntity);

                    response = new CommandResponse()
                    {
                        Id = newStaff.Id,
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

    public class EditStaffHandler : IRequestHandler<EditStaffCommand, CommandResponse>
    {
        private readonly IStaffCommandRepository _StaffCommandRepository;
        private readonly IStaffQueryRepository _StaffQueryRepository;

        public EditStaffHandler(IStaffCommandRepository StaffCommandRepository, IStaffQueryRepository StaffQueryRepository)
        {
            _StaffCommandRepository = StaffCommandRepository;
            _StaffQueryRepository = StaffQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditStaffCommand request, CancellationToken cancellationToken)
        {
            var StaffEntity = MapperConfig.Mapper.Map<Staff>(request);
            StaffEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (StaffEntity is null)
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
                await _StaffCommandRepository.UpdateAsync(StaffEntity);

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

            var modifiedStaff = await _StaffQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedStaff.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteStaffHandler : IRequestHandler<DeleteStaffCommand, CommandResponse>
    {
        private readonly IStaffCommandRepository _StaffCommandRepository;
        private readonly IStaffQueryRepository _StaffQueryRepository;

        public DeleteStaffHandler(IStaffCommandRepository StaffCommandRepository, IStaffQueryRepository StaffQueryRepository)
        {
            _StaffCommandRepository = StaffCommandRepository;
            _StaffQueryRepository = StaffQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var StaffEntity = await _StaffQueryRepository.GetByIdAsync(request.Id);

                await _StaffCommandRepository.DeleteAsync(StaffEntity);

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

    #region StaffTiming
    public class CreateStaffTimingHandler : IRequestHandler<CreateStaffTimingCommand, CommandResponse>
    {
        private readonly IStaffTimingCommandRepository _StaffTimingCommandRepository;

        public CreateStaffTimingHandler(IStaffTimingCommandRepository StaffTimingCommandRepository)
        {
            _StaffTimingCommandRepository = StaffTimingCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateStaffTimingCommand request, CancellationToken cancellationToken)
        {
            var StaffTimingEntity = MapperConfig.Mapper.Map<StaffTiming>(request);
            StaffTimingEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (StaffTimingEntity is null)
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
                    var newStaffTiming = await _StaffTimingCommandRepository.AddAsync(StaffTimingEntity);

                    response = new CommandResponse()
                    {
                        Id = newStaffTiming.Id,
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

    public class EditStaffTimingHandler : IRequestHandler<EditStaffTimingCommand, CommandResponse>
    {
        private readonly IStaffTimingCommandRepository _StaffTimingCommandRepository;
        private readonly IStaffTimingQueryRepository _StaffTimingQueryRepository;

        public EditStaffTimingHandler(IStaffTimingCommandRepository StaffTimingCommandRepository, IStaffTimingQueryRepository StaffTimingQueryRepository)
        {
            _StaffTimingCommandRepository = StaffTimingCommandRepository;
            _StaffTimingQueryRepository = StaffTimingQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditStaffTimingCommand request, CancellationToken cancellationToken)
        {
            var StaffTimingEntity = MapperConfig.Mapper.Map<StaffTiming>(request);
            StaffTimingEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (StaffTimingEntity is null)
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
                await _StaffTimingCommandRepository.UpdateAsync(StaffTimingEntity);

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

            var modifiedStaffTiming = await _StaffTimingQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedStaffTiming.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteStaffTimingHandler : IRequestHandler<DeleteStaffTimingCommand, CommandResponse>
    {
        private readonly IStaffTimingCommandRepository _StaffTimingCommandRepository;
        private readonly IStaffTimingQueryRepository _StaffTimingQueryRepository;

        public DeleteStaffTimingHandler(IStaffTimingCommandRepository StaffTimingCommandRepository, IStaffTimingQueryRepository StaffTimingQueryRepository)
        {
            _StaffTimingCommandRepository = StaffTimingCommandRepository;
            _StaffTimingQueryRepository = StaffTimingQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteStaffTimingCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var StaffTimingEntity = await _StaffTimingQueryRepository.GetByIdAsync(request.Id);

                await _StaffTimingCommandRepository.DeleteAsync(StaffTimingEntity);

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

    #region RefferBy
    public class CreateRefferByHandler : IRequestHandler<CreateRefferByCommand, CommandResponse>
    {
        private readonly IRefferByCommandRepository _RefferByCommandRepository;

        public CreateRefferByHandler(IRefferByCommandRepository RefferByCommandRepository)
        {
            _RefferByCommandRepository = RefferByCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateRefferByCommand request, CancellationToken cancellationToken)
        {
            var RefferByEntity = MapperConfig.Mapper.Map<RefferBy>(request);
            RefferByEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RefferByEntity is null)
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
                    var newRefferBy = await _RefferByCommandRepository.AddAsync(RefferByEntity);

                    response = new CommandResponse()
                    {
                        Id = newRefferBy.Id,
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

    public class EditRefferByHandler : IRequestHandler<EditRefferByCommand, CommandResponse>
    {
        private readonly IRefferByCommandRepository _RefferByCommandRepository;
        private readonly IRefferByQueryRepository _RefferByQueryRepository;

        public EditRefferByHandler(IRefferByCommandRepository RefferByCommandRepository, IRefferByQueryRepository RefferByQueryRepository)
        {
            _RefferByCommandRepository = RefferByCommandRepository;
            _RefferByQueryRepository = RefferByQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditRefferByCommand request, CancellationToken cancellationToken)
        {
            var RefferByEntity = MapperConfig.Mapper.Map<RefferBy>(request);
            RefferByEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (RefferByEntity is null)
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
                await _RefferByCommandRepository.UpdateAsync(RefferByEntity);

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

            var modifiedRefferBy = await _RefferByQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedRefferBy.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteRefferByHandler : IRequestHandler<DeleteRefferByCommand, CommandResponse>
    {
        private readonly IRefferByCommandRepository _RefferByCommandRepository;
        private readonly IRefferByQueryRepository _RefferByQueryRepository;

        public DeleteRefferByHandler(IRefferByCommandRepository RefferByCommandRepository, IRefferByQueryRepository RefferByQueryRepository)
        {
            _RefferByCommandRepository = RefferByCommandRepository;
            _RefferByQueryRepository = RefferByQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteRefferByCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var RefferByEntity = await _RefferByQueryRepository.GetByIdAsync(request.Id);

                await _RefferByCommandRepository.DeleteAsync(RefferByEntity);

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
