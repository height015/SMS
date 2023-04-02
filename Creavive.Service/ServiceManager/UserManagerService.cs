using System.Security.Claims;
using Creative.Domain;
using Creative.Domain.Models;
using Creavive.Service.Contacts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Creavive.Service.ServiceManager
{
    public class UserManagerService : IAppUserService
    {

        private readonly UserManager<AppUserObj> _userManager;

        private readonly SignInManager<AppUserObj> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserManagerService(UserManager<AppUserObj> userManager, SignInManager<AppUserObj> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }


        public Task<AppUserObj> Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetUsersCount()
        {
            try
            {
                var result = _userManager.Users.Count();

                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                var check = ex.Message;
                return 0;
            }

        }

        public async Task<List<AppUserObj>> Load()
        {
            var userList = _userManager.Users.ToList();

            return await Task.FromResult(userList);

        }

        public async Task<UserVMs> Login(UserLoginObj userLoginObj)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(userLoginObj.Email))
            //{

            //}
            //try
            //{
            //    var Emailresult = await _userManager.FindByEmailAsync(userLoginObj.Email);
            //    if (Emailresult == null)
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        public Task<AppUserRespObj> Register(AppUserObj appUserObj)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetCurrentUserId()
        {
            var result = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            return await Task.FromResult(result) ?? string.Empty;
        }

        Task<List<ParentsObj>> IAppUserService.Load()
        {
            throw new NotImplementedException();
        }

        //public async Task<string> GetCurrentUserEmail()
        //{
        //    return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
        //}

        //public async Task<IEnumerable<string>> GetCurrentUserRoles()
        //{
        //    return _httpContextAccessor.HttpContext.User.FindAll(ClaimTypes.Role).Select(c => c.Value);
        //}
    }
}

