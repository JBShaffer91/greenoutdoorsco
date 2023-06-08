using System.Threading.Tasks;
using GreenOutdoorsCo.Api.Models;
using GreenOutdoorsCo.Api.DTOs;

namespace GreenOutdoorsCo.Api.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<int>> Register(UserRegisterDto user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        // Task<ServiceResponse<string>> Logout(); // Add this if you plan to implement logout
    }
}
