using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.ViewModels;

namespace Hospital.Application.Queries
{
    
    #region Department
    public record GetAllDepartmentsQuery : IRequest<List<DepartmentViewModel>>
    {

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
}
