using Application.Common.Interfaces.Entities.Users.DTOs;
using Domain.Entities;

namespace Application.Common.Extensions.Mapping;

public static class UserMappings
{
	public static UserDataResponse ToUserDataResponse(this User user)
	{
		return new UserDataResponse(
			Id: user.Id,
			Email: user.Email!,
			FullName: user.FullName,
			PhoneNumber: user.PhoneNumber);
	}

	public static UserResponse ToUserResponse(this User user, string jwtToken)
	{
		return new UserResponse(
			Id: user.Id,
			Email: user.Email!,
			FullName: user.FullName,
			PhoneNumber: user.PhoneNumber,
			AccessToken: jwtToken);
	}
}