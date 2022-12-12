using System.Security.Claims;
using Hospital.Application.Queries;
using Hospital.Application.ViewModels;
using Hospital.Domain.Core.Helpers;
using Hospital.Web.BlazorServer.Models.Auth;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Web.BlazorServer.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _accessor;

        public AccountLogic(IMediator mediator,
            IHttpContextAccessor accessor)
        {
            _mediator = mediator;
            _accessor = accessor;
        }

        public async Task<HospitalInformationViewModel> GetHospitalInformation(int Id)
        { 
            return await _mediator.Send(new GetHospitalInformationByIdQuery(Id));
        }
        public async Task<string> UserLoginAsyn(LoginVm loginVm)
        {
            UserViewModel user = await _mediator.Send(new GetUserByUsernameQuery(loginVm.Username));

            if (user == null)
            {
                return "Invalid Username";
            }

            if (!CryptographyHelper.ValidatePassword(loginVm.Password, user.Password))
            {
                return "Invalid Password";
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            //claims.Add(new Claim(ClaimTypes.Role, user.Role.Code));

            foreach (var userRole in user.UserRoles)
            {
                
                claims.Add(new Claim(ClaimTypes.Role, userRole.Role.Code));
            }



            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
                { };

            await _accessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return string.Empty;
        }
    }
}
