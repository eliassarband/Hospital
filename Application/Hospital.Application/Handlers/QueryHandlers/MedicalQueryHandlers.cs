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

    #region Insurance

    public class GetAllInsurancesHandler : IRequestHandler<GetAllInsurancesQuery, List<InsuranceViewModel>>
    {
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public GetAllInsurancesHandler(IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<List<InsuranceViewModel>> Handle(GetAllInsurancesQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<Insurance>)await _InsuranceQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<InsuranceViewModel>>(BIs);
        }
    }

    public class GetInsurancesByPaymentTypeHandler : IRequestHandler<GetInsurancesByPaymentTypeQuery, List<InsuranceViewModel>>
    {
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public GetInsurancesByPaymentTypeHandler(IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<List<InsuranceViewModel>> Handle(GetInsurancesByPaymentTypeQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<Insurance>)await _InsuranceQueryRepository.GetByPaymentTypeAsync(request.PaymentTypeId);

            return MapperConfig.Mapper.Map<List<InsuranceViewModel>>(BIs);
        }
    }

    public class GetInsuranceByIdHandler : IRequestHandler<GetInsuranceByIdQuery, InsuranceViewModel>
    {
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public GetInsuranceByIdHandler(IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<InsuranceViewModel> Handle(GetInsuranceByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<InsuranceViewModel>(await _InsuranceQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetInsuranceByCodeHandler : IRequestHandler<GetInsuranceByCodeQuery, InsuranceViewModel>
    {
        private readonly IInsuranceQueryRepository _InsuranceQueryRepository;

        public GetInsuranceByCodeHandler(IInsuranceQueryRepository InsuranceQueryRepository)
        {
            _InsuranceQueryRepository = InsuranceQueryRepository;
        }

        public async Task<InsuranceViewModel> Handle(GetInsuranceByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<InsuranceViewModel>(await _InsuranceQueryRepository.GetByCodeAsync(request.Code));
        }
    }


    #endregion

    #region InsuranceAgreement

    public class GetAllInsuranceAgreementsHandler : IRequestHandler<GetAllInsuranceAgreementsQuery, List<InsuranceAgreementViewModel>>
    {
        private readonly IInsuranceAgreementQueryRepository _InsuranceAgreementQueryRepository;

        public GetAllInsuranceAgreementsHandler(IInsuranceAgreementQueryRepository InsuranceAgreementQueryRepository)
        {
            _InsuranceAgreementQueryRepository = InsuranceAgreementQueryRepository;
        }

        public async Task<List<InsuranceAgreementViewModel>> Handle(GetAllInsuranceAgreementsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<InsuranceAgreement>)await _InsuranceAgreementQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<InsuranceAgreementViewModel>>(BIs);
        }
    }

    public class GetInsuranceAgreementsByInsuranceIdHandler : IRequestHandler<GetInsuranceAgreementsByInsuranceIdQuery, List<InsuranceAgreementViewModel>>
    {
        private readonly IInsuranceAgreementQueryRepository _InsuranceAgreementQueryRepository;

        public GetInsuranceAgreementsByInsuranceIdHandler(IInsuranceAgreementQueryRepository InsuranceAgreementQueryRepository)
        {
            _InsuranceAgreementQueryRepository = InsuranceAgreementQueryRepository;
        }

        public async Task<List<InsuranceAgreementViewModel>> Handle(GetInsuranceAgreementsByInsuranceIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<InsuranceAgreement>)await _InsuranceAgreementQueryRepository.GetByInsuranceIdAsync(request.InsuranceId);

            return MapperConfig.Mapper.Map<List<InsuranceAgreementViewModel>>(BIs);
        }
    }

    public class GetInsuranceAgreementByIdHandler : IRequestHandler<GetInsuranceAgreementByIdQuery, InsuranceAgreementViewModel>
    {
        private readonly IInsuranceAgreementQueryRepository _InsuranceAgreementQueryRepository;

        public GetInsuranceAgreementByIdHandler(IInsuranceAgreementQueryRepository InsuranceAgreementQueryRepository)
        {
            _InsuranceAgreementQueryRepository = InsuranceAgreementQueryRepository;
        }

        public async Task<InsuranceAgreementViewModel> Handle(GetInsuranceAgreementByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<InsuranceAgreementViewModel>(await _InsuranceAgreementQueryRepository.GetByIdAsync(request.Id));
        }
    }


    #endregion

    #region Staff

    public class GetAllStaffsHandler : IRequestHandler<GetAllStaffsQuery, List<StaffViewModel>>
    {
        private readonly IStaffQueryRepository _StaffQueryRepository;

        public GetAllStaffsHandler(IStaffQueryRepository StaffQueryRepository)
        {
            _StaffQueryRepository = StaffQueryRepository;
        }

        public async Task<List<StaffViewModel>> Handle(GetAllStaffsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<Staff>)await _StaffQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<StaffViewModel>>(BIs);
        }
    }

    public class GetStaffsByStaffTypeIdHandler : IRequestHandler<GetStaffsByStaffTypeIdQuery, List<StaffViewModel>>
    {
        private readonly IStaffQueryRepository _StaffQueryRepository;

        public GetStaffsByStaffTypeIdHandler(IStaffQueryRepository StaffQueryRepository)
        {
            _StaffQueryRepository = StaffQueryRepository;
        }

        public async Task<List<StaffViewModel>> Handle(GetStaffsByStaffTypeIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<Staff>)await _StaffQueryRepository.GetByStaffTypeIdAsync(request.StaffTypeId);

            return MapperConfig.Mapper.Map<List<StaffViewModel>>(BIs);
        }
    }

    public class GetStaffByIdHandler : IRequestHandler<GetStaffByIdQuery, StaffViewModel>
    {
        private readonly IStaffQueryRepository _StaffQueryRepository;

        public GetStaffByIdHandler(IStaffQueryRepository StaffQueryRepository)
        {
            _StaffQueryRepository = StaffQueryRepository;
        }

        public async Task<StaffViewModel> Handle(GetStaffByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<StaffViewModel>(await _StaffQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region StaffTiming

    public class GetAllStaffTimingsHandler : IRequestHandler<GetAllStaffTimingsQuery, List<StaffTimingViewModel>>
    {
        private readonly IStaffTimingQueryRepository _StaffTimingQueryRepository;

        public GetAllStaffTimingsHandler(IStaffTimingQueryRepository StaffTimingQueryRepository)
        {
            _StaffTimingQueryRepository = StaffTimingQueryRepository;
        }

        public async Task<List<StaffTimingViewModel>> Handle(GetAllStaffTimingsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<StaffTiming>)await _StaffTimingQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<StaffTimingViewModel>>(BIs);
        }
    }

    public class GetStaffTimingsByStaffIdHandler : IRequestHandler<GetStaffTimingsByStaffIdQuery, List<StaffTimingViewModel>>
    {
        private readonly IStaffTimingQueryRepository _StaffTimingQueryRepository;

        public GetStaffTimingsByStaffIdHandler(IStaffTimingQueryRepository StaffTimingQueryRepository)
        {
            _StaffTimingQueryRepository = StaffTimingQueryRepository;
        }

        public async Task<List<StaffTimingViewModel>> Handle(GetStaffTimingsByStaffIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<StaffTiming>)await _StaffTimingQueryRepository.GetByStaffIdAsync(request.StaffId);

            return MapperConfig.Mapper.Map<List<StaffTimingViewModel>>(BIs);
        }
    }

    public class GetStaffTimingByIdHandler : IRequestHandler<GetStaffTimingByIdQuery, StaffTimingViewModel>
    {
        private readonly IStaffTimingQueryRepository _StaffTimingQueryRepository;

        public GetStaffTimingByIdHandler(IStaffTimingQueryRepository StaffTimingQueryRepository)
        {
            _StaffTimingQueryRepository = StaffTimingQueryRepository;
        }

        public async Task<StaffTimingViewModel> Handle(GetStaffTimingByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<StaffTimingViewModel>(await _StaffTimingQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region RefferBy

    public class GetAllRefferBiesHandler : IRequestHandler<GetAllRefferBiesQuery, List<RefferByViewModel>>
    {
        private readonly IRefferByQueryRepository _RefferByQueryRepository;

        public GetAllRefferBiesHandler(IRefferByQueryRepository RefferByQueryRepository)
        {
            _RefferByQueryRepository = RefferByQueryRepository;
        }

        public async Task<List<RefferByViewModel>> Handle(GetAllRefferBiesQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<RefferBy>)await _RefferByQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RefferByViewModel>>(BIs);
        }
    }

    public class GetRefferBiesByStaffTypeIdHandler : IRequestHandler<GetRefferBiesByStaffTypeIdQuery, List<RefferByViewModel>>
    {
        private readonly IRefferByQueryRepository _RefferByQueryRepository;

        public GetRefferBiesByStaffTypeIdHandler(IRefferByQueryRepository RefferByQueryRepository)
        {
            _RefferByQueryRepository = RefferByQueryRepository;
        }

        public async Task<List<RefferByViewModel>> Handle(GetRefferBiesByStaffTypeIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<RefferBy>)await _RefferByQueryRepository.GetByStaffTypeIdAsync(request.StaffTypeId);

            return MapperConfig.Mapper.Map<List<RefferByViewModel>>(BIs);
        }
    }

    public class GetRefferByByIdHandler : IRequestHandler<GetRefferByByIdQuery, RefferByViewModel>
    {
        private readonly IRefferByQueryRepository _RefferByQueryRepository;

        public GetRefferByByIdHandler(IRefferByQueryRepository RefferByQueryRepository)
        {
            _RefferByQueryRepository = RefferByQueryRepository;
        }

        public async Task<RefferByViewModel> Handle(GetRefferByByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RefferByViewModel>(await _RefferByQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region Patient

    public class GetAllPatientsHandler : IRequestHandler<GetAllPatientsQuery, List<PatientViewModel>>
    {
        private readonly IPatientQueryRepository _PatientQueryRepository;

        public GetAllPatientsHandler(IPatientQueryRepository PatientQueryRepository)
        {
            _PatientQueryRepository = PatientQueryRepository;
        }

        public async Task<List<PatientViewModel>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<Patient>)await _PatientQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<PatientViewModel>>(BIs);
        }
    }

    public class GetPatientByIdHandler : IRequestHandler<GetPatientByIdQuery, PatientViewModel>
    {
        private readonly IPatientQueryRepository _PatientQueryRepository;

        public GetPatientByIdHandler(IPatientQueryRepository PatientQueryRepository)
        {
            _PatientQueryRepository = PatientQueryRepository;
        }

        public async Task<PatientViewModel> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<PatientViewModel>(await _PatientQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetPatientByNationalIdHandler : IRequestHandler<GetPatientByNationalIdQuery, PatientViewModel>
    {
        private readonly IPatientQueryRepository _PatientQueryRepository;

        public GetPatientByNationalIdHandler(IPatientQueryRepository PatientQueryRepository)
        {
            _PatientQueryRepository = PatientQueryRepository;
        }

        public async Task<PatientViewModel> Handle(GetPatientByNationalIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<PatientViewModel>(await _PatientQueryRepository.GetByNationalIdAsync(request.NationalId));
        }
    }

    #endregion

    #region OPDBill

    public class GetAllOPDBillsHandler : IRequestHandler<GetAllOPDBillsQuery, List<OPDBillViewModel>>
    {
        private readonly IOPDBillQueryRepository _OPDBillQueryRepository;

        public GetAllOPDBillsHandler(IOPDBillQueryRepository OPDBillQueryRepository)
        {
            _OPDBillQueryRepository = OPDBillQueryRepository;
        }

        public async Task<List<OPDBillViewModel>> Handle(GetAllOPDBillsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<OPDBill>)await _OPDBillQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<OPDBillViewModel>>(BIs);
        }
    }

    public class GetOPDBillByIdHandler : IRequestHandler<GetOPDBillByIdQuery, OPDBillViewModel>
    {
        private readonly IOPDBillQueryRepository _OPDBillQueryRepository;

        public GetOPDBillByIdHandler(IOPDBillQueryRepository OPDBillQueryRepository)
        {
            _OPDBillQueryRepository = OPDBillQueryRepository;
        }

        public async Task<OPDBillViewModel> Handle(GetOPDBillByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<OPDBillViewModel>(await _OPDBillQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region OPDBillService

    public class GetAllOPDBillServicesHandler : IRequestHandler<GetAllOPDBillServicesQuery, List<OPDBillServiceViewModel>>
    {
        private readonly IOPDBillServiceQueryRepository _OPDBillServiceQueryRepository;

        public GetAllOPDBillServicesHandler(IOPDBillServiceQueryRepository OPDBillServiceQueryRepository)
        {
            _OPDBillServiceQueryRepository = OPDBillServiceQueryRepository;
        }

        public async Task<List<OPDBillServiceViewModel>> Handle(GetAllOPDBillServicesQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<OPDBillService>)await _OPDBillServiceQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<OPDBillServiceViewModel>>(BIs);
        }
    }

    public class GetOPDBillServicesByOPDBillIdHandler : IRequestHandler<GetOPDBillServicesByOPDBillIdQuery, List<OPDBillServiceViewModel>>
    {
        private readonly IOPDBillServiceQueryRepository _OPDBillServiceQueryRepository;

        public GetOPDBillServicesByOPDBillIdHandler(IOPDBillServiceQueryRepository OPDBillServiceQueryRepository)
        {
            _OPDBillServiceQueryRepository = OPDBillServiceQueryRepository;
        }

        public async Task<List<OPDBillServiceViewModel>> Handle(GetOPDBillServicesByOPDBillIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<OPDBillService>)await _OPDBillServiceQueryRepository.GetByOPDBillIdAsync(request.OPDBillId);

            return MapperConfig.Mapper.Map<List<OPDBillServiceViewModel>>(BIs);
        }
    }

    public class GetOPDBillServiceByIdHandler : IRequestHandler<GetOPDBillServiceByIdQuery, OPDBillServiceViewModel>
    {
        private readonly IOPDBillServiceQueryRepository _OPDBillServiceQueryRepository;

        public GetOPDBillServiceByIdHandler(IOPDBillServiceQueryRepository OPDBillServiceQueryRepository)
        {
            _OPDBillServiceQueryRepository = OPDBillServiceQueryRepository;
        }

        public async Task<OPDBillServiceViewModel> Handle(GetOPDBillServiceByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<OPDBillServiceViewModel>(await _OPDBillServiceQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region IPDRegisteration

    public class GetAllIPDRegisterationsHandler : IRequestHandler<GetAllIPDRegisterationsQuery, List<IPDRegisterationViewModel>>
    {
        private readonly IIPDRegisterationQueryRepository _IPDRegisterationQueryRepository;

        public GetAllIPDRegisterationsHandler(IIPDRegisterationQueryRepository IPDRegisterationQueryRepository)
        {
            _IPDRegisterationQueryRepository = IPDRegisterationQueryRepository;
        }

        public async Task<List<IPDRegisterationViewModel>> Handle(GetAllIPDRegisterationsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisteration>)await _IPDRegisterationQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<IPDRegisterationViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationByIdHandler : IRequestHandler<GetIPDRegisterationByIdQuery, IPDRegisterationViewModel>
    {
        private readonly IIPDRegisterationQueryRepository _IPDRegisterationQueryRepository;

        public GetIPDRegisterationByIdHandler(IIPDRegisterationQueryRepository IPDRegisterationQueryRepository)
        {
            _IPDRegisterationQueryRepository = IPDRegisterationQueryRepository;
        }

        public async Task<IPDRegisterationViewModel> Handle(GetIPDRegisterationByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<IPDRegisterationViewModel>(await _IPDRegisterationQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region IPDRegisterationService

    public class GetAllIPDRegisterationServicesHandler : IRequestHandler<GetAllIPDRegisterationServicesQuery, List<IPDRegisterationServiceViewModel>>
    {
        private readonly IIPDRegisterationServiceQueryRepository _IPDRegisterationServiceQueryRepository;

        public GetAllIPDRegisterationServicesHandler(IIPDRegisterationServiceQueryRepository IPDRegisterationServiceQueryRepository)
        {
            _IPDRegisterationServiceQueryRepository = IPDRegisterationServiceQueryRepository;
        }

        public async Task<List<IPDRegisterationServiceViewModel>> Handle(GetAllIPDRegisterationServicesQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationService>)await _IPDRegisterationServiceQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<IPDRegisterationServiceViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationServicesByIPDRegisterationIdHandler : IRequestHandler<GetIPDRegisterationServicesByIPDRegisterationIdQuery, List<IPDRegisterationServiceViewModel>>
    {
        private readonly IIPDRegisterationServiceQueryRepository _IPDRegisterationServiceQueryRepository;

        public GetIPDRegisterationServicesByIPDRegisterationIdHandler(IIPDRegisterationServiceQueryRepository IPDRegisterationServiceQueryRepository)
        {
            _IPDRegisterationServiceQueryRepository = IPDRegisterationServiceQueryRepository;
        }

        public async Task<List<IPDRegisterationServiceViewModel>> Handle(GetIPDRegisterationServicesByIPDRegisterationIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationService>)await _IPDRegisterationServiceQueryRepository.GetByIPDRegisterationIdAsync(request.IPDRegisterationId);

            return MapperConfig.Mapper.Map<List<IPDRegisterationServiceViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationServiceByIdHandler : IRequestHandler<GetIPDRegisterationServiceByIdQuery, IPDRegisterationServiceViewModel>
    {
        private readonly IIPDRegisterationServiceQueryRepository _IPDRegisterationServiceQueryRepository;

        public GetIPDRegisterationServiceByIdHandler(IIPDRegisterationServiceQueryRepository IPDRegisterationServiceQueryRepository)
        {
            _IPDRegisterationServiceQueryRepository = IPDRegisterationServiceQueryRepository;
        }

        public async Task<IPDRegisterationServiceViewModel> Handle(GetIPDRegisterationServiceByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<IPDRegisterationServiceViewModel>(await _IPDRegisterationServiceQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region IPDRegisterationRoom

    public class GetAllIPDRegisterationRoomsHandler : IRequestHandler<GetAllIPDRegisterationRoomsQuery, List<IPDRegisterationRoomViewModel>>
    {
        private readonly IIPDRegisterationRoomQueryRepository _IPDRegisterationRoomQueryRepository;

        public GetAllIPDRegisterationRoomsHandler(IIPDRegisterationRoomQueryRepository IPDRegisterationRoomQueryRepository)
        {
            _IPDRegisterationRoomQueryRepository = IPDRegisterationRoomQueryRepository;
        }

        public async Task<List<IPDRegisterationRoomViewModel>> Handle(GetAllIPDRegisterationRoomsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationRoom>)await _IPDRegisterationRoomQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<IPDRegisterationRoomViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationRoomsByIPDRegisterationIdHandler : IRequestHandler<GetIPDRegisterationRoomsByIPDRegisterationIdQuery, List<IPDRegisterationRoomViewModel>>
    {
        private readonly IIPDRegisterationRoomQueryRepository _IPDRegisterationRoomQueryRepository;

        public GetIPDRegisterationRoomsByIPDRegisterationIdHandler(IIPDRegisterationRoomQueryRepository IPDRegisterationRoomQueryRepository)
        {
            _IPDRegisterationRoomQueryRepository = IPDRegisterationRoomQueryRepository;
        }

        public async Task<List<IPDRegisterationRoomViewModel>> Handle(GetIPDRegisterationRoomsByIPDRegisterationIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationRoom>)await _IPDRegisterationRoomQueryRepository.GetByIPDRegisterationIdAsync(request.IPDRegisterationId);

            return MapperConfig.Mapper.Map<List<IPDRegisterationRoomViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationRoomByIdHandler : IRequestHandler<GetIPDRegisterationRoomByIdQuery, IPDRegisterationRoomViewModel>
    {
        private readonly IIPDRegisterationRoomQueryRepository _IPDRegisterationRoomQueryRepository;

        public GetIPDRegisterationRoomByIdHandler(IIPDRegisterationRoomQueryRepository IPDRegisterationRoomQueryRepository)
        {
            _IPDRegisterationRoomQueryRepository = IPDRegisterationRoomQueryRepository;
        }

        public async Task<IPDRegisterationRoomViewModel> Handle(GetIPDRegisterationRoomByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<IPDRegisterationRoomViewModel>(await _IPDRegisterationRoomQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region IPDRegisterationPayment

    public class GetAllIPDRegisterationPaymentsHandler : IRequestHandler<GetAllIPDRegisterationPaymentsQuery, List<IPDRegisterationPaymentViewModel>>
    {
        private readonly IIPDRegisterationPaymentQueryRepository _IPDRegisterationPaymentQueryRepository;

        public GetAllIPDRegisterationPaymentsHandler(IIPDRegisterationPaymentQueryRepository IPDRegisterationPaymentQueryRepository)
        {
            _IPDRegisterationPaymentQueryRepository = IPDRegisterationPaymentQueryRepository;
        }

        public async Task<List<IPDRegisterationPaymentViewModel>> Handle(GetAllIPDRegisterationPaymentsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationPayment>)await _IPDRegisterationPaymentQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<IPDRegisterationPaymentViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationPaymentsByIPDRegisterationIdHandler : IRequestHandler<GetIPDRegisterationPaymentsByIPDRegisterationIdQuery, List<IPDRegisterationPaymentViewModel>>
    {
        private readonly IIPDRegisterationPaymentQueryRepository _IPDRegisterationPaymentQueryRepository;

        public GetIPDRegisterationPaymentsByIPDRegisterationIdHandler(IIPDRegisterationPaymentQueryRepository IPDRegisterationPaymentQueryRepository)
        {
            _IPDRegisterationPaymentQueryRepository = IPDRegisterationPaymentQueryRepository;
        }

        public async Task<List<IPDRegisterationPaymentViewModel>> Handle(GetIPDRegisterationPaymentsByIPDRegisterationIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<IPDRegisterationPayment>)await _IPDRegisterationPaymentQueryRepository.GetByIPDRegisterationIdAsync(request.IPDRegisterationId);

            return MapperConfig.Mapper.Map<List<IPDRegisterationPaymentViewModel>>(BIs);
        }
    }

    public class GetIPDRegisterationPaymentByIdHandler : IRequestHandler<GetIPDRegisterationPaymentByIdQuery, IPDRegisterationPaymentViewModel>
    {
        private readonly IIPDRegisterationPaymentQueryRepository _IPDRegisterationPaymentQueryRepository;

        public GetIPDRegisterationPaymentByIdHandler(IIPDRegisterationPaymentQueryRepository IPDRegisterationPaymentQueryRepository)
        {
            _IPDRegisterationPaymentQueryRepository = IPDRegisterationPaymentQueryRepository;
        }

        public async Task<IPDRegisterationPaymentViewModel> Handle(GetIPDRegisterationPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<IPDRegisterationPaymentViewModel>(await _IPDRegisterationPaymentQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region OPDBillPayment

    public class GetAllOPDBillPaymentsHandler : IRequestHandler<GetAllOPDBillPaymentsQuery, List<OPDBillPaymentViewModel>>
    {
        private readonly IOPDBillPaymentQueryRepository _OPDBillPaymentQueryRepository;

        public GetAllOPDBillPaymentsHandler(IOPDBillPaymentQueryRepository OPDBillPaymentQueryRepository)
        {
            _OPDBillPaymentQueryRepository = OPDBillPaymentQueryRepository;
        }

        public async Task<List<OPDBillPaymentViewModel>> Handle(GetAllOPDBillPaymentsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<OPDBillPayment>)await _OPDBillPaymentQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<OPDBillPaymentViewModel>>(BIs);
        }
    }

    public class GetOPDBillPaymentsByOPDBillIdHandler : IRequestHandler<GetOPDBillPaymentsByOPDBillIdQuery, List<OPDBillPaymentViewModel>>
    {
        private readonly IOPDBillPaymentQueryRepository _OPDBillPaymentQueryRepository;

        public GetOPDBillPaymentsByOPDBillIdHandler(IOPDBillPaymentQueryRepository OPDBillPaymentQueryRepository)
        {
            _OPDBillPaymentQueryRepository = OPDBillPaymentQueryRepository;
        }

        public async Task<List<OPDBillPaymentViewModel>> Handle(GetOPDBillPaymentsByOPDBillIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<OPDBillPayment>)await _OPDBillPaymentQueryRepository.GetByOPDBillIdAsync(request.OPDBillId);

            return MapperConfig.Mapper.Map<List<OPDBillPaymentViewModel>>(BIs);
        }
    }

    public class GetOPDBillPaymentByIdHandler : IRequestHandler<GetOPDBillPaymentByIdQuery, OPDBillPaymentViewModel>
    {
        private readonly IOPDBillPaymentQueryRepository _OPDBillPaymentQueryRepository;

        public GetOPDBillPaymentByIdHandler(IOPDBillPaymentQueryRepository OPDBillPaymentQueryRepository)
        {
            _OPDBillPaymentQueryRepository = OPDBillPaymentQueryRepository;
        }

        public async Task<OPDBillPaymentViewModel> Handle(GetOPDBillPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<OPDBillPaymentViewModel>(await _OPDBillPaymentQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion
}
