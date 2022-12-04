using Hospital.Application.Mapper;
using Hospital.Application.Queries;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Entities;
using Hospital.Domain.Core.Repositories.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.Handlers.QueryHandlers
{

    #region Department

    public class GetAllDepartmentsHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentViewModel>>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetAllDepartmentsHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<List<DepartmentViewModel>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            List<Department> Departments = (List<Department>)await _DepartmentQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<DepartmentViewModel>>(Departments);
        }
    }

    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByIdHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetDepartmentByCodeHandler : IRequestHandler<GetDepartmentByCodeQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByCodeHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetDepartmentByNameHandler : IRequestHandler<GetDepartmentByNameQuery, DepartmentViewModel>
    {
        private readonly IDepartmentQueryRepository _DepartmentQueryRepository;

        public GetDepartmentByNameHandler(IDepartmentQueryRepository DepartmentQueryRepository)
        {
            _DepartmentQueryRepository = DepartmentQueryRepository;
        }

        public async Task<DepartmentViewModel> Handle(GetDepartmentByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<DepartmentViewModel>(await _DepartmentQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region Service

    public class GetAllServicesHandler : IRequestHandler<GetAllServicesQuery, List<ServiceViewModel>>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetAllServicesHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<List<ServiceViewModel>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            List<Service> Services = (List<Service>)await _ServiceQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<ServiceViewModel>>(Services);
        }
    }

    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByIdHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetServiceByCodeHandler : IRequestHandler<GetServiceByCodeQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByCodeHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetServiceByNameHandler : IRequestHandler<GetServiceByNameQuery, ServiceViewModel>
    {
        private readonly IServiceQueryRepository _ServiceQueryRepository;

        public GetServiceByNameHandler(IServiceQueryRepository ServiceQueryRepository)
        {
            _ServiceQueryRepository = ServiceQueryRepository;
        }

        public async Task<ServiceViewModel> Handle(GetServiceByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<ServiceViewModel>(await _ServiceQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region RoomType

    public class GetAllRoomTypesHandler : IRequestHandler<GetAllRoomTypesQuery, List<RoomTypeViewModel>>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetAllRoomTypesHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<List<RoomTypeViewModel>> Handle(GetAllRoomTypesQuery request, CancellationToken cancellationToken)
        {
            List<RoomType> RoomTypes = (List<RoomType>)await _RoomTypeQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RoomTypeViewModel>>(RoomTypes);
        }
    }

    public class GetRoomTypeByIdHandler : IRequestHandler<GetRoomTypeByIdQuery, RoomTypeViewModel>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByIdHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<RoomTypeViewModel> Handle(GetRoomTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomTypeViewModel>(await _RoomTypeQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetRoomTypeByCodeHandler : IRequestHandler<GetRoomTypeByCodeQuery, RoomTypeViewModel>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByCodeHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<RoomTypeViewModel> Handle(GetRoomTypeByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomTypeViewModel>(await _RoomTypeQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetRoomTypeByNameHandler : IRequestHandler<GetRoomTypeByNameQuery, RoomTypeViewModel>
    {
        private readonly IRoomTypeQueryRepository _RoomTypeQueryRepository;

        public GetRoomTypeByNameHandler(IRoomTypeQueryRepository RoomTypeQueryRepository)
        {
            _RoomTypeQueryRepository = RoomTypeQueryRepository;
        }

        public async Task<RoomTypeViewModel> Handle(GetRoomTypeByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomTypeViewModel>(await _RoomTypeQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

    #region Room

    public class GetAllRoomsHandler : IRequestHandler<GetAllRoomsQuery, List<RoomViewModel>>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetAllRoomsHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<List<RoomViewModel>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
        {
            List<Room> Rooms = (List<Room>)await _RoomQueryRepository.GetAllAsync();

            return MapperConfig.Mapper.Map<List<RoomViewModel>>(Rooms);
        }
    }

    public class GetRoomByIdHandler : IRequestHandler<GetRoomByIdQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByIdHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByIdAsync(request.Id));
        }
    }

    public class GetRoomByCodeHandler : IRequestHandler<GetRoomByCodeQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByCodeHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByCodeQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByCodeAsync(request.Code));
        }
    }

    public class GetRoomByNameHandler : IRequestHandler<GetRoomByNameQuery, RoomViewModel>
    {
        private readonly IRoomQueryRepository _RoomQueryRepository;

        public GetRoomByNameHandler(IRoomQueryRepository RoomQueryRepository)
        {
            _RoomQueryRepository = RoomQueryRepository;
        }

        public async Task<RoomViewModel> Handle(GetRoomByNameQuery request, CancellationToken cancellationToken)
        {
            return MapperConfig.Mapper.Map<RoomViewModel>(await _RoomQueryRepository.GetByNameAsync(request.Name));
        }
    }

    #endregion

}
