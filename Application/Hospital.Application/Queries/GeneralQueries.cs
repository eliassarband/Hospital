using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.ViewModels;

namespace Hospital.Application.Queries
{

    #region BasicInformationCategory
    public record GetAllBasicInformationCategoriesQuery : IRequest<List<BasicInformationCategoryViewModel>>
    {

    }

    public record GetViewableBasicInformationCategoriesQuery : IRequest<List<BasicInformationCategoryViewModel>>
    {
        public bool Viewable { get; private set; }

        public GetViewableBasicInformationCategoriesQuery(bool Viewable)
        {
            this.Viewable = Viewable;
        }
    }

    public record GetBasicInformationCategoriesByRelatedCategoryIdQuery : IRequest<List<BasicInformationCategoryViewModel>>
    {
        public int CategoryId { get; private set; }

        public GetBasicInformationCategoriesByRelatedCategoryIdQuery(int CategoryId)
        {
            this.CategoryId = CategoryId;
        }
    }

    public class GetBasicInformationCategoryByIdQuery : IRequest<BasicInformationCategoryViewModel>
    {
        public int Id { get; private set; }

        public GetBasicInformationCategoryByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public class GetBasicInformationCategoryByCodeQuery : IRequest<BasicInformationCategoryViewModel>
    {
        public string Code { get; private set; }

        public GetBasicInformationCategoryByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }
    #endregion

    #region BasicInformation
    public record GetAllBasicInformationsQuery : IRequest<List<BasicInformationViewModel>>
    {

    }

    public record GetBasicInformationsByCategoryIdQuery : IRequest<List<BasicInformationViewModel>>
    {
        public int CategoryId { get; private set; }

        public GetBasicInformationsByCategoryIdQuery(int CategoryId)
        {
            this.CategoryId = CategoryId;
        }
    }

    public class GetBasicInformationsByCategoryCodeQuery : IRequest<List<BasicInformationViewModel>>
    {
        public string CategoryCode { get; private set; }

        public GetBasicInformationsByCategoryCodeQuery(string CategoryCode)
        {
            this.CategoryCode = CategoryCode;
        }
    }

    public class GetActiveBasicInformationsQuery : IRequest<List<BasicInformationViewModel>>
    {
        public bool Active { get; private set; }

        public GetActiveBasicInformationsQuery(bool Active)
        {
            this.Active = Active;
        }
    }

    public class GetBasicInformationsByRelatedBasicInformationIdQuery : IRequest<List<BasicInformationViewModel>>
    {
        public int BasicInformationId { get; private set; }

        public GetBasicInformationsByRelatedBasicInformationIdQuery(int BasicInformationId)
        {
            this.BasicInformationId = BasicInformationId;
        }
    }

    public class GetBasicInformationByIdQuery : IRequest<BasicInformationViewModel>
    {
        public int Id { get; private set; }

        public GetBasicInformationByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public class GetBasicInformationByCodeQuery : IRequest<BasicInformationViewModel>
    {
        public int Code { get; private set; }

        public GetBasicInformationByCodeQuery(int Code)
        {
            this.Code = Code;
        }
    }

    public class GetBasicInformationByStrCodeQuery : IRequest<BasicInformationViewModel>
    {
        public string StrCode { get; private set; }

        public GetBasicInformationByStrCodeQuery(string StrCode)
        {
            this.StrCode = StrCode;
        }
    }
    #endregion

    #region Department
    public record GetAllDepartmentsQuery : IRequest<List<DepartmentViewModel>>
    {

    }

    public record GetAllDepartmentsByMainDepartmentIdQuery : IRequest<List<DepartmentViewModel>>
    {
        public int DepartmentId { get; private set; }

        public GetAllDepartmentsByMainDepartmentIdQuery(int DepartmentId)
        {
            this.DepartmentId = DepartmentId;
        }
    }

    public record GetDepartmentByIdQuery : IRequest<DepartmentViewModel>
    {
        public int Id { get; private set; }

        public GetDepartmentByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetDepartmentByCodeQuery : IRequest<DepartmentViewModel>
    {
        public string Code { get; private set; }

        public GetDepartmentByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }

    public record GetDepartmentByNameQuery : IRequest<DepartmentViewModel>
    {
        public string Name { get; private set; }

        public GetDepartmentByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region Service
    public record GetAllServicesQuery : IRequest<List<ServiceViewModel>>
    {

    }


    public record GetServiceByIdQuery : IRequest<ServiceViewModel>
    {
        public int Id { get; private set; }

        public GetServiceByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetServiceByCodeQuery : IRequest<ServiceViewModel>
    {
        public string Code { get; private set; }

        public GetServiceByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }

    public record GetServiceByNameQuery : IRequest<ServiceViewModel>
    {
        public string Name { get; private set; }

        public GetServiceByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region RoomType
    public record GetAllRoomTypesQuery : IRequest<List<RoomTypeViewModel>>
    {

    }


    public record GetRoomTypeByIdQuery : IRequest<RoomTypeViewModel>
    {
        public int Id { get; private set; }

        public GetRoomTypeByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetRoomTypeByCodeQuery : IRequest<RoomTypeViewModel>
    {
        public string Code { get; private set; }

        public GetRoomTypeByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }

    public record GetRoomTypeByNameQuery : IRequest<RoomTypeViewModel>
    {
        public string Name { get; private set; }

        public GetRoomTypeByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region Room
    public record GetAllRoomsQuery : IRequest<List<RoomViewModel>>
    {

    }


    public record GetRoomByIdQuery : IRequest<RoomViewModel>
    {
        public int Id { get; private set; }

        public GetRoomByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetRoomByCodeQuery : IRequest<RoomViewModel>
    {
        public string Code { get; private set; }

        public GetRoomByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }

    public record GetRoomByNameQuery : IRequest<RoomViewModel>
    {
        public string Name { get; private set; }

        public GetRoomByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region HospitalInformation
    
    public record GetHospitalInformationByIdQuery : IRequest<HospitalInformationViewModel>
    {
        public int Id { get; private set; }

        public GetHospitalInformationByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Attachment
    public record GetAllAttachmentsQuery : IRequest<List<AttachmentViewModel>>
    {

    }


    public record GetAttachmentByIdQuery : IRequest<AttachmentViewModel>
    {
        public int Id { get; private set; }

        public GetAttachmentByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetAttachmentByNameQuery : IRequest<AttachmentViewModel>
    {
        public string Name { get; private set; }

        public GetAttachmentByNameQuery(string Name)
        {
            this.Name = Name;
        }
    }

    #endregion

    #region ReportTemplate
    public record GetAllReportTemplatesQuery : IRequest<List<ReportTemplateViewModel>>
    {

    }


    public record GetReportTemplateByIdQuery : IRequest<ReportTemplateViewModel>
    {
        public int Id { get; private set; }

        public GetReportTemplateByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public record GetReportTemplateByCodeQuery : IRequest<ReportTemplateViewModel>
    {
        public string Code { get; private set; }

        public GetReportTemplateByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }


    #endregion
}
