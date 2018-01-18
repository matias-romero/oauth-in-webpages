using System;
using System.Security.Claims;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.Owin.Security;
using WebPagesWithOwinAuth.Storage;

namespace WebPagesWithOwinAuth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignIn(string username, string password)
        {
            var userRepository = new UsersRepository();
            var user = userRepository.FindUserForAuthentication(username, password);
            if (user != null)
            {
                var userIdentity = this.MapDomainUserToClaimsIdentity(user);

                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                authenticationManager.SignIn(new AuthenticationProperties { IsPersistent = false }, userIdentity);

                Response.Redirect("~/Default");
            }
        }

        protected ClaimsIdentity MapDomainUserToClaimsIdentity(User user)
        {
            return new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Admin")
            }, Microsoft.Owin.Security.Cookies.CookieAuthenticationDefaults.AuthenticationType);
        }

        protected void LoginCtrl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            this.SignIn(this.LoginCtrl.UserName, this.LoginCtrl.Password);
        }
    }
}