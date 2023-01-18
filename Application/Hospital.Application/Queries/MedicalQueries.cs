﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Application.ViewModels;

namespace Hospital.Application.Queries
{


    #region Insurance
    public record GetAllInsurancesQuery : IRequest<List<InsuranceViewModel>>
    {

    }

    public record GetInsurancesByPaymentTypeQuery : IRequest<List<InsuranceViewModel>>
    {
        public int PaymentTypeId { get; private set; }

        public GetInsurancesByPaymentTypeQuery(int PaymentTypeId)
        {
            this.PaymentTypeId = PaymentTypeId;
        }
    }


    public class GetInsuranceByIdQuery : IRequest<InsuranceViewModel>
    {
        public int Id { get; private set; }

        public GetInsuranceByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public class GetInsuranceByCodeQuery : IRequest<InsuranceViewModel>
    {
        public string Code { get; private set; }

        public GetInsuranceByCodeQuery(string Code)
        {
            this.Code = Code;
        }
    }


    #endregion

    #region InsuranceAgreement
    public record GetAllInsuranceAgreementsQuery : IRequest<List<InsuranceAgreementViewModel>>
    {

    }

    public record GetInsuranceAgreementsByInsuranceIdQuery : IRequest<List<InsuranceAgreementViewModel>>
    {
        public int InsuranceId { get; private set; }

        public GetInsuranceAgreementsByInsuranceIdQuery(int InsuranceId)
        {
            this.InsuranceId = InsuranceId;
        }
    }

    public class GetInsuranceAgreementByIdQuery : IRequest<InsuranceAgreementViewModel>
    {
        public int Id { get; private set; }

        public GetInsuranceAgreementByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Staff
    public record GetAllStaffsQuery : IRequest<List<StaffViewModel>>
    {

    }

    public record GetStaffsByStaffTypeIdQuery : IRequest<List<StaffViewModel>>
    {
        public int StaffTypeId { get; private set; }

        public GetStaffsByStaffTypeIdQuery(int StaffTypeId)
        {
            this.StaffTypeId = StaffTypeId;
        }
    }


    public class GetStaffByIdQuery : IRequest<StaffViewModel>
    {
        public int Id { get; private set; }

        public GetStaffByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region StaffTiming
    public record GetAllStaffTimingsQuery : IRequest<List<StaffTimingViewModel>>
    {

    }

    public record GetStaffTimingsByStaffIdQuery : IRequest<List<StaffTimingViewModel>>
    {
        public int StaffId { get; private set; }

        public GetStaffTimingsByStaffIdQuery(int StaffId)
        {
            this.StaffId = StaffId;
        }
    }


    public class GetStaffTimingByIdQuery : IRequest<StaffTimingViewModel>
    {
        public int Id { get; private set; }

        public GetStaffTimingByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region RefferBy
    public record GetAllRefferBiesQuery : IRequest<List<RefferByViewModel>>
    {

    }

    public record GetRefferBiesByStaffTypeIdQuery : IRequest<List<RefferByViewModel>>
    {
        public int StaffTypeId { get; private set; }

        public GetRefferBiesByStaffTypeIdQuery(int StaffTypeId)
        {
            this.StaffTypeId = StaffTypeId;
        }
    }


    public class GetRefferByByIdQuery : IRequest<RefferByViewModel>
    {
        public int Id { get; private set; }

        public GetRefferByByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    #endregion

    #region Patient
    public record GetAllPatientsQuery : IRequest<List<PatientViewModel>>
    {

    }


    public class GetPatientByIdQuery : IRequest<PatientViewModel>
    {
        public int Id { get; private set; }

        public GetPatientByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public class GetPatientByNationalIdQuery : IRequest<PatientViewModel>
    {
        public string NationalId { get; private set; }

        public GetPatientByNationalIdQuery(string NationalId)
        {
            this.NationalId = NationalId;
        }
    }

    #endregion
}