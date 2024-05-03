using System.ComponentModel.DataAnnotations;

namespace Application.Common.Interfaces.Entities.Users.DTOs;

public record CreateUserRequest(
	string FullName,
	string PhoneNumber,
	string Email,
	string Password,
	string ConfirmPassword);