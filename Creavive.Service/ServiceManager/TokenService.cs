using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Creative.Domain;
using Creavive.Service.Contacts;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Creavive.Service.ServiceManager;

public class TokenService : ITokenService
{
    private readonly SymmetricSecurityKey _symmetricSecurityKey;
    private readonly IConfiguration _configuration;

    public TokenService(SymmetricSecurityKey symmetricSecurityKey, IConfiguration configuration)
    {
        _symmetricSecurityKey = symmetricSecurityKey;
        _configuration = configuration;

    }
    public string GenerateToken(AppUserObj appUserObj)
    {
        var claims = new List<Claim>
        {
            //new Claim(ClaimTypes.NameIdentifier, appUserObj.Id.ToString()),
            new Claim(ClaimTypes.Email, appUserObj.Email),
            new Claim(ClaimTypes.GivenName, appUserObj.UserName),
           //new Claim(ClaimTypes.Role, this.),
    };

        var creds = new SigningCredentials(_symmetricSecurityKey, SecurityAlgorithms.HmacSha512Signature);
        var tokenDescription = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(7),
            SigningCredentials = creds,
            Issuer = _configuration["Token:Issuer"]
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescription);

        return tokenHandler.WriteToken(token);
    }

    public void InvalidateJwtToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:Issuer"]));
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateIssuer = false,
            ValidateAudience = false
        };
        SecurityToken validatedToken;
        var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
        // You can add the validated token to a blacklist or revoke it in the database
    }

}

