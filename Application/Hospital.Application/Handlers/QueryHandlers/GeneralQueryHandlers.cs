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
    #region BasicInformationCategory

    public class GetAllBasicInformationCategoriesHandler : IRequestHandler<GetAllBasicInformationCategoriesQuery, List<BasicInformationCategoryViewModel>>
    {
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public GetAllBasicInformationCategoriesHandler(IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<List<BasicInformationCategoryViewModel>> Handle(GetAllBasicInformationCategoriesQuery request, CancellationToken cancellationToken)
        {
            var BICs = (List<BasicInformationCategory>)await _BasicInformationCategoryQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<BasicInformationCategoryViewModel>>(BICs);
        }
    }

    public class GetViewableBasicInformationCategoriesHandler : IRequestHandler<GetViewableBasicInformationCategoriesQuery, List<BasicInformationCategoryViewModel>>
    {
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public GetViewableBasicInformationCategoriesHandler(IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<List<BasicInformationCategoryViewModel>> Handle(GetViewableBasicInformationCategoriesQuery request, CancellationToken cancellationToken)
        {
            var BICs = (List<BasicInformationCategory>)await _BasicInformationCategoryQueryRepository.GetViewablesAsync(request.Viewable);

            return MapperConfig.Mapper.Map<List<BasicInformationCategoryViewModel>>(BICs);
        }
    }

    public class GetBasicInformationCategoriesByRelatedCategoryIdHandler : IRequestHandler<GetBasicInformationCategoriesByRelatedCategoryIdQuery, List<BasicInformationCategoryViewModel>>
    {
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public GetBasicInformationCategoriesByRelatedCategoryIdHandler(IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<List<BasicInformationCategoryViewModel>> Handle(GetBasicInformationCategoriesByRelatedCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var BICs = (List<BasicInformationCategory>)await _BasicInformationCategoryQueryRepository.GetByRelatedCategoryIdAsync(request.CategoryId);

            return MapperConfig.Mapper.Map<List<BasicInformationCategoryViewModel>>(BICs);
        }
    }

    public class GetBasicInformationCategoryByIdHandler : IRequestHandler<GetBasicInformationCategoryByIdQuery, BasicInformationCategoryViewModel>
    {
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public GetBasicInformationCategoryByIdHandler(IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<BasicInformationCategoryViewModel> Handle(GetBasicInformationCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BasicInformationCategoryViewModel>(await _BasicInformationCategoryQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetBasicInformationCategoryByCodeHandler : IRequestHandler<GetBasicInformationCategoryByCodeQuery, BasicInformationCategoryViewModel>
    {
        private readonly IBasicInformationCategoryQueryRepository _BasicInformationCategoryQueryRepository;

        public GetBasicInformationCategoryByCodeHandler(IBasicInformationCategoryQueryRepository BSCategoryQueryRepository)
        {
            _BasicInformationCategoryQueryRepository = BSCategoryQueryRepository;
        }

        public async Task<BasicInformationCategoryViewModel> Handle(GetBasicInformationCategoryByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BasicInformationCategoryViewModel>(await _BasicInformationCategoryQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    #endregion

    #region BasicInformation

    public class GetAllBasicInformationsHandler : IRequestHandler<GetAllBasicInformationsQuery, List<BasicInformationViewModel>>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetAllBasicInformationsHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<List<BasicInformationViewModel>> Handle(GetAllBasicInformationsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<BasicInformation>)await _BasicInformationQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<BasicInformationViewModel>>(BIs);
        }
    }

    public class GetBasicInformationsByCategoryIdHandler : IRequestHandler<GetBasicInformationsByCategoryIdQuery, List<BasicInformationViewModel>>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationsByCategoryIdHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<List<BasicInformationViewModel>> Handle(GetBasicInformationsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<BasicInformation>)await _BasicInformationQueryRepository.GetByCategoryIdAsync(request.CategoryId);

            return MapperConfig.Mapper.Map<List<BasicInformationViewModel>>(BIs);
        }
    }

    public class GetBasicInformationsByCategoryCodeHandler : IRequestHandler<GetBasicInformationsByCategoryCodeQuery, List<BasicInformationViewModel>>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationsByCategoryCodeHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<List<BasicInformationViewModel>> Handle(GetBasicInformationsByCategoryCodeQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<BasicInformation>)await _BasicInformationQueryRepository.GetByCategoryCodeAsync(request.CategoryCode);

            return MapperConfig.Mapper.Map<List<BasicInformationViewModel>>(BIs);
        }
    }

    public class GetActiveBasicInformationsHandler : IRequestHandler<GetActiveBasicInformationsQuery, List<BasicInformationViewModel>>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetActiveBasicInformationsHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<List<BasicInformationViewModel>> Handle(GetActiveBasicInformationsQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<BasicInformation>)await _BasicInformationQueryRepository.GetByActiveAsync(request.Active);

            return MapperConfig.Mapper.Map<List<BasicInformationViewModel>>(BIs);
        }
    }

    public class GetBasicInformationsByRelatedBasicInformationIdHandler : IRequestHandler<GetBasicInformationsByRelatedBasicInformationIdQuery, List<BasicInformationViewModel>>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationsByRelatedBasicInformationIdHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<List<BasicInformationViewModel>> Handle(GetBasicInformationsByRelatedBasicInformationIdQuery request, CancellationToken cancellationToken)
        {
            var BIs = (List<BasicInformation>)await _BasicInformationQueryRepository.GetByRelatedBasicInformationIdAsync(request.BasicInformationId);

            return MapperConfig.Mapper.Map<List<BasicInformationViewModel>>(BIs);
        }
    }

    public class GetBasicInformationByIdHandler : IRequestHandler<GetBasicInformationByIdQuery, BasicInformationViewModel>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationByIdHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<BasicInformationViewModel> Handle(GetBasicInformationByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BasicInformationViewModel>(await _BasicInformationQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetBasicInformationByCodeHandler : IRequestHandler<GetBasicInformationByCodeQuery, BasicInformationViewModel>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationByCodeHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<BasicInformationViewModel> Handle(GetBasicInformationByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BasicInformationViewModel>(await _BasicInformationQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetBasicInformationByStrCodeHandler : IRequestHandler<GetBasicInformationByStrCodeQuery, BasicInformationViewModel>
    {
        private readonly IBasicInformationQueryRepository _BasicInformationQueryRepository;

        public GetBasicInformationByStrCodeHandler(IBasicInformationQueryRepository BasicInformationQueryRepository)
        {
            _BasicInformationQueryRepository = BasicInformationQueryRepository;
        }

        public async Task<BasicInformationViewModel> Handle(GetBasicInformationByStrCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BasicInformationViewModel>(await _BasicInformationQueryRepository.GetByStrCodeAsync(request.StrCode));
        }
    }

    #endregion

    #region Department

    public class GetAllDepartmentsHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentViewModel>>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetAllDepartmentsHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<List<DepartmentViewModel>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            List<Department> Departments = (List<Department>)await _DepartmentQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<DepartmentViewModel>>(Departments);
        }
    }

    public class GetAllDepartmentsByMainDepartmentIdHandler : IRequestHandler<GetAllDepartmentsByMainDepartmentIdQuery, List<DepartmentViewModel>>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetAllDepartmentsByMainDepartmentIdHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<List<DepartmentViewModel>> Handle(GetAllDepartmentsByMainDepartmentIdQuery request, CancellationToken cancellationToken)
        {
            List<Department> Departments = (List<Department>)await _DepartmentQueryRepository.GetByMainDepartmentIdAsync(request.DepartmentId);

            return MapperConfig.Mapper.Map<List<DepartmentViewModel>>(Departments);
        }
    }


    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByIdHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetDepartmentByCodeHandler : IRequestHandler<GetDepartmentByCodeQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByCodeHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetDepartmentByNameHandler : IRequestHandler<GetDepartmentByNameQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByNameHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region Service

    public class GetAllServicesHandler : IRequestHandler<GetAllServicesQuery, List<ServiceViewModel>>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetAllServicesHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<List<ServiceViewModel>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            List<Service> Services = (List<Service>)await _ServiceQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<ServiceViewModel>>(Services);
        }
    }

    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByIdHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetServiceByCodeHandler : IRequestHandler<GetServiceByCodeQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByCodeHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetServiceByNameHandler : IRequestHandler<GetServiceByNameQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByNameHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region RoomType

    public class GetAllRoomTypesHandler : IRequestHandler<GetAllRoomTypesQuery, List<RoomTypeViewModel>>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetAllRoomTypesHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<List<RoomTypeViewModel>> Handle(GetAllRoomTypesQuery request, CancellationToken cancellationToken)
        {
            List<RoomType> RoomTypes = (List<RoomType>)await _RoomTypeQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RoomTypeViewModel>>(RoomTypes);
        }
    }

    public class GetRoomTypeByWardIdHandler : IRequestHandler<GetRoomTypeByWardIdQuery, List<RoomTypeViewModel>>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByWardIdHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<List<RoomTypeViewModel>> Handle(GetRoomTypeByWardIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<List<RoomTypeViewModel>>(await _RoomTypeQueryRepository.GetByWardIdAsync(request.WardId));
        }
    }

    public class GetRoomTypeByIdHandler : IRequestHandler<GetRoomTypeByIdQuery, RoomTypeViewModel>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByIdHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<RoomTypeViewModel> Handle(GetRoomTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomTypeViewModel>(await _RoomTypeQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetRoomTypeByCodeHandler : IRequestHandler<GetRoomTypeByCodeQuery, RoomTypeViewModel>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByCodeHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<RoomTypeViewModel> Handle(GetRoomTypeByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomTypeViewModel>(await _RoomTypeQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    

    #endregion

    #region Room

    public class GetAllRoomsHandler : IRequestHandler<GetAllRoomsQuery, List<RoomViewModel>>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetAllRoomsHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<List<RoomViewModel>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
        {
            List<Room> Rooms = (List<Room>)await _RoomQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RoomViewModel>>(Rooms);
        }
    }

    public class GetRoomsByRoomTypeIdHandler : IRequestHandler<GetRoomByRoomTypeIdQuery, List<RoomViewModel>>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomsByRoomTypeIdHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<List<RoomViewModel>> Handle(GetRoomByRoomTypeIdQuery request, CancellationToken cancellationToken)
        {
            List<Room> Rooms = (List<Room>)await _RoomQueryRepository.GetByRoomTypeId(request.RoomTypeId);

            return MapperConfig.Mapper.Map<List<RoomViewModel>>(Rooms);
        }
    }

    public class GetRoomByIdHandler : IRequestHandler<GetRoomByIdQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByIdHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetRoomByCodeHandler : IRequestHandler<GetRoomByCodeQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByCodeHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetRoomByNameHandler : IRequestHandler<GetRoomByNameQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByNameHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region HospitalInformation

    public class GetHospitalInformationByIdHandler : IRequestHandler<GetHospitalInformationByIdQuery, HospitalInformationViewModel>
    {
        private readonly IHospitalInformationQueryRepository _HospitalInformationQueryRepository;

        public GetHospitalInformationByIdHandler(IHospitalInformationQueryRepository HospitalInformationQueryRepository)
        {
            _HospitalInformationQueryRepository = HospitalInformationQueryRepository;
        }

        public async Task<HospitalInformationViewModel> Handle(GetHospitalInformationByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<HospitalInformationViewModel>(await _HospitalInformationQueryRepository.GetByIdAsync(request.Id));
        }
    }

    #endregion

    #region Attachment

    public class GetAllAttachmentsHandler : IRequestHandler<GetAllAttachmentsQuery, List<AttachmentViewModel>>
    {
        private readonly IAttachmentQueryRepository _AttachmentQueryRepository;

        public GetAllAttachmentsHandler(IAttachmentQueryRepository AttachmentQueryRepository)
        {
            _AttachmentQueryRepository = AttachmentQueryRepository;
        }

        public async Task<List<AttachmentViewModel>> Handle(GetAllAttachmentsQuery request, CancellationToken cancellationToken)
        {
            List<Attachment> Attachments = (List<Attachment>)await _AttachmentQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<AttachmentViewModel>>(Attachments);
        }
    }

    public class GetAttachmentByIdHandler : IRequestHandler<GetAttachmentByIdQuery, AttachmentViewModel>
    {
        private readonly IAttachmentQueryRepository _AttachmentQueryRepository;

        public GetAttachmentByIdHandler(IAttachmentQueryRepository AttachmentQueryRepository)
        {
            _AttachmentQueryRepository = AttachmentQueryRepository;
        }

        public async Task<AttachmentViewModel> Handle(GetAttachmentByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<AttachmentViewModel>(await _AttachmentQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetAttachmentByNameHandler : IRequestHandler<GetAttachmentByNameQuery, AttachmentViewModel>
    {
        private readonly IAttachmentQueryRepository _AttachmentQueryRepository;

        public GetAttachmentByNameHandler(IAttachmentQueryRepository AttachmentQueryRepository)
        {
            _AttachmentQueryRepository = AttachmentQueryRepository;
        }

        public async Task<AttachmentViewModel> Handle(GetAttachmentByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<AttachmentViewModel>(await _AttachmentQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region ReportTemplate

    public class GetAllReportTemplatesHandler : IRequestHandler<GetAllReportTemplatesQuery, List<ReportTemplateViewModel>>
    {
        private readonly IReportTemplateQueryRepository _ReportTemplateQueryRepository;

        public GetAllReportTemplatesHandler(IReportTemplateQueryRepository ReportTemplateQueryRepository)
        {
            _ReportTemplateQueryRepository = ReportTemplateQueryRepository;
        }

        public async Task<List<ReportTemplateViewModel>> Handle(GetAllReportTemplatesQuery request, CancellationToken cancellationToken)
        {
            List<ReportTemplate> ReportTemplates = (List<ReportTemplate>)await _ReportTemplateQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<ReportTemplateViewModel>>(ReportTemplates);
        }
    }

    public class GetReportTemplateByIdHandler : IRequestHandler<GetReportTemplateByIdQuery, ReportTemplateViewModel>
    {
        private readonly IReportTemplateQueryRepository _ReportTemplateQueryRepository;

        public GetReportTemplateByIdHandler(IReportTemplateQueryRepository ReportTemplateQueryRepository)
        {
            _ReportTemplateQueryRepository = ReportTemplateQueryRepository;
        }

        public async Task<ReportTemplateViewModel> Handle(GetReportTemplateByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ReportTemplateViewModel>(await _ReportTemplateQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetReportTemplateByCodeHandler : IRequestHandler<GetReportTemplateByCodeQuery, List<ReportTemplateViewModel>>
    {
        private readonly IReportTemplateQueryRepository _ReportTemplateQueryRepository;

        public GetReportTemplateByCodeHandler(IReportTemplateQueryRepository ReportTemplateQueryRepository)
        {
            _ReportTemplateQueryRepository = ReportTemplateQueryRepository;
        }

        public async Task<List<ReportTemplateViewModel>> Handle(GetReportTemplateByCodeQuery request, CancellationToken cancellationToken)
        {
            List<ReportTemplate> ReportTemplates = (List<ReportTemplate>)await _ReportTemplateQueryRepository.GetByCodeAsync(request.Code);

            return MapperConfig.Mapper.Map<List<ReportTemplateViewModel>>(ReportTemplates);
        }
    }


    #endregion

    #region Setting

    public class GetAllSettingsHandler : IRequestHandler<GetAllSettingsQuery, List<SettingViewModel>>
    {
        private readonly ISettingQueryRepository _SettingQueryRepository;

        public GetAllSettingsHandler(ISettingQueryRepository SettingQueryRepository)
        {
            _SettingQueryRepository = SettingQueryRepository;
        }

        public async Task<List<SettingViewModel>> Handle(GetAllSettingsQuery request, CancellationToken cancellationToken)
        {
            List<Setting> Settings = (List<Setting>)await _SettingQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<SettingViewModel>>(Settings);
        }
    }

    public class GetSettingByIdHandler : IRequestHandler<GetSettingByIdQuery, SettingViewModel>
    {
        private readonly ISettingQueryRepository _SettingQueryRepository;

        public GetSettingByIdHandler(ISettingQueryRepository SettingQueryRepository)
        {
            _SettingQueryRepository = SettingQueryRepository;
        }

        public async Task<SettingViewModel> Handle(GetSettingByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<SettingViewModel>(await _SettingQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetSettingByKeyHandler : IRequestHandler<GetSettingByKeyQuery, SettingViewModel>
    {
        private readonly ISettingQueryRepository _SettingQueryRepository;

        public GetSettingByKeyHandler(ISettingQueryRepository SettingQueryRepository)
        {
            _SettingQueryRepository = SettingQueryRepository;
        }

        public async Task<SettingViewModel> Handle(GetSettingByKeyQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<SettingViewModel>(await _SettingQueryRepository.GetByKeyAsync(request.Key));
        }
    }

    #endregion

    #region Bed

    public class GetAllBedsHandler : IRequestHandler<GetAllBedsQuery, List<BedViewModel>>
    {
        private readonly IBedQueryRepository _BedQueryRepository;

        public GetAllBedsHandler(IBedQueryRepository BedQueryRepository)
        {
            _BedQueryRepository = BedQueryRepository;
        }

        public async Task<List<BedViewModel>> Handle(GetAllBedsQuery request, CancellationToken cancellationToken)
        {
            List<Bed> Beds = (List<Bed>)await _BedQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<BedViewModel>>(Beds);
        }
    }

    public class GetBedByRoomIdHandler : IRequestHandler<GetBedByRoomIdQuery, List<BedViewModel>>
    {
        private readonly IBedQueryRepository _BedQueryRepository;

        public GetBedByRoomIdHandler(IBedQueryRepository BedQueryRepository)
        {
            _BedQueryRepository = BedQueryRepository;
        }

        public async Task<List<BedViewModel>> Handle(GetBedByRoomIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<List<BedViewModel>>(await _BedQueryRepository.GetByRoomIdAsync(request.RoomId));
        }
    }

    public class GetBedByIdHandler : IRequestHandler<GetBedByIdQuery, BedViewModel>
    {
        private readonly IBedQueryRepository _BedQueryRepository;

        public GetBedByIdHandler(IBedQueryRepository BedQueryRepository)
        {
            _BedQueryRepository = BedQueryRepository;
        }

        public async Task<BedViewModel> Handle(GetBedByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BedViewModel>(await _BedQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetBedByCodeHandler : IRequestHandler<GetBedByCodeQuery, BedViewModel>
    {
        private readonly IBedQueryRepository _BedQueryRepository;

        public GetBedByCodeHandler(IBedQueryRepository BedQueryRepository)
        {
            _BedQueryRepository = BedQueryRepository;
        }

        public async Task<BedViewModel> Handle(GetBedByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<BedViewModel>(await _BedQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    

    #endregion
}
