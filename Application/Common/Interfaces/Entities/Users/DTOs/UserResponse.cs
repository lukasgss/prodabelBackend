namespace Application.Common.Interfaces.Entities.Users.DTOs;

public record UserResponse(int Id, string Email, string FullName, string? PhoneNumber, string AccessToken);