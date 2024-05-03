namespace Application.Common.Interfaces.Entities.Users.DTOs;

public record UserDataResponse(int Id, string Email, string FullName, string? PhoneNumber);