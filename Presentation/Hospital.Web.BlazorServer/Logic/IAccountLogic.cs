using Hospital.Application.ViewModels;
using Hospital.Web.BlazorServer.Models.Auth;

namespace Hospital.Web.BlazorServer.Logic
{
    public interface IAccountLogic
    {
        Task<string> UserLoginAsyn(LoginVm loginVm);

        Task<HospitalInformationViewModel> GetHospitalInformation(int Id);
    }
}
