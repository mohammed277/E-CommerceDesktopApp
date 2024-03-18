using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Contracts
{
    public interface IUserRepository :IBaseRepository<User>
    {
        User GetByEmail(string email);
        User Login(string email, string password);

    }
}
