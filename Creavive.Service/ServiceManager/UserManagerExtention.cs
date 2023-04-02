using System;
using System.Security.Claims;
using Creative.Domain;
using Microsoft.AspNetCore.Identity;

namespace Creavive.Service.ServiceManager;

public static class UserManagerExtention
{
	public static async Task<AppUserObj> FetchUserPrincipalAsync(this UserManager<AppUserObj> input, ClaimsPrincipal user)
	{
		var email = user?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

		var result = input.Users.FirstOrDefault(e => e.Email == email, new AppUserObj());

        return await  Task.FromResult(result);
	}

}

