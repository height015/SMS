using System;
using Creative.Domain;
using Creative.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace Creavive.Service.Contacts;

public interface IAppUserService
{
	Task<int> GetUsersCount();

	Task<List<ParentsObj>>Load();

	Task<AppUserObj> Fetch(int id);

    Task<AppUserRespObj> Register(AppUserObj appUserObj);

    Task<UserVMs> Login(UserLoginObj userLoginObj);

    //Task<AppUserObj> GetCurrentUser(IHttpContextAccessor httpContextAccessor);

    Task<string> GetCurrentUserId();

}

