namespace Application.Common.Interfaces.Entities.ContactMessages.DTOs;

public record CreateContactMessage(string Email, string Subject, string Text);