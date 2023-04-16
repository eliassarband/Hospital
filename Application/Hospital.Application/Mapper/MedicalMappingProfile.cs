using AutoMapper;
using Hospital.Application.Commands;
using Hospital.Application.Handlers.QueryHandlers;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Helpers;

namespace Hospital.Application.Mapper
{
    public class MedicalMappingProfile : Profile
    {
        public MedicalMappingProfile()
        {

            #region Insurance

            CreateMap<Insurance, CreateInsuranceCommand>().ReverseMap();

            CreateMap<Insurance, EditInsuranceCommand>().ReverseMap();
            
            CreateMap<Insurance, InsuranceViewModel>()
                .ForMember(dest => dest.InsurancePaymentTypeId, opt => opt.MapFrom(src => (src.InsurancePaymentType != null ? src.InsurancePaymentType.Id : 0)))
                .ForMember(dest => dest.InsurancePaymentTypeCode, opt => opt.MapFrom(src => (src.InsurancePaymentType != null ? src.InsurancePaymentType.Code : 0)))
                .ForMember(dest => dest.InsurancePaymentTypeStrCode, opt => opt.MapFrom(src => (src.InsurancePaymentType != null ? src.InsurancePaymentType.StrCode : "")))
                .ForMember(dest => dest.InsurancePaymentTypeName, opt => opt.MapFrom(src => (src.InsurancePaymentType != null ? src.InsurancePaymentType.Name : "")));

            CreateMap<InsuranceViewModel, Insurance>();

            CreateMap<CreateInsuranceCommand, InsuranceViewModel>().ReverseMap();

            CreateMap<EditInsuranceCommand, InsuranceViewModel>().ReverseMap();

            #endregion

            #region InsuranceAgreement

            CreateMap<InsuranceAgreement, CreateInsuranceAgreementCommand>().ReverseMap();

            CreateMap<InsuranceAgreement, EditInsuranceAgreementCommand>().ReverseMap();

            CreateMap<InsuranceAgreement, InsuranceAgreementViewModel>()
                .ForMember(dest => dest.AttachmentContent, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.Content : null)))
                .ForMember(dest => dest.AttachmentFullName, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.Name + "." + src.Attachment.Extension : "")))
                .ForMember(dest => dest.AttachmentContentType, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.ContentType : "")))
                .ForMember(dest => dest.AttachmentDescription, opt => opt.MapFrom(src => (src.Attachment != null ? src.Attachment.Description : "")))
                .ForMember(dest => dest.InsuranceId, opt => opt.MapFrom(src => src.Insurance.Id))
                .ForMember(dest => dest.InsuranceCode, opt => opt.MapFrom(src => src.Insurance.Code))
                .ForMember(dest => dest.InsuranceName, opt => opt.MapFrom(src => src.Insurance.Name));

            CreateMap<InsuranceAgreementViewModel, InsuranceAgreement>();

            CreateMap<CreateInsuranceAgreementCommand, InsuranceAgreementViewModel>().ReverseMap();

            CreateMap<EditInsuranceAgreementCommand, InsuranceAgreementViewModel>().ReverseMap();

            #endregion

            #region Staff

            CreateMap<Staff, CreateStaffCommand>().ReverseMap()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffTypeId == 0 ? null : src.StaffTypeId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.SpecialityId == 0 ? null : src.SpecialityId)))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.QualificationId == 0 ? null : src.QualificationId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)));

            CreateMap<Staff, EditStaffCommand>().ReverseMap()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffTypeId == 0 ? null : src.StaffTypeId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.SpecialityId == 0 ? null : src.SpecialityId)))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.QualificationId == 0 ? null : src.QualificationId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)));

            CreateMap<Staff, StaffViewModel>()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Id : 0)))
                .ForMember(dest => dest.StaffTypeCode, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Code : 0)))
                .ForMember(dest => dest.StaffTypeStrCode, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.StrCode : "")))
                .ForMember(dest => dest.StaffTypeName, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Name : "")))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Id : 0)))
                .ForMember(dest => dest.NamePrefixCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Code : 0)))
                .ForMember(dest => dest.NamePrefixStrCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.StrCode : "")))
                .ForMember(dest => dest.NamePrefixName, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Name : "")))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Id : 0)))
                .ForMember(dest => dest.SpecialityCode, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Code : 0)))
                .ForMember(dest => dest.SpecialityStrCode, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.StrCode : "")))
                .ForMember(dest => dest.SpecialityName, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Name : "")))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Id : 0)))
                .ForMember(dest => dest.QualificationCode, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Code : 0)))
                .ForMember(dest => dest.QualificationStrCode, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.StrCode : "")))
                .ForMember(dest => dest.QualificationName, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Name : "")))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.City != null ? src.City.Id : 0)))
                .ForMember(dest => dest.CityCode, opt => opt.MapFrom(src => (src.City != null ? src.City.Code : 0)))
                .ForMember(dest => dest.CityStrCode, opt => opt.MapFrom(src => (src.City != null ? src.City.StrCode : "")))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => (src.City != null ? src.City.Name : "")))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Id : 0)))
                .ForMember(dest => dest.AreaCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Code : 0)))
                .ForMember(dest => dest.AreaStrCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.StrCode : "")))
                .ForMember(dest => dest.AreaName, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Name : "")));

            CreateMap<StaffViewModel, Staff>();

            CreateMap<CreateStaffCommand, StaffViewModel>().ReverseMap();

            CreateMap<EditStaffCommand, StaffViewModel>().ReverseMap();

            #endregion

            #region StaffTiming

            CreateMap<StaffTiming, CreateStaffTimingCommand>().ReverseMap()
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<StaffTiming, EditStaffTimingCommand>().ReverseMap()
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<StaffTiming, StaffTimingViewModel>()
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Id : 0)))
                .ForMember(dest => dest.StaffCode, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Code : "")))
                .ForMember(dest => dest.StaffName, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Name : "")));

            CreateMap<StaffTimingViewModel, StaffTiming>();

            CreateMap<CreateStaffTimingCommand, StaffTimingViewModel>().ReverseMap();

            CreateMap<EditStaffTimingCommand, StaffTimingViewModel>().ReverseMap();

            #endregion

            #region RefferBy

            CreateMap<RefferBy, CreateRefferByCommand>().ReverseMap()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffTypeId == 0 ? null : src.StaffTypeId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.SpecialityId == 0 ? null : src.SpecialityId)))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.QualificationId == 0 ? null : src.QualificationId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)));

            CreateMap<RefferBy, EditRefferByCommand>().ReverseMap()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffTypeId == 0 ? null : src.StaffTypeId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.SpecialityId == 0 ? null : src.SpecialityId)))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.QualificationId == 0 ? null : src.QualificationId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)));

            CreateMap<RefferBy, RefferByViewModel>()
                .ForMember(dest => dest.StaffTypeId, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Id : 0)))
                .ForMember(dest => dest.StaffTypeCode, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Code : 0)))
                .ForMember(dest => dest.StaffTypeStrCode, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.StrCode : "")))
                .ForMember(dest => dest.StaffTypeName, opt => opt.MapFrom(src => (src.StaffType != null ? src.StaffType.Name : "")))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Id : 0)))
                .ForMember(dest => dest.NamePrefixCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Code : 0)))
                .ForMember(dest => dest.NamePrefixStrCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.StrCode : "")))
                .ForMember(dest => dest.NamePrefixName, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Name : "")))
                .ForMember(dest => dest.SpecialityId, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Id : 0)))
                .ForMember(dest => dest.SpecialityCode, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Code : 0)))
                .ForMember(dest => dest.SpecialityStrCode, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.StrCode : "")))
                .ForMember(dest => dest.SpecialityName, opt => opt.MapFrom(src => (src.Speciality != null ? src.Speciality.Name : "")))
                .ForMember(dest => dest.QualificationId, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Id : 0)))
                .ForMember(dest => dest.QualificationCode, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Code : 0)))
                .ForMember(dest => dest.QualificationStrCode, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.StrCode : "")))
                .ForMember(dest => dest.QualificationName, opt => opt.MapFrom(src => (src.Qualification != null ? src.Qualification.Name : "")))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.City != null ? src.City.Id : 0)))
                .ForMember(dest => dest.CityCode, opt => opt.MapFrom(src => (src.City != null ? src.City.Code : 0)))
                .ForMember(dest => dest.CityStrCode, opt => opt.MapFrom(src => (src.City != null ? src.City.StrCode : "")))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => (src.City != null ? src.City.Name : "")))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Id : 0)))
                .ForMember(dest => dest.AreaCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Code : 0)))
                .ForMember(dest => dest.AreaStrCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.StrCode : "")))
                .ForMember(dest => dest.AreaName, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Name : "")));

            CreateMap<RefferByViewModel, RefferBy>();

            CreateMap<CreateRefferByCommand, RefferByViewModel>().ReverseMap();

            CreateMap<EditRefferByCommand, RefferByViewModel>().ReverseMap();

            #endregion

            #region Patient

            CreateMap<Patient, CreatePatientCommand>().ReverseMap()
                .ForMember(dest => dest.GenderId, opt => opt.MapFrom(src => (src.GenderId == 0 ? null : src.GenderId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferById == 0 ? null : src.RefferById)))
                .ForMember(dest => dest.InsuranceId, opt => opt.MapFrom(src => (src.InsuranceId == 0 ? null : src.InsuranceId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)))
                .ForMember(dest => dest.AttachmentId, opt => opt.MapFrom(src => (src.AttachmentId == 0 ? null : src.AttachmentId)));

            CreateMap<Patient, EditPatientCommand>().ReverseMap()
                .ForMember(dest => dest.GenderId, opt => opt.MapFrom(src => (src.GenderId == 0 ? null : src.GenderId)))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefixId == 0 ? null : src.NamePrefixId)))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferById == 0 ? null : src.RefferById)))
                .ForMember(dest => dest.InsuranceId, opt => opt.MapFrom(src => (src.InsuranceId == 0 ? null : src.InsuranceId)))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.CityId == 0 ? null : src.CityId)))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.AreaId == 0 ? null : src.AreaId)))
                .ForMember(dest => dest.AttachmentId, opt => opt.MapFrom(src => (src.AttachmentId == 0 ? null : src.AttachmentId)));

            CreateMap<Patient, PatientViewModel>()
                .ForMember(dest => dest.GenderId, opt => opt.MapFrom(src => (src.Gender != null ? src.Gender.Id : 0)))
                .ForMember(dest => dest.GenderCode, opt => opt.MapFrom(src => (src.Gender != null ? src.Gender.Code : 0)))
                .ForMember(dest => dest.GenderStrCode, opt => opt.MapFrom(src => (src.Gender != null ? src.Gender.StrCode : "")))
                .ForMember(dest => dest.GenderName, opt => opt.MapFrom(src => (src.Gender != null ? src.Gender.Name : "")))
                .ForMember(dest => dest.NamePrefixId, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Id : 0)))
                .ForMember(dest => dest.NamePrefixCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Code : 0)))
                .ForMember(dest => dest.NamePrefixStrCode, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.StrCode : "")))
                .ForMember(dest => dest.NamePrefixName, opt => opt.MapFrom(src => (src.NamePrefix != null ? src.NamePrefix.Name : "")))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.Id : 0)))
                .ForMember(dest => dest.RefferByCode, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.Code : "")))
                .ForMember(dest => dest.RefferByNamePrefix, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.NamePrefix.Name : "")))
                .ForMember(dest => dest.RefferByName, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.Name : "")))
                .ForMember(dest => dest.InsuranceId, opt => opt.MapFrom(src => (src.Insurance != null ? src.Insurance.Id : 0)))
                .ForMember(dest => dest.InsuranceCode, opt => opt.MapFrom(src => (src.Insurance != null ? src.Insurance.Code : "")))
                .ForMember(dest => dest.InsuranceName, opt => opt.MapFrom(src => (src.Insurance != null ? src.Insurance.Name : "")))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => (src.City != null ? src.City.Id : 0)))
                .ForMember(dest => dest.CityCode, opt => opt.MapFrom(src => (src.City != null ? src.City.Code : 0)))
                .ForMember(dest => dest.CityStrCode, opt => opt.MapFrom(src => (src.City != null ? src.City.StrCode : "")))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => (src.City != null ? src.City.Name : "")))
                .ForMember(dest => dest.AreaId, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Id : 0)))
                .ForMember(dest => dest.AreaCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Code : 0)))
                .ForMember(dest => dest.AreaStrCode, opt => opt.MapFrom(src => (src.Area != null ? src.Area.StrCode : "")))
                .ForMember(dest => dest.AreaName, opt => opt.MapFrom(src => (src.Area != null ? src.Area.Name : "")));

            CreateMap<PatientViewModel, Patient>();

            CreateMap<CreatePatientCommand, PatientViewModel>().ReverseMap();

            CreateMap<EditPatientCommand, PatientViewModel>().ReverseMap();

            #endregion

            #region OPDBill

            CreateMap<OPDBill, CreateOPDBillCommand>().ReverseMap()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.PatientId == 0 ? null : src.PatientId)))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentTypeId == 0 ? null : src.PaymentTypeId)));

            CreateMap<OPDBill, EditOPDBillCommand>().ReverseMap()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.PatientId == 0 ? null : src.PatientId)))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentTypeId == 0 ? null : src.PaymentTypeId)));

            CreateMap<OPDBill, OPDBillViewModel>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.Patient != null ? src.Patient.Id : 0)))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => (src.Patient != null ? src.Patient.Name : "")))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Id : 0)))
                .ForMember(dest => dest.PaymentTypeCode, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Code : 0)))
                .ForMember(dest => dest.PaymentTypeStrCode, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.StrCode : "")))
                .ForMember(dest => dest.PaymentTypeName, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Name : "")))
                .ForMember(dest => dest.DebtAmount, opt => opt.MapFrom(src => (src.PayableAmount - ((src.PaidAmount??0) + src.OPDBillPayments.Sum(p => p.Amount)))));

            CreateMap<OPDBillViewModel, OPDBill>();

            CreateMap<CreateOPDBillCommand, OPDBillViewModel>().ReverseMap();

            CreateMap<EditOPDBillCommand, OPDBillViewModel>().ReverseMap();

            #endregion

            #region OPDBillService

            CreateMap<OPDBillService, CreateOPDBillServiceCommand>().ReverseMap()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBillId == 0 ? null : src.OPDBillId)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.ServiceId == 0 ? null : src.ServiceId)))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<OPDBillService, EditOPDBillServiceCommand>().ReverseMap()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBillId == 0 ? null : src.OPDBillId)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.ServiceId == 0 ? null : src.ServiceId)))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<OPDBillService, OPDBillServiceViewModel>()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBill != null ? src.OPDBill.Id : 0)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.Service!= null ? src.Service.Id : 0)))
                .ForMember(dest => dest.ServiceCode, opt => opt.MapFrom(src => (src.Service != null ? src.Service.Code : "")))
                .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(src => (src.Service != null ? src.Service.Name : "")))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Id : 0)))
                .ForMember(dest => dest.StaffCode, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Code : "")))
                .ForMember(dest => dest.StaffName, opt => opt.MapFrom(src => (src.Staff  != null ? src.Staff.Name : "")));

            CreateMap<OPDBillServiceViewModel, OPDBillService>();

            CreateMap<CreateOPDBillServiceCommand, OPDBillServiceViewModel>().ReverseMap();

            CreateMap<EditOPDBillServiceCommand, OPDBillServiceViewModel>().ReverseMap();

            #endregion

            #region PatientToSelectItem

            CreateMap<PatientViewModel, SelectItemViewModel>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
            #endregion

            #region IPDRegisteration

            CreateMap<IPDRegisteration, CreateIPDRegisterationCommand>().ReverseMap()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.PatientId == 0 ? null : src.PatientId)))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferById == 0 ? null : src.RefferById)))
                .ForMember(dest => dest.ConsultantInchargeId, opt => opt.MapFrom(src => (src.ConsultantInchargeId == 0 ? null : src.ConsultantInchargeId)))
                .ForMember(dest => dest.SecondConsultantId, opt => opt.MapFrom(src => (src.SecondConsultantId == 0 ? null : src.SecondConsultantId)))
                .ForMember(dest => dest.ThirdConsultantId, opt => opt.MapFrom(src => (src.ThirdConsultantId == 0 ? null : src.ThirdConsultantId)))
                .ForMember(dest => dest.WardId, opt => opt.MapFrom(src => (src.WardId == 0 ? null : src.WardId)))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomTypeId == 0 ? null : src.RoomTypeId)))
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => (src.RoomId == 0 ? null : src.RoomId)))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.BedId == 0 ? null : src.BedId)))
                .ForMember(dest => dest.CaseTypeId, opt => opt.MapFrom(src => (src.CaseTypeId == 0 ? null : src.CaseTypeId)))
                .ForMember(dest => dest.RelationshipId, opt => opt.MapFrom(src => (src.RelationshipId == 0 ? null : src.RelationshipId)));

            CreateMap<IPDRegisteration, EditIPDRegisterationCommand>().ReverseMap()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.PatientId == 0 ? null : src.PatientId)))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferById == 0 ? null : src.RefferById)))
                .ForMember(dest => dest.ConsultantInchargeId, opt => opt.MapFrom(src => (src.ConsultantInchargeId == 0 ? null : src.ConsultantInchargeId)))
                .ForMember(dest => dest.SecondConsultantId, opt => opt.MapFrom(src => (src.SecondConsultantId == 0 ? null : src.SecondConsultantId)))
                .ForMember(dest => dest.ThirdConsultantId, opt => opt.MapFrom(src => (src.ThirdConsultantId == 0 ? null : src.ThirdConsultantId)))
                .ForMember(dest => dest.WardId, opt => opt.MapFrom(src => (src.WardId == 0 ? null : src.WardId)))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomTypeId == 0 ? null : src.RoomTypeId)))
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => (src.RoomId == 0 ? null : src.RoomId)))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.BedId == 0 ? null : src.BedId)))
                .ForMember(dest => dest.CaseTypeId, opt => opt.MapFrom(src => (src.CaseTypeId == 0 ? null : src.CaseTypeId)))
                .ForMember(dest => dest.RelationshipId, opt => opt.MapFrom(src => (src.RelationshipId == 0 ? null : src.RelationshipId)));

            CreateMap<IPDRegisteration, IPDRegisterationViewModel>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => (src.Patient != null ? src.Patient.Id : 0)))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => (src.Patient != null ? src.Patient.Name : "")))
                .ForMember(dest => dest.RefferById, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.Id : 0)))
                .ForMember(dest => dest.RefferByName, opt => opt.MapFrom(src => (src.RefferBy != null ? src.RefferBy.Name : "")))
                .ForMember(dest => dest.ConsultantInchargeId, opt => opt.MapFrom(src => (src.ConsultantIncharge != null ? src.ConsultantIncharge.Id : 0)))
                .ForMember(dest => dest.ConsultantInchargeName, opt => opt.MapFrom(src => (src.ConsultantIncharge != null ? src.ConsultantIncharge.Name : "")))
                .ForMember(dest => dest.SecondConsultantId, opt => opt.MapFrom(src => (src.SecondConsultant != null ? src.SecondConsultant.Id : 0)))
                .ForMember(dest => dest.SecondConsultantName, opt => opt.MapFrom(src => (src.SecondConsultant != null ? src.SecondConsultant.Name : "")))
                .ForMember(dest => dest.ThirdConsultantId, opt => opt.MapFrom(src => (src.ThirdConsultant != null ? src.ThirdConsultant.Id : 0)))
                .ForMember(dest => dest.ThirdConsultantName, opt => opt.MapFrom(src => (src.ThirdConsultant != null ? src.ThirdConsultant.Name : "")))
                .ForMember(dest => dest.WardId, opt => opt.MapFrom(src => (src.Ward != null ? src.Ward.Id : 0)))
                .ForMember(dest => dest.WardName, opt => opt.MapFrom(src => (src.Ward != null ? src.Ward.Name : "")))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => (src.RoomType != null ? src.RoomType.Id : 0)))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => (src.RoomType != null ? src.RoomType.Name : "")))
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => (src.Room != null ? src.Room.Id : 0)))
                .ForMember(dest => dest.RoomName, opt => opt.MapFrom(src => (src.Room != null ? src.Room.Name : "")))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.Bed != null ? src.Bed.Id : 0)))
                .ForMember(dest => dest.BedName, opt => opt.MapFrom(src => (src.Bed != null ? src.Bed.Name : "")))
                .ForMember(dest => dest.CaseTypeId, opt => opt.MapFrom(src => (src.CaseType != null ? src.CaseType.Id : 0)))
                .ForMember(dest => dest.CaseTypeName, opt => opt.MapFrom(src => (src.CaseType != null ? src.CaseType.Name : "")))
                .ForMember(dest => dest.RelationshipId, opt => opt.MapFrom(src => (src.Relationship != null ? src.Relationship.Id : 0)))
                .ForMember(dest => dest.RelationshipName, opt => opt.MapFrom(src => (src.Relationship != null ? src.Relationship.Name : "")));

            CreateMap<IPDRegisterationViewModel, IPDRegisteration>();

            CreateMap<CreateIPDRegisterationCommand, IPDRegisterationViewModel>().ReverseMap();

            CreateMap<EditIPDRegisterationCommand, IPDRegisterationViewModel>().ReverseMap();

            #endregion

            #region IPDRegisterationService

            CreateMap<IPDRegisterationService, CreateIPDRegisterationServiceCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.ServiceId == 0 ? null : src.ServiceId)))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<IPDRegisterationService, EditIPDRegisterationServiceCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.ServiceId == 0 ? null : src.ServiceId)))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.StaffId == 0 ? null : src.StaffId)));

            CreateMap<IPDRegisterationService, IPDRegisterationServiceViewModel>()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisteration != null ? src.IPDRegisteration.Id : 0)))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => (src.Service != null ? src.Service.Id : 0)))
                .ForMember(dest => dest.ServiceCode, opt => opt.MapFrom(src => (src.Service != null ? src.Service.Code : "")))
                .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(src => (src.Service != null ? src.Service.Name : "")))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Id : 0)))
                .ForMember(dest => dest.StaffCode, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Code : "")))
                .ForMember(dest => dest.StaffName, opt => opt.MapFrom(src => (src.Staff != null ? src.Staff.Name : "")));

            CreateMap<IPDRegisterationServiceViewModel, IPDRegisterationService>();

            CreateMap<CreateIPDRegisterationServiceCommand, IPDRegisterationServiceViewModel>().ReverseMap();

            CreateMap<EditIPDRegisterationServiceCommand, IPDRegisterationServiceViewModel>().ReverseMap();

            #endregion

            #region IPDRegisterationRoom

            CreateMap<IPDRegisterationRoom, CreateIPDRegisterationRoomCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.BedId == 0 ? null : src.BedId)));

            CreateMap<IPDRegisterationRoom, EditIPDRegisterationRoomCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.BedId == 0 ? null : src.BedId)));

            CreateMap<IPDRegisterationRoom, IPDRegisterationRoomViewModel>()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisteration != null ? src.IPDRegisteration.Id : 0)))
                .ForMember(dest => dest.BedId, opt => opt.MapFrom(src => (src.Bed != null ? src.Bed.Id : 0)))
                .ForMember(dest => dest.BedCode, opt => opt.MapFrom(src => (src.Bed != null ? src.Bed.Code : "")))
                .ForMember(dest => dest.BedName, opt => opt.MapFrom(src => (src.Bed != null ? src.Bed.Name : "")));

            CreateMap<IPDRegisterationRoomViewModel, IPDRegisterationRoom>();

            CreateMap<CreateIPDRegisterationRoomCommand, IPDRegisterationRoomViewModel>().ReverseMap();

            CreateMap<EditIPDRegisterationRoomCommand, IPDRegisterationRoomViewModel>().ReverseMap();

            #endregion

            #region IPDRegisterationPayment

            CreateMap<IPDRegisterationPayment, CreateIPDRegisterationPaymentCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentTypeId == 0 ? null : src.PaymentTypeId)));

            CreateMap<IPDRegisterationPayment, EditIPDRegisterationPaymentCommand>().ReverseMap()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisterationId == 0 ? null : src.IPDRegisterationId)))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentTypeId == 0 ? null : src.PaymentTypeId)));

            CreateMap<IPDRegisterationPayment, IPDRegisterationPaymentViewModel>()
                .ForMember(dest => dest.IPDRegisterationId, opt => opt.MapFrom(src => (src.IPDRegisteration != null ? src.IPDRegisteration.Id : 0)))
                .ForMember(dest => dest.PaymentTypeId, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Id : 0)))
                .ForMember(dest => dest.PaymentTypeCode, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Code : 0)))
                .ForMember(dest => dest.PaymentTypeStrCode, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.StrCode : "")))
                .ForMember(dest => dest.PaymentTypeName, opt => opt.MapFrom(src => (src.PaymentType != null ? src.PaymentType.Name : "")));

            CreateMap<IPDRegisterationPaymentViewModel, IPDRegisterationPayment>();

            CreateMap<CreateIPDRegisterationPaymentCommand, IPDRegisterationPaymentViewModel>().ReverseMap();

            CreateMap<EditIPDRegisterationPaymentCommand, IPDRegisterationPaymentViewModel>().ReverseMap();

            #endregion

            #region OPDBillPayment

            CreateMap<OPDBillPayment, CreateOPDBillPaymentCommand>().ReverseMap()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBillId == 0 ? null : src.OPDBillId)));

            CreateMap<OPDBillPayment, EditOPDBillPaymentCommand>().ReverseMap()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBillId == 0 ? null : src.OPDBillId)));

            CreateMap<OPDBillPayment, OPDBillPaymentViewModel>()
                .ForMember(dest => dest.OPDBillId, opt => opt.MapFrom(src => (src.OPDBill != null ? src.OPDBill.Id : 0)));

            CreateMap<OPDBillPaymentViewModel, OPDBillPayment>();

            CreateMap<CreateOPDBillPaymentCommand, OPDBillPaymentViewModel>().ReverseMap();

            CreateMap<EditOPDBillPaymentCommand, OPDBillPaymentViewModel>().ReverseMap();

            #endregion
        }
    }
}
