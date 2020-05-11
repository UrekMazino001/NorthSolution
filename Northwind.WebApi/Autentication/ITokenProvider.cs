using System;
using Northwind.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Autentication
{
    public interface ITokenProvider
    {
        //Token usado ppara validar el usuario, será lanzado por cada Request que envie. 
        string CreateToken(User user, DateTime expiry);

        //Método para validar los Tokens que vienen en los request.
        TokenValidationParameters GetValidationParameters();

    }
}
