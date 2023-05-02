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

            #region UserRole

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

			#region Group

			CreateMap<Group, CreateGroupCommand>().ReverseMap();

			CreateMap<Group, EditGroupCommand>().ReverseMap();

			CreateMap<Group, GroupViewModel>().ReverseMap();

			CreateMap<CreateGroupCommand, GroupViewModel>().ReverseMap();

			CreateMap<EditGroupCommand, GroupViewModel>().ReverseMap();

			#endregion

			#region GroupUser

			CreateMap<GroupUser, CreateGroupUserCommand>().ReverseMap();

			CreateMap<GroupUser, EditGroupUserCommand>().ReverseMap();

			CreateMap<GroupUser, GroupUserViewModel>()
				.ForMember(dest => dest.UserId, opt => opt.MapFrom(src => (src.User != null ? src.User.Id : 0)))
				.ForMember(dest => dest.Username, opt => opt.MapFrom(src => (src.User != null ? src.User.Username : "")))
				.ForMember(dest => dest.UserFulleName, opt => opt.MapFrom(src => (src.User != null ? src.User.FullName() : "")))
				.ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => (src.Group != null ? src.Group.Id : 0)))
				.ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => (src.Group != null ? src.Group.Name : "")));

			CreateMap<GroupUserViewModel, GroupUser>();

			CreateMap<CreateGroupUserCommand, GroupUserViewModel>().ReverseMap();

			CreateMap<EditGroupUserCommand, GroupUserViewModel>().ReverseMap();

			#endregion

			#region FormCategory

			CreateMap<FormCategory, CreateFormCategoryCommand>().ReverseMap();

			CreateMap<FormCategory, EditFormCategoryCommand>().ReverseMap();

			CreateMap<FormCategory, FormCategoryViewModel>().ReverseMap();

			CreateMap<CreateFormCategoryCommand, FormCategoryViewModel>().ReverseMap();

			CreateMap<EditFormCategoryCommand, FormCategoryViewModel>().ReverseMap();

			#endregion

			#region Form

			CreateMap<Form, CreateFormCommand>().ReverseMap();

			CreateMap<Form, EditFormCommand>().ReverseMap();

			CreateMap<Form, FormViewModel>()
				.ForMember(dest => dest.FormCategoryId, opt => opt.MapFrom(src => (src.FormCategory != null ? src.FormCategory.Id : 0)))
				.ForMember(dest => dest.FormCategoryCode, opt => opt.MapFrom(src => (src.FormCategory != null ? src.FormCategory.Code : "")))
				.ForMember(dest => dest.FormCategoryName, opt => opt.MapFrom(src => (src.FormCategory != null ? src.FormCategory.Name : "")));

			CreateMap<FormViewModel, Form>();

			CreateMap<CreateFormCommand, FormViewModel>().ReverseMap();

			CreateMap<EditFormCommand, FormViewModel>().ReverseMap();

			#endregion

			#region FormAction

			CreateMap<FormAction, CreateFormActionCommand>().ReverseMap();

			CreateMap<FormAction, EditFormActionCommand>().ReverseMap();

			CreateMap<FormAction, FormActionViewModel>()
				.ForMember(dest => dest.FormId, opt => opt.MapFrom(src => (src.Form != null ? src.Form.Id : 0)))
				.ForMember(dest => dest.FormCode, opt => opt.MapFrom(src => (src.Form != null ? src.Form.Code : "")))
				.ForMember(dest => dest.FormName, opt => opt.MapFrom(src => (src.Form != null ? src.Form.Name : "")));

			CreateMap<FormActionViewModel, FormAction>();

			CreateMap<CreateFormActionCommand, FormActionViewModel>().ReverseMap();

			CreateMap<EditFormActionCommand, FormActionViewModel>().ReverseMap();

			#endregion

			#region FormActionAccess

			CreateMap<FormActionAccess, CreateFormActionAccessCommand>().ReverseMap();

			CreateMap<FormActionAccess, EditFormActionAccessCommand>().ReverseMap();

			CreateMap<FormActionAccess, FormActionAccessViewModel>()
				.ForMember(dest => dest.UserId, opt => opt.MapFrom(src => (src.User != null ? src.User.Id : 0)))
				.ForMember(dest => dest.Username, opt => opt.MapFrom(src => (src.User != null ? src.User.Username : "")))
				.ForMember(dest => dest.UserFulleName, opt => opt.MapFrom(src => (src.User != null ? src.User.FullName() : "")))
				.ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => (src.Group != null ? src.Group.Id : 0)))
				.ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => (src.Group != null ? src.Group.Name : "")))
				.ForMember(dest => dest.FormActionId, opt => opt.MapFrom(src => (src.FormAction != null ? src.FormAction.Id : 0)))
				.ForMember(dest => dest.FormActionCode, opt => opt.MapFrom(src => (src.FormAction != null ? src.FormAction.Code : "")))
				.ForMember(dest => dest.FormActionName, opt => opt.MapFrom(src => (src.FormAction != null ? src.FormAction.Name : "")))
				.ForMember(dest => dest.FormId, opt => opt.MapFrom(src => (src.FormAction.Form != null ? src.FormAction.Form.Id : 0)))
				.ForMember(dest => dest.FormCode, opt => opt.MapFrom(src => (src.FormAction.Form != null ? src.FormAction.Form.Code : "")))
				.ForMember(dest => dest.FormName, opt => opt.MapFrom(src => (src.FormAction.Form != null ? src.FormAction.Form.Name : "")));

			CreateMap<FormActionAccessViewModel, FormActionAccess>();

			CreateMap<CreateFormActionAccessCommand, FormActionAccessViewModel>().ReverseMap();

			CreateMap<EditFormActionAccessCommand, FormActionAccessViewModel>().ReverseMap();

			#endregion
		}
	}
}
