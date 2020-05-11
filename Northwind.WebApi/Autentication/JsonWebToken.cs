using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Autentication
{
    //Propiedas que se retornaran cuando el usuario se logea.
    public class JsonWebToken
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; } = "bearear";
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
    }
}
