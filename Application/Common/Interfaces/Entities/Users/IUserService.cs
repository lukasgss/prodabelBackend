using Application.Common.Interfaces.Entities.Users.DTOs;

namespace Application.Common.Interfaces.Entities.Users;

public interface IUserService
{
	Task<UserDataResponse> GetUserByIdAsync(int userId);
	Task<UserResponse> RegisterAsync(CreateUserRequest createCreateUserRequest);
	Task<UserDataResponse> EditAsync(EditUserRequest editUserRequest, int userId, int loggedInUserAsync);
	Task<UserResponse> LoginAsync(UserLoginRequest userLoginRequest);
}