using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser<int>
{
	[Required, MaxLength(255)]
	public string FullName { get; set; } = null!;
}