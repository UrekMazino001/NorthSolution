using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        //Metodo para validar los usuarios en la BD
        User ValidateUser(string email, string password);
    }
}
