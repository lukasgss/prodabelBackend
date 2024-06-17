namespace Domain.Entities;

public class ContactMessage
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Text { get; set; } = null!;
}