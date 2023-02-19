using AutoMapper;
using Hospital.Application.Commands;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Helpers;

namespace Hospital.Application.Mapper
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {

            #region BasicInformationCategory

            CreateMap<BasicInformationCategory, CreateBasicInformationCategoryCommand>().ReverseMap()
                .ForMember(dest => dest.RelatedCategoryId, opt => opt.MapFrom(src => (src.RelatedCategoryId == 0 ? null : src.RelatedCategoryId)));

            CreateMap<BasicInformationCategory, EditBasicInformationCategoryCommand>().ReverseMap()
                .ForMember(dest => dest.RelatedCategoryId, opt => opt.MapFrom(src => (src.RelatedCategoryId == 0 ? null : src.RelatedCategoryId)));

            CreateMap<BasicInformationCategory, BasicInformationCategoryViewModel>()
                .ForMember(dest => dest.RelatedCategoryId, opt => opt.MapFrom(src => (src.RelatedCategory != null ? src.RelatedCategory.Id : 0)))
                .ForMember(dest => dest.RelatedCategoryCode, opt => opt.MapFrom(src => (src.RelatedCategory != null ? src.RelatedCategory.Code : "")))
                .ForMember(dest => dest.RelatedCategoryName, opt => opt.MapFrom(src => (src.RelatedCategory != null ? src.RelatedCategory.Name : "")));

            CreateMap<BasicInformationCategoryViewModel, BasicInformationCategory>();

            CreateMap<CreateBasicInformationCategoryCommand, BasicInformationCategoryViewModel>().ReverseMap();

            CreateMap<EditBasicInformationCategoryCommand, BasicInformationCategoryViewModel>().ReverseMap();

            #endregion

            #region BasicInformation

            CreateMap<BasicInformation, CreateBasicInformationCommand>().ReverseMap()
                .ForMember(dest => dest.RelatedBasicInformationId, opt => opt.MapFrom(src => (src.RelatedBasicInformationId == 0 ? null : src.RelatedBasicInformationId)));

            CreateMap<BasicInformation, EditBasicInformationCommand>().ReverseMap()
                .ForMember(dest => dest.RelatedBasicInformationId, opt => opt.MapFrom(src => (src.RelatedBasicInformationId == 0 ? null : src.RelatedBasicInformationId)));

            CreateMap<BasicInformation, BasicInformationViewModel>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => (src.Category != null ? src.Category.Id : 0)))
                .ForMember(dest => dest.CategoryCode, opt => opt.MapFrom(src => (src.Category != null ? src.Category.Code : "")))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => (src.Category != null ? src.Category.Name : "")))
                .ForMember(dest => dest.RelatedBasicInformationId, opt => opt.MapFrom(src => (src.RelatedBasicInformation != null ? src.RelatedBasicInformation.Id : 0)))
                .ForMember(dest => dest.RelatedBasicInformationCode, opt => opt.MapFrom(src => (src.RelatedBasicInformation != null ? src.RelatedBasicInformation.Code : 0)))
                .ForMember(dest => dest.RelatedBasicInformationStrCode, opt => opt.MapFrom(src => (src.RelatedBasicInformation != null ? src.RelatedBasicInformation.StrCode : "")))
                .ForMember(dest => dest.RelatedBasicInformationName, opt => opt.MapFrom(src => (src.RelatedBasicInformation != null ? src.RelatedBasicInformation.Name : "")));

            CreateMap<BasicInformationViewModel, BasicInformation>();

            CreateMap<CreateBasicInformationCommand, BasicInformationViewModel>().ReverseMap();

            CreateMap<EditBasicInformationCommand, BasicInformationViewModel>().ReverseMap();

            #endregion

            #region Department

            CreateMap<Department, CreateDepartmentCommand>().ReverseMap()
                .ForMember(dest => dest.MainDepartmentId, opt => opt.MapFrom(src => (src.MainDepartmentId == 0 ? null : src.MainDepartmentId))); 

            CreateMap<Department, EditDepartmentCommand>().ReverseMap()
                .ForMember(dest => dest.MainDepartmentId, opt => opt.MapFrom(src => (src.MainDepartmentId == 0 ? null : src.MainDepartmentId)));

            CreateMap<Department, DepartmentViewModel>()
                .ForMember(dest => dest.MainDepartmentId, opt => opt.MapFrom(src => (src.MainDepartment != null ? src.MainDepartment.Id : 0)))
                .ForMember(dest => dest.MainDepartmentName, opt => opt.MapFrom(src => (src.MainDepartment != null ? src.MainDepartment.Name : "")));

            CreateMap<DepartmentViewModel, Department>();

            CreateMap<CreateDepartmentCommand, DepartmentViewModel>().ReverseMap();

            CreateMap<EditDepartmentCommand, DepartmentViewModel>().ReverseMap();

            #endregion

            #region Service

            CreateMap<Service, CreateServiceCommand>().ReverseMap()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => (src.DepartmentId == 0 ? null : src.DepartmentId)));

            CreateMap<Service, EditServiceCommand>().ReverseMap()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => (src.DepartmentId == 0 ? null : src.DepartmentId)));

            CreateMap<Service, ServiceViewModel>()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => (src.Department != null ? src.Department.Id : 0)))
                .ForMember(dest => dest.DepartmentCode, opt => opt.MapFrom(src => (src.Department != null ? src.Department.Code : "")))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => (src.Department != null ? src.Department.Name : "")));

            CreateMap<ServiceViewModel, Service>();

            CreateMap<CreateServiceCommand, ServiceViewModel>().ReverseMap();

            CreateMap<EditServiceCommand, ServiceViewModel>().ReverseMap();

            #endregion

            #region RoomType

            CreateMap<RoomType, CreateRoomTypeCommand>().ReverseMap();

            CreateMap<RoomType, EditRoomTypeCommand>().ReverseMap();

            CreateMap<RoomType, RoomTypeViewModel>().ReverseMap();

            CreateMap<CreateRoomTypeCommand, RoomTypeViewModel>().ReverseMap();

            CreateMap<EditRoomTypeCommand, RoomTypeViewModel>().ReverseMap();

            #endregion

            #region Room

            CreateMap<Room, CreateRoomCommand>().ReverseMap()
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomTypeId == 0 ? null : src.RoomTypeId)));

            CreateMap<Room, EditRoomCommand>().ReverseMap()
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomTypeId == 0 ? null : src.RoomTypeId)));

            CreateMap<Room, RoomViewModel>()
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomType != null ? src.RoomType.Id : 0)))
                .ForMember(dest => dest.RoomTypeCode, opt => opt.MapFrom(src => (src.RoomType != null ? src.RoomType.Code : "")))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => (src.RoomType != null ? src.RoomType.Name : "")));

            CreateMap<RoomViewModel, Room>();

            CreateMap<CreateRoomCommand, RoomViewModel>().ReverseMap();

            CreateMap<EditRoomCommand, RoomViewModel>().ReverseMap();

            #endregion

            #region HospitalInformation

            CreateMap<HospitalInformation, CreateHospitalInformationCommand>().ReverseMap();

            CreateMap<HospitalInformation, EditHospitalInformationCommand>().ReverseMap();

            CreateMap<HospitalInformation, HospitalInformationViewModel>().ReverseMap();

            CreateMap<CreateHospitalInformationCommand, HospitalInformationViewModel>().ReverseMap();

            CreateMap<EditHospitalInformationCommand, HospitalInformationViewModel>().ReverseMap();

            #endregion

            #region Attachment

            CreateMap<Attachment, CreateAttachmentCommand>().ReverseMap();

            CreateMap<Attachment, EditAttachmentCommand>().ReverseMap();

            CreateMap<Attachment, AttachmentViewModel>().ReverseMap();

            CreateMap<CreateAttachmentCommand, AttachmentViewModel>().ReverseMap();

            CreateMap<EditAttachmentCommand, AttachmentViewModel>().ReverseMap();

            #endregion

            #region ReportTemplate

            CreateMap<ReportTemplate, CreateReportTemplateCommand>().ReverseMap();

            CreateMap<ReportTemplate, EditReportTemplateCommand>().ReverseMap();

            CreateMap<ReportTemplate, ReportTemplateViewModel>().ReverseMap();

            CreateMap<CreateReportTemplateCommand, ReportTemplateViewModel>().ReverseMap();

            CreateMap<EditReportTemplateCommand, ReportTemplateViewModel>().ReverseMap();

            #endregion

        }
    }
}
