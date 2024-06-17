namespace Application.Common.Interfaces.Entities.ContactMessages.DTOs;

public record ContactMessageResponse(int Id, string Email, string Subject, string Text);