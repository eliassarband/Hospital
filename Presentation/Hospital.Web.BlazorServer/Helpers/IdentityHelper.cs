using Hospital.Application.Queries;
using Hospital.Web.BlazorServer.Models.Auth;
using MediatR;
using MudBlazor;
using System.Data;

namespace Hospital.Web.BlazorServer.Helpers
{
    public class IdentityHelper
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly IMediator _mediator;

        public IdentityHelper(IHttpContextAccessor accessor, IMediator mediator)
        {
            _accessor = accessor;
            _mediator = mediator;
        }

        public async Task<LoginedUser> GetUserInfo()
        {
            LoginedUser userInfo=new LoginedUser();

            if (_accessor.HttpContext != null)
            {

                if (_accessor.HttpContext.User.Identity.IsAuthenticated)
                {
                    string username = _accessor.HttpContext.User.Identity.Name;
                    if (!String.IsNullOrEmpty(username))
                    {
                        userInfo = new LoginedUser();
                        userInfo.Username = username;

                        var user =await _mediator.Send(new GetUserByUsernameQuery(username));
                        if (user != null)
                        {
                            userInfo.UserId = user.Id;
                            userInfo.FullName = user.FullName();
                            userInfo.ThemeName = user.Theme;

                        }


                    }

                }
            }

            return userInfo;
        }
    }
}
