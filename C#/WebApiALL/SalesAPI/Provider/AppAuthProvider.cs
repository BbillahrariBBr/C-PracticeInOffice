using Microsoft.Owin.Security.OAuth;
using SalesAPI.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace SalesAPI.Provider
{
    public class AppAuthProvider : OAuthAuthorizationServerProvider
    {
        public override  async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
           using(UserRepo repo = new UserRepo())
            {
                var user = repo.ValidateUser(context.UserName, context.Password);  
                if(user == null) {
                    context.SetError("invalid_grant", "User name or password is incorrect");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name,user.u_LoginName));
                context.Validated(identity);
            }
        }
    }
}