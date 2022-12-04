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
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => CryptographyHelper.Decrypt(src.Password)));

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

            //CreateMap<UserRole, CreateUserRoleCommand>().ReverseMap();

            //CreateMap<UserRole, EditUserRoleCommand>().ReverseMap();

            CreateMap<UserRole, UserRoleViewModel>().ReverseMap();

            //CreateMap<CreateUserRoleCommand, UserRoleViewModel>().ReverseMap();

            //CreateMap<EditUserRoleCommand, UserRoleViewModel>().ReverseMap();

            #endregion

        }
    }
}
