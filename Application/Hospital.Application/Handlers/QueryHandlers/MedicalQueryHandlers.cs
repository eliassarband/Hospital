﻿using Hospital.Application.Mapper;
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



}