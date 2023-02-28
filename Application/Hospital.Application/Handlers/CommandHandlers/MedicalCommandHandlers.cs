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

    #region Patient
    public class CreatePatientHandler : IRequestHandler<CreatePatientCommand, CommandResponse>
    {
        private readonly IPatientCommandRepository _PatientCommandRepository;

        public CreatePatientHandler(IPatientCommandRepository PatientCommandRepository)
        {
            _PatientCommandRepository = PatientCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var PatientEntity = MapperConfig.Mapper.Map<Patient>(request);
            PatientEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (PatientEntity is null)
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
                    var newPatient = await _PatientCommandRepository.AddAsync(PatientEntity);

                    response = new CommandResponse()
                    {
                        Id = newPatient.Id,
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

    public class EditPatientHandler : IRequestHandler<EditPatientCommand, CommandResponse>
    {
        private readonly IPatientCommandRepository _PatientCommandRepository;
        private readonly IPatientQueryRepository _PatientQueryRepository;

        public EditPatientHandler(IPatientCommandRepository PatientCommandRepository, IPatientQueryRepository PatientQueryRepository)
        {
            _PatientCommandRepository = PatientCommandRepository;
            _PatientQueryRepository = PatientQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditPatientCommand request, CancellationToken cancellationToken)
        {
            var PatientEntity = MapperConfig.Mapper.Map<Patient>(request);
            PatientEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (PatientEntity is null)
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
                await _PatientCommandRepository.UpdateAsync(PatientEntity);

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

            var modifiedPatient = await _PatientQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedPatient.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeletePatientHandler : IRequestHandler<DeletePatientCommand, CommandResponse>
    {
        private readonly IPatientCommandRepository _PatientCommandRepository;
        private readonly IPatientQueryRepository _PatientQueryRepository;

        public DeletePatientHandler(IPatientCommandRepository PatientCommandRepository, IPatientQueryRepository PatientQueryRepository)
        {
            _PatientCommandRepository = PatientCommandRepository;
            _PatientQueryRepository = PatientQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var PatientEntity = await _PatientQueryRepository.GetByIdAsync(request.Id);

                await _PatientCommandRepository.DeleteAsync(PatientEntity);

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

    #region OPDBill
    public class CreateOPDBillHandler : IRequestHandler<CreateOPDBillCommand, CommandResponse>
    {
        private readonly IOPDBillCommandRepository _OPDBillCommandRepository;

        public CreateOPDBillHandler(IOPDBillCommandRepository OPDBillCommandRepository)
        {
            _OPDBillCommandRepository = OPDBillCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateOPDBillCommand request, CancellationToken cancellationToken)
        {
            var OPDBillEntity = MapperConfig.Mapper.Map<OPDBill>(request);
            OPDBillEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (OPDBillEntity is null)
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
                    var newOPDBill = await _OPDBillCommandRepository.AddAsync(OPDBillEntity);

                    response = new CommandResponse()
                    {
                        Id = newOPDBill.Id,
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

    public class EditOPDBillHandler : IRequestHandler<EditOPDBillCommand, CommandResponse>
    {
        private readonly IOPDBillCommandRepository _OPDBillCommandRepository;
        private readonly IOPDBillQueryRepository _OPDBillQueryRepository;

        public EditOPDBillHandler(IOPDBillCommandRepository OPDBillCommandRepository, IOPDBillQueryRepository OPDBillQueryRepository)
        {
            _OPDBillCommandRepository = OPDBillCommandRepository;
            _OPDBillQueryRepository = OPDBillQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditOPDBillCommand request, CancellationToken cancellationToken)
        {
            var OPDBillEntity = MapperConfig.Mapper.Map<OPDBill>(request);
            OPDBillEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (OPDBillEntity is null)
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
                await _OPDBillCommandRepository.UpdateAsync(OPDBillEntity);

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

            var modifiedOPDBill = await _OPDBillQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedOPDBill.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteOPDBillHandler : IRequestHandler<DeleteOPDBillCommand, CommandResponse>
    {
        private readonly IOPDBillCommandRepository _OPDBillCommandRepository;
        private readonly IOPDBillQueryRepository _OPDBillQueryRepository;

        public DeleteOPDBillHandler(IOPDBillCommandRepository OPDBillCommandRepository, IOPDBillQueryRepository OPDBillQueryRepository)
        {
            _OPDBillCommandRepository = OPDBillCommandRepository;
            _OPDBillQueryRepository = OPDBillQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteOPDBillCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var OPDBillEntity = await _OPDBillQueryRepository.GetByIdAsync(request.Id);

                await _OPDBillCommandRepository.DeleteAsync(OPDBillEntity);

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

    #region OPDBillService
    public class CreateOPDBillServiceHandler : IRequestHandler<CreateOPDBillServiceCommand, CommandResponse>
    {
        private readonly IOPDBillServiceCommandRepository _OPDBillServiceCommandRepository;

        public CreateOPDBillServiceHandler(IOPDBillServiceCommandRepository OPDBillServiceCommandRepository)
        {
            _OPDBillServiceCommandRepository = OPDBillServiceCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateOPDBillServiceCommand request, CancellationToken cancellationToken)
        {
            var OPDBillServiceEntity = MapperConfig.Mapper.Map<OPDBillService>(request);
            OPDBillServiceEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (OPDBillServiceEntity is null)
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
                    var newOPDBillService = await _OPDBillServiceCommandRepository.AddAsync(OPDBillServiceEntity);

                    response = new CommandResponse()
                    {
                        Id = newOPDBillService.Id,
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

    public class EditOPDBillServiceHandler : IRequestHandler<EditOPDBillServiceCommand, CommandResponse>
    {
        private readonly IOPDBillServiceCommandRepository _OPDBillServiceCommandRepository;
        private readonly IOPDBillServiceQueryRepository _OPDBillServiceQueryRepository;

        public EditOPDBillServiceHandler(IOPDBillServiceCommandRepository OPDBillServiceCommandRepository, IOPDBillServiceQueryRepository OPDBillServiceQueryRepository)
        {
            _OPDBillServiceCommandRepository = OPDBillServiceCommandRepository;
            _OPDBillServiceQueryRepository = OPDBillServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditOPDBillServiceCommand request, CancellationToken cancellationToken)
        {
            var OPDBillServiceEntity = MapperConfig.Mapper.Map<OPDBillService>(request);
            OPDBillServiceEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (OPDBillServiceEntity is null)
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
                await _OPDBillServiceCommandRepository.UpdateAsync(OPDBillServiceEntity);

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

            var modifiedOPDBillService = await _OPDBillServiceQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedOPDBillService.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteOPDBillServiceHandler : IRequestHandler<DeleteOPDBillServiceCommand, CommandResponse>
    {
        private readonly IOPDBillServiceCommandRepository _OPDBillServiceCommandRepository;
        private readonly IOPDBillServiceQueryRepository _OPDBillServiceQueryRepository;

        public DeleteOPDBillServiceHandler(IOPDBillServiceCommandRepository OPDBillServiceCommandRepository, IOPDBillServiceQueryRepository OPDBillServiceQueryRepository)
        {
            _OPDBillServiceCommandRepository = OPDBillServiceCommandRepository;
            _OPDBillServiceQueryRepository = OPDBillServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteOPDBillServiceCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var OPDBillServiceEntity = await _OPDBillServiceQueryRepository.GetByIdAsync(request.Id);

                await _OPDBillServiceCommandRepository.DeleteAsync(OPDBillServiceEntity);

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

    #region IPDRegisteration
    public class CreateIPDRegisterationHandler : IRequestHandler<CreateIPDRegisterationCommand, CommandResponse>
    {
        private readonly IIPDRegisterationCommandRepository _IPDRegisterationCommandRepository;

        public CreateIPDRegisterationHandler(IIPDRegisterationCommandRepository IPDRegisterationCommandRepository)
        {
            _IPDRegisterationCommandRepository = IPDRegisterationCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateIPDRegisterationCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationEntity = MapperConfig.Mapper.Map<IPDRegisteration>(request);
            IPDRegisterationEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationEntity is null)
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
                    var newIPDRegisteration = await _IPDRegisterationCommandRepository.AddAsync(IPDRegisterationEntity);

                    response = new CommandResponse()
                    {
                        Id = newIPDRegisteration.Id,
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

    public class EditIPDRegisterationHandler : IRequestHandler<EditIPDRegisterationCommand, CommandResponse>
    {
        private readonly IIPDRegisterationCommandRepository _IPDRegisterationCommandRepository;
        private readonly IIPDRegisterationQueryRepository _IPDRegisterationQueryRepository;

        public EditIPDRegisterationHandler(IIPDRegisterationCommandRepository IPDRegisterationCommandRepository, IIPDRegisterationQueryRepository IPDRegisterationQueryRepository)
        {
            _IPDRegisterationCommandRepository = IPDRegisterationCommandRepository;
            _IPDRegisterationQueryRepository = IPDRegisterationQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditIPDRegisterationCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationEntity = MapperConfig.Mapper.Map<IPDRegisteration>(request);
            IPDRegisterationEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationEntity is null)
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
                await _IPDRegisterationCommandRepository.UpdateAsync(IPDRegisterationEntity);

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

            var modifiedIPDRegisteration = await _IPDRegisterationQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedIPDRegisteration.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteIPDRegisterationHandler : IRequestHandler<DeleteIPDRegisterationCommand, CommandResponse>
    {
        private readonly IIPDRegisterationCommandRepository _IPDRegisterationCommandRepository;
        private readonly IIPDRegisterationQueryRepository _IPDRegisterationQueryRepository;

        public DeleteIPDRegisterationHandler(IIPDRegisterationCommandRepository IPDRegisterationCommandRepository, IIPDRegisterationQueryRepository IPDRegisterationQueryRepository)
        {
            _IPDRegisterationCommandRepository = IPDRegisterationCommandRepository;
            _IPDRegisterationQueryRepository = IPDRegisterationQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteIPDRegisterationCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var IPDRegisterationEntity = await _IPDRegisterationQueryRepository.GetByIdAsync(request.Id);

                await _IPDRegisterationCommandRepository.DeleteAsync(IPDRegisterationEntity);

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

    #region IPDRegisterationService
    public class CreateIPDRegisterationServiceHandler : IRequestHandler<CreateIPDRegisterationServiceCommand, CommandResponse>
    {
        private readonly IIPDRegisterationServiceCommandRepository _IPDRegisterationServiceCommandRepository;

        public CreateIPDRegisterationServiceHandler(IIPDRegisterationServiceCommandRepository IPDRegisterationServiceCommandRepository)
        {
            _IPDRegisterationServiceCommandRepository = IPDRegisterationServiceCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateIPDRegisterationServiceCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationServiceEntity = MapperConfig.Mapper.Map<IPDRegisterationService>(request);
            IPDRegisterationServiceEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationServiceEntity is null)
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
                    var newIPDRegisterationService = await _IPDRegisterationServiceCommandRepository.AddAsync(IPDRegisterationServiceEntity);

                    response = new CommandResponse()
                    {
                        Id = newIPDRegisterationService.Id,
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

    public class EditIPDRegisterationServiceHandler : IRequestHandler<EditIPDRegisterationServiceCommand, CommandResponse>
    {
        private readonly IIPDRegisterationServiceCommandRepository _IPDRegisterationServiceCommandRepository;
        private readonly IIPDRegisterationServiceQueryRepository _IPDRegisterationServiceQueryRepository;

        public EditIPDRegisterationServiceHandler(IIPDRegisterationServiceCommandRepository IPDRegisterationServiceCommandRepository, IIPDRegisterationServiceQueryRepository IPDRegisterationServiceQueryRepository)
        {
            _IPDRegisterationServiceCommandRepository = IPDRegisterationServiceCommandRepository;
            _IPDRegisterationServiceQueryRepository = IPDRegisterationServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditIPDRegisterationServiceCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationServiceEntity = MapperConfig.Mapper.Map<IPDRegisterationService>(request);
            IPDRegisterationServiceEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationServiceEntity is null)
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
                await _IPDRegisterationServiceCommandRepository.UpdateAsync(IPDRegisterationServiceEntity);

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

            var modifiedIPDRegisterationService = await _IPDRegisterationServiceQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedIPDRegisterationService.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteIPDRegisterationServiceHandler : IRequestHandler<DeleteIPDRegisterationServiceCommand, CommandResponse>
    {
        private readonly IIPDRegisterationServiceCommandRepository _IPDRegisterationServiceCommandRepository;
        private readonly IIPDRegisterationServiceQueryRepository _IPDRegisterationServiceQueryRepository;

        public DeleteIPDRegisterationServiceHandler(IIPDRegisterationServiceCommandRepository IPDRegisterationServiceCommandRepository, IIPDRegisterationServiceQueryRepository IPDRegisterationServiceQueryRepository)
        {
            _IPDRegisterationServiceCommandRepository = IPDRegisterationServiceCommandRepository;
            _IPDRegisterationServiceQueryRepository = IPDRegisterationServiceQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteIPDRegisterationServiceCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var IPDRegisterationServiceEntity = await _IPDRegisterationServiceQueryRepository.GetByIdAsync(request.Id);

                await _IPDRegisterationServiceCommandRepository.DeleteAsync(IPDRegisterationServiceEntity);

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

    #region IPDRegisterationRoom
    public class CreateIPDRegisterationRoomHandler : IRequestHandler<CreateIPDRegisterationRoomCommand, CommandResponse>
    {
        private readonly IIPDRegisterationRoomCommandRepository _IPDRegisterationRoomCommandRepository;

        public CreateIPDRegisterationRoomHandler(IIPDRegisterationRoomCommandRepository IPDRegisterationRoomCommandRepository)
        {
            _IPDRegisterationRoomCommandRepository = IPDRegisterationRoomCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateIPDRegisterationRoomCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationRoomEntity = MapperConfig.Mapper.Map<IPDRegisterationRoom>(request);
            IPDRegisterationRoomEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationRoomEntity is null)
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
                    var newIPDRegisterationRoom = await _IPDRegisterationRoomCommandRepository.AddAsync(IPDRegisterationRoomEntity);

                    response = new CommandResponse()
                    {
                        Id = newIPDRegisterationRoom.Id,
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

    public class EditIPDRegisterationRoomHandler : IRequestHandler<EditIPDRegisterationRoomCommand, CommandResponse>
    {
        private readonly IIPDRegisterationRoomCommandRepository _IPDRegisterationRoomCommandRepository;
        private readonly IIPDRegisterationRoomQueryRepository _IPDRegisterationRoomQueryRepository;

        public EditIPDRegisterationRoomHandler(IIPDRegisterationRoomCommandRepository IPDRegisterationRoomCommandRepository, IIPDRegisterationRoomQueryRepository IPDRegisterationRoomQueryRepository)
        {
            _IPDRegisterationRoomCommandRepository = IPDRegisterationRoomCommandRepository;
            _IPDRegisterationRoomQueryRepository = IPDRegisterationRoomQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditIPDRegisterationRoomCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationRoomEntity = MapperConfig.Mapper.Map<IPDRegisterationRoom>(request);
            IPDRegisterationRoomEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationRoomEntity is null)
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
                await _IPDRegisterationRoomCommandRepository.UpdateAsync(IPDRegisterationRoomEntity);

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

            var modifiedIPDRegisterationRoom = await _IPDRegisterationRoomQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedIPDRegisterationRoom.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteIPDRegisterationRoomHandler : IRequestHandler<DeleteIPDRegisterationRoomCommand, CommandResponse>
    {
        private readonly IIPDRegisterationRoomCommandRepository _IPDRegisterationRoomCommandRepository;
        private readonly IIPDRegisterationRoomQueryRepository _IPDRegisterationRoomQueryRepository;

        public DeleteIPDRegisterationRoomHandler(IIPDRegisterationRoomCommandRepository IPDRegisterationRoomCommandRepository, IIPDRegisterationRoomQueryRepository IPDRegisterationRoomQueryRepository)
        {
            _IPDRegisterationRoomCommandRepository = IPDRegisterationRoomCommandRepository;
            _IPDRegisterationRoomQueryRepository = IPDRegisterationRoomQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteIPDRegisterationRoomCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var IPDRegisterationRoomEntity = await _IPDRegisterationRoomQueryRepository.GetByIdAsync(request.Id);

                await _IPDRegisterationRoomCommandRepository.DeleteAsync(IPDRegisterationRoomEntity);

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

    #region IPDRegisterationPayment
    public class CreateIPDRegisterationPaymentHandler : IRequestHandler<CreateIPDRegisterationPaymentCommand, CommandResponse>
    {
        private readonly IIPDRegisterationPaymentCommandRepository _IPDRegisterationPaymentCommandRepository;

        public CreateIPDRegisterationPaymentHandler(IIPDRegisterationPaymentCommandRepository IPDRegisterationPaymentCommandRepository)
        {
            _IPDRegisterationPaymentCommandRepository = IPDRegisterationPaymentCommandRepository;
        }

        public async Task<CommandResponse> Handle(CreateIPDRegisterationPaymentCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationPaymentEntity = MapperConfig.Mapper.Map<IPDRegisterationPayment>(request);
            IPDRegisterationPaymentEntity.CreatedDate = DateTime.Now;

            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationPaymentEntity is null)
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
                    var newIPDRegisterationPayment = await _IPDRegisterationPaymentCommandRepository.AddAsync(IPDRegisterationPaymentEntity);

                    response = new CommandResponse()
                    {
                        Id = newIPDRegisterationPayment.Id,
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

    public class EditIPDRegisterationPaymentHandler : IRequestHandler<EditIPDRegisterationPaymentCommand, CommandResponse>
    {
        private readonly IIPDRegisterationPaymentCommandRepository _IPDRegisterationPaymentCommandRepository;
        private readonly IIPDRegisterationPaymentQueryRepository _IPDRegisterationPaymentQueryRepository;

        public EditIPDRegisterationPaymentHandler(IIPDRegisterationPaymentCommandRepository IPDRegisterationPaymentCommandRepository, IIPDRegisterationPaymentQueryRepository IPDRegisterationPaymentQueryRepository)
        {
            _IPDRegisterationPaymentCommandRepository = IPDRegisterationPaymentCommandRepository;
            _IPDRegisterationPaymentQueryRepository = IPDRegisterationPaymentQueryRepository;
        }

        public async Task<CommandResponse> Handle(EditIPDRegisterationPaymentCommand request, CancellationToken cancellationToken)
        {
            var IPDRegisterationPaymentEntity = MapperConfig.Mapper.Map<IPDRegisterationPayment>(request);
            IPDRegisterationPaymentEntity.ModifiedDate = DateTime.Now;
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            if (IPDRegisterationPaymentEntity is null)
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
                await _IPDRegisterationPaymentCommandRepository.UpdateAsync(IPDRegisterationPaymentEntity);

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

            var modifiedIPDRegisterationPayment = await _IPDRegisterationPaymentQueryRepository.GetByIdAsync(request.Id);

            response = new CommandResponse()
            {
                Id = modifiedIPDRegisterationPayment.Id,
                ResultType = ResultType.Success,
                ResultMessage = "Updated successfully"
            };

            return response;
        }
    }

    public class DeleteIPDRegisterationPaymentHandler : IRequestHandler<DeleteIPDRegisterationPaymentCommand, CommandResponse>
    {
        private readonly IIPDRegisterationPaymentCommandRepository _IPDRegisterationPaymentCommandRepository;
        private readonly IIPDRegisterationPaymentQueryRepository _IPDRegisterationPaymentQueryRepository;

        public DeleteIPDRegisterationPaymentHandler(IIPDRegisterationPaymentCommandRepository IPDRegisterationPaymentCommandRepository, IIPDRegisterationPaymentQueryRepository IPDRegisterationPaymentQueryRepository)
        {
            _IPDRegisterationPaymentCommandRepository = IPDRegisterationPaymentCommandRepository;
            _IPDRegisterationPaymentQueryRepository = IPDRegisterationPaymentQueryRepository;
        }

        public async Task<CommandResponse> Handle(DeleteIPDRegisterationPaymentCommand request, CancellationToken cancellationToken)
        {
            CommandResponse response = new CommandResponse()
            {
                Id = 0,
                ResultType = ResultType.None,
                ResultMessage = "Unknown"
            };

            try
            {
                var IPDRegisterationPaymentEntity = await _IPDRegisterationPaymentQueryRepository.GetByIdAsync(request.Id);

                await _IPDRegisterationPaymentCommandRepository.DeleteAsync(IPDRegisterationPaymentEntity);

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
