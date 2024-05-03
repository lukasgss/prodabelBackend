using Application.Common.Interfaces.GenericRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Common.Interfaces.Entities.Users;

public interface IUserRepository : IGenericRepository<User>
{
	Task<SignInResult> CheckCredentials(User user, string password);
	Task<IdentityResult> RegisterUserAsync(User user, string password);
	Task<User?> GetUserByEmailAsync(string email);
	Task<User?> GetUserByIdAsync(int userId);
}