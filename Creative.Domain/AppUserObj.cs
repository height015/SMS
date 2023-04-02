using System;
using Microsoft.AspNetCore.Identity;

namespace Creative.Domain;

public class AppUserObj : IdentityUser
{
	public bool Active { get; set; }
	public string LastIpAddress { get; set; }
	public DateTime CreatedOnUtc { get; set; }
	
}
public class UserLoginObj
{
    public string Email { get; set; }
    public string Password { get; set; }

}

public class AppUserRespObj
{
    public bool IsSuccessful { get; set; }
    public string UserId { get; set; }
    public ResponseObj ResponseError { get; set; }
}


//public enum UserTypeRegistration
//{
//Standard =1,
//EmailValidation=2,
//AdminApproval=3,
//Disabled=4

//}
