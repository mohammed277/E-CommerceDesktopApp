using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Services
{
    public class UserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public User UserRegister(User user)
        {
            if (user is not null && _userRepository.GetByEmail(user.Email) is null)
            {
                var _user = _userRepository.Create(user);
                return _user;
            }
            return null;
        }
        public bool UpdateUser(User user,int id)
        {
            if (user is not null)
            {
                return  _userRepository.Update(user,id);
            }
            return false;
        }
        public bool DeleteUser(User user, int id)
        {
            if (user is not null)
            {
                bool _user =  _userRepository.Delete(user, id);
                _userRepository.Complete();
                return _user;
            }
            return false;
        }
        public IQueryable<User> GetProducts()
        {
            return _userRepository.GetAll();
        }
        public User GetUserById(int id)
        {
            if (id != 0)
            {
                return _userRepository.GetById(id);
            }
            return null;
        }
        public User GetUserByEmail(string email)
        {
            if (email != null)
            {
                return _userRepository.GetByEmail(email);
            }
            return null;
        }
        //public IQueryable<User> SearchByName(string userName)
        //{
        //    if (userName is not null)
        //    {
        //        return _userRepository.SearchByName(userName);
        //    }
        //    return null;
        //}
        public User Login(string Email,string passwrd)
        {
            return _userRepository.Login(Email, passwrd);
        } 
    }
}
