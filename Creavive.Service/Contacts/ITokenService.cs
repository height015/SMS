using System;
using Creative.Domain;

namespace Creavive.Service.Contacts;

public interface ITokenService
{
    string GenerateToken(AppUserObj appUserObj);
    void InvalidateJwtToken(string token); 
}

