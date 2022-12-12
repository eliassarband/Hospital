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
            
            #region Department

            CreateMap<Department, CreateDepartmentCommand>().ReverseMap();

            CreateMap<Department, EditDepartmentCommand>().ReverseMap();

            CreateMap<Department, DepartmentViewModel>().ReverseMap();

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

        }
    }
}
