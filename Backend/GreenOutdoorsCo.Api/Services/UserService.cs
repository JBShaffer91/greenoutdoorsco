using System;
using System.Threading.Tasks;
using GreenOutdoorsCo.Api.Models;
using GreenOutdoorsCo.Api.DTOs;

namespace GreenOutdoorsCo.Api.Services
{
    public class UserService : IUserService
    {
        public Task<ServiceResponse<int>> Register(UserRegisterDto user, string password)
        {
            throw new NotImplementedException();
            // Implement your registration logic here
        }

        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
            // Implement your login logic here
        }

        // public Task<ServiceResponse<string>> Logout()
        // {
        //     throw new NotImplementedException();
        //     // Implement your logout logic here
        // }
    }
}
