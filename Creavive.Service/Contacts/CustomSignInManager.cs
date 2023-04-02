//using Creative.Domain;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;

//public class CustomSignInManager : SignInManager<AppUserObj>
//{
//    public CustomSignInManager(UserManager<AppUserObj> userManager,
//                               IHttpContextAccessor contextAccessor,
//                               IUserClaimsPrincipalFactory<AppUserObj> claimsFactory,
//                               IOptions<IdentityOptions> optionsAccessor,
//                               ILogger<SignInManager<AppUserObj>> logger,
//                               IAuthenticationSchemeProvider schemes)
//        : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
//    {
//    }

//    // Override the SignInAsync method
//    public override async Task SignInAsync(AppUserObj user, bool isPersistent, string authenticationMethod = null)
//    {
//        // Your custom sign in logic here
//        await base.SignInAsync(user, isPersistent, authenticationMethod);
//    }

//    // Override the SignOutAsync method
//    public override async Task SignOutAsync()
//    {
//        // Your custom sign out logic here
//        await base.SignOutAsync();
//    }
//}


////public interface ICustomUserManager
////{
////    Task<IdentityResult> RegisterAsync(ApplicationUser user, string password);
////    Task<ApplicationUser> FindByEmailAsync(string email);
////}
