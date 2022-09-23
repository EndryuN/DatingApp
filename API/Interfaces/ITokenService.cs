using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService//token service created for authenticating users
    {
        string CreateToken(AppUser user);
    }
}