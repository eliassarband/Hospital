using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.Responses;
using Hospital.Application.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Application.Commands
{

    #region Insurance
    public class CreateInsuranceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OPDDiscountPercent { get; set; }
        public int IPDDiscountPercent { get; set; }
        public int AdvancePaymentPercent { get; set; }
        public int AdvancePaymentAmount { get; set; }
        public int InsurancePaymentTypeId { get; set; }
        public int InsurancePaymentTypeCode { get; set; }
        public string InsurancePaymentTypeStrCode { get; set; }
        public string InsurancePaymentTypeName { get; set; }
        public virtual BasicInformationViewModel InsurancePaymentType { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateInsuranceCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditInsuranceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OPDDiscountPercent { get; set; }
        public int IPDDiscountPercent { get; set; }
        public int AdvancePaymentPercent { get; set; }
        public int AdvancePaymentAmount { get; set; }
        public int InsurancePaymentTypeId { get; set; }
        public int InsurancePaymentTypeCode { get; set; }
        public string InsurancePaymentTypeStrCode { get; set; }
        public string InsurancePaymentTypeName { get; set; }
        public virtual BasicInformationViewModel InsurancePaymentType { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditInsuranceCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteInsuranceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteInsuranceCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region InsuranceAgreement
    public class CreateInsuranceAgreementCommand : IRequest<CommandResponse>
    {

        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime ToDate { get; set; }
        public int? AttachmentId { get; set; }
        public int ShowWarningBefore { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateInsuranceAgreementCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditInsuranceAgreementCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime ToDate { get; set; }
        public int? AttachmentId { get; set; }
        public int ShowWarningBefore { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditInsuranceAgreementCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteInsuranceAgreementCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteInsuranceAgreementCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Staff
    public class CreateStaffCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffTypeId { get; set; }
        public string Code { get; set; }
        public int? NamePrefixId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? SpecialityId { get; set; }
        public int? QualificationId { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string Address { get; set; }
        public int OPDChargePercent { get; set; }
        public int IPDChargePercent { get; set; }
        public int NightOPDChargePercent { get; set; }
        public int NightIPDChargePercent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateStaffCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditStaffCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffTypeId { get; set; }
        public string Code { get; set; }
        public int? NamePrefixId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? SpecialityId { get; set; }
        public int? QualificationId { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string Address { get; set; }
        public int OPDChargePercent { get; set; }
        public int IPDChargePercent { get; set; }
        public int NightOPDChargePercent { get; set; }
        public int NightIPDChargePercent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditStaffCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteStaffCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteStaffCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region StaffTiming
    public class CreateStaffTimingCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int WeekDayNo { get; set; }
        public string WeekDayName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateStaffTimingCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditStaffTimingCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int WeekDayNo { get; set; }
        public string WeekDayName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditStaffTimingCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteStaffTimingCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteStaffTimingCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region RefferBy
    public class CreateRefferByCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffTypeId { get; set; }
        public string Code { get; set; }
        public int? NamePrefixId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? SpecialityId { get; set; }
        public int? QualificationId { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string Address { get; set; }
        public int OPDPercent { get; set; }
        public int IPDPercent { get; set; }
        public int OPDAmount { get; set; }
        public int IPDAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateRefferByCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditRefferByCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? StaffTypeId { get; set; }
        public string Code { get; set; }
        public int? NamePrefixId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? SpecialityId { get; set; }
        public int? QualificationId { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string Address { get; set; }
        public int OPDPercent { get; set; }
        public int IPDPercent { get; set; }
        public int OPDAmount { get; set; }
        public int IPDAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditRefferByCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteRefferByCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteRefferByCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Patient
    public class CreatePatientCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public int? NamePrefixId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? GenderId { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string? Address { get; set; }

        public int? RefferById { get; set; }

        public string NationalIdCart { get; set; }

        public string? Occupation { get; set; }

        public int? InsuranceId { get; set; }
        public string? InsuranceNumber { get; set; }

        public string? ProposalNumber { get; set; }

        public int? AttachmentId { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreatePatientCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditPatientCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public int? NamePrefixId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? GenderId { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public string? Address { get; set; }

        public int? RefferById { get; set; }

        public string NationalIdCart { get; set; }

        public string? Occupation { get; set; }

        public int? InsuranceId { get; set; }
        public string? InsuranceNumber { get; set; }

        public string? ProposalNumber { get; set; }

        public int? AttachmentId { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditPatientCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeletePatientCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeletePatientCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region OPDBill
    public class CreateOPDBillCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? PatientId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int TotalAmount { get; set; }
        public int PayableAmount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateOPDBillCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditOPDBillCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? PatientId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int TotalAmount { get; set; }
        public int PayableAmount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditOPDBillCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteOPDBillCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteOPDBillCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region OPDBillService
    public class CreateOPDBillServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? OPDBillId { get; set; }
        public int? ServiceId { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }
        public int? StaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateOPDBillServiceCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditOPDBillServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int? OPDBillId { get; set; }
        public int? ServiceId { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }
        public int? StaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditOPDBillServiceCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteOPDBillServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteOPDBillServiceCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

}
