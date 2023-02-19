using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.Responses;
using Hospital.Application.ViewModels;

namespace Hospital.Application.Commands
{

    #region BasicInformationCategory
    public class CreateBasicInformationCategoryCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Viewable { get; set; }
        public int? RelatedCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateBasicInformationCategoryCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditBasicInformationCategoryCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Viewable { get; set; }
        public int? RelatedCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditBasicInformationCategoryCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteBasicInformationCategoryCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteBasicInformationCategoryCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region BasicInformation
    public class CreateBasicInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string StrCode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Priority { get; set; }
        public int? RelatedBasicInformationId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowChange { get; set; }
        public bool AllowDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }

        public CreateBasicInformationCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditBasicInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string StrCode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Priority { get; set; }
        public int? RelatedBasicInformationId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowChange { get; set; }
        public bool AllowDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }

        public EditBasicInformationCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteBasicInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteBasicInformationCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Department
    public class CreateDepartmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int? MainDepartmentId { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedDepartment { get; set; }

        public CreateDepartmentCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditDepartmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int? MainDepartmentId { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedDepartment { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedDepartment { get; set; }

        public EditDepartmentCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteDepartmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteDepartmentCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Service
    public class CreateServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int OPDRate { get; set; }
        public int IPDRate { get; set; }
        public int AddPercentage { get; set; }
        public int AddAmount { get; set; }
        public int DiscountPercentage { get; set; }
        public int DiscountAmount { get; set; }
        public string Remark { get; set; }
        public int Cost { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedService { get; set; }

        public CreateServiceCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int OPDRate { get; set; }
        public int IPDRate { get; set; }
        public int AddPercentage { get; set; }
        public int AddAmount { get; set; }
        public int DiscountPercentage { get; set; }
        public int DiscountAmount { get; set; }
        public string Remark { get; set; }
        public int Cost { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedService { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedService { get; set; }

        public EditServiceCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteServiceCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteServiceCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region RoomType
    public class CreateRoomTypeCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string? Ward { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRoomType { get; set; }

        public CreateRoomTypeCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditRoomTypeCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string? Ward { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRoomType { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedRoomType { get; set; }

        public EditRoomTypeCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteRoomTypeCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteRoomTypeCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Room
    public class CreateRoomCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? RoomTypeId { get; set; }
        public int Rest { get; set; }
        public int Cost { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRoom { get; set; }

        public CreateRoomCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditRoomCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? RoomTypeId { get; set; }
        public int Rest { get; set; }
        public int Cost { get; set; }
        public bool NotInUse { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedRoom { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedRoom { get; set; }

        public EditRoomCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteRoomCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteRoomCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region HospitalInformation
    public class CreateHospitalInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public byte[] Logo { get; set; }
        public byte[] WhiteLogo { get; set; }
        public string? RegisterationNumber { get; set; }
        public string? Email { get; set; }
        public string? BackupDirectory1 { get; set; }
        public string? BackupDirectory2 { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencySymbol { get; set; }
        public string? CurrencyCents { get; set; }
        public int SessionTimeout { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedHospitalInformation { get; set; }

        public CreateHospitalInformationCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditHospitalInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public byte[] Logo { get; set; }
        public byte[] WhiteLogo { get; set; }
        public string? RegisterationNumber { get; set; }
        public string? Email { get; set; }
        public string? BackupDirectory1 { get; set; }
        public string? BackupDirectory2 { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencySymbol { get; set; }
        public string? CurrencyCents { get; set; }
        public int SessionTimeout { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedHospitalInformation { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedHospitalInformation { get; set; }

        public EditHospitalInformationCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteHospitalInformationCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteHospitalInformationCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Attachment
    public class CreateAttachmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Extension { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedAttachment { get; set; }

        public CreateAttachmentCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditAttachmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Extension { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedAttachment { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedAttachment { get; set; }

        public EditAttachmentCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteAttachmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteAttachmentCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region ReportTemplate
    public class CreateReportTemplateCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedReportTemplate { get; set; }

        public CreateReportTemplateCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }

    public class EditReportTemplateCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedReportTemplate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedReportTemplate { get; set; }

        public EditReportTemplateCommand()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }

    public class DeleteReportTemplateCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }

        public DeleteReportTemplateCommand(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion
}
