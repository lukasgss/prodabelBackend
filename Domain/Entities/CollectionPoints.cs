using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class CollectionPoint
{
    public int Id { get; set; }
    
    [Required, MaxLength(30)]
    public string Cep { get; set; } = null!;

    [Required, MaxLength(100)] 
    public string Address { get; set; } = null!;
    
    [Required] 
    public int Number { get; set; }

    [Required, ForeignKey("CompanyId")] 
    public Company Company { get; set; } = null!;

    public int CompanyId { get; set; }
}