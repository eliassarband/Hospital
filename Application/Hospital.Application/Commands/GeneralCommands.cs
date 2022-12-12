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
    
    #region Department
    public class CreateDepartmentCommand : IRequest<CommandResponse>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public string MainDeptartment { get; set; }
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
        public string MainDeptartment { get; set; }
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
}
