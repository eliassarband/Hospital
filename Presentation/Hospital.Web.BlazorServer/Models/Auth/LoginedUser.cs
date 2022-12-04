namespace Hospital.Web.BlazorServer.Models.Auth
{
    public class LoginedUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
    }
}
