using AutoMapper;
using Hospital.Application.Commands;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Helpers;

namespace Hospital.Application.Mapper
{
    public class SecurityMappingProfile : Profile
    {
        public SecurityMappingProfile()
        {
            #region User

            CreateMap<User, CreateUserCommand>().ReverseMap();

            CreateMap<User, EditUserCommand>().ReverseMap();

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Decrypt(src.Password)))
                .ForMember(dest => dest.AttachmentContent,opt => opt.MapFrom(src => (src.Attachment!=null?src.Attachment.Content:null)))
                .ForMember(dest => dest.AttachmentFullName, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.Name+"."+src.Attachment.Extension : "")))
                .ForMember(dest => dest.AttachmentContentType, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.ContentType : "")))
                .ForMember(dest => dest.AttachmentDescription, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.Description : "")));

            CreateMap<UserViewModel, User>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Encrypt(src.Password)));

            CreateMap<CreateUserCommand, UserViewModel>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Decrypt(src.Password)));

            CreateMap<UserViewModel, CreateUserCommand>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Encrypt(src.Password)));

            CreateMap<EditUserCommand, UserViewModel>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Decrypt(src.Password)));

            CreateMap<UserViewModel, EditUserCommand>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Encrypt(src.Password)));

            #endregion

            #region Role

            CreateMap<Role, CreateRoleCommand>().ReverseMap();

            CreateMap<Role, EditRoleCommand>().ReverseMap();

            CreateMap<Role, RoleViewModel>().ReverseMap();

            CreateMap<CreateRoleCommand, RoleViewModel>().ReverseMap();

            CreateMap<EditRoleCommand, RoleViewModel>().ReverseMap();

            #endregion

            #region UserUserRole

            CreateMap<UserRole, CreateUserRoleCommand>().ReverseMap();

            CreateMap<UserRole, EditUserRoleCommand>().ReverseMap();

            CreateMap<UserRole, UserRoleViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => (src.User != null ? src.User.Id : 0)))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => (src.User != null ? src.User.Username : "")))
                .ForMember(dest => dest.UserFulleName, opt => opt.MapFrom(src => (src.User != null ? src.User.FullName() : "")))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => (src.Role != null ? src.Role.Id : 0)))
                .ForMember(dest => dest.RoleCode, opt => opt.MapFrom(src => (src.Role != null ? src.Role.Code : "")))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => (src.Role != null ? src.Role.Name : "")));

            CreateMap<UserRoleViewModel, UserRole>();

            CreateMap<CreateUserRoleCommand, UserRoleViewModel>().ReverseMap();

            CreateMap<EditUserRoleCommand, UserRoleViewModel>().ReverseMap();

            #endregion

        }
    }
}
