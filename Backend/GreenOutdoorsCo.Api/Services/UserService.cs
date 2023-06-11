using System;
using System.Threading.Tasks;
using GreenOutdoorsCo.Api.Data;
using GreenOutdoorsCo.Api.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GreenOutdoorsCo.Api.Services
{
  public class UserService : IUserService
  {
    private readonly GreenOutdoorsDbContext _context;
    
    public UserService(GreenOutdoorsDbContext context) 
    {
      _context = context;
    }

    public async Task<ServiceResponse<int>> Register(UserRegisterDto user, string password)
    {
      // You can now use the _context to interact with your database
      if (await _context.Users.AnyAsync(u => u.Username == user.Username)) // <- Using _context to check if a user exists in the database
      {
        throw new Exception("User already exists");
      }
      // Implement your registration logic here
      throw new NotImplementedException();
    }

    public async Task<ServiceResponse<string>> Login(string username, string password)
    {
      // You can also use _context here to check the user's credentials against the database
      var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
      if (user == null)
      {
        throw new Exception("User not found");
      }
      // Implement your login logic here
      throw new NotImplementedException();
    }

    // public Task<ServiceResponse<string>> Logout()
    // {
    //     throw new NotImplementedException();
    //     // Implement your logout logic here
    // }
  }
}
