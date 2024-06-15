using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Company
{
	public int Id { get; set; }

	[Required, MaxLength(255)]
	public string Name { get; set; } = null!;

	[Required, MaxLength(20)]
	public string Cep { get; set; } = null!;
	
	[Required, MaxLength(100)]
	public string Address { get; set; } = null!;
	public int AddressNumber { get; set; }

	public CollectionLine? CollectionLine { get; set; }

	public List<CollectionPoint> CollectionPoints { get; set; } = [];

	[Required, MaxLength(50)]
	public string Cnpj { get; set; } = null!;

	[Required, MaxLength(20)]
	public string CepDeliveryInitialRange { get; set; } = null!;

	[Required, MaxLength(20)]
	public string CepDeliveryEndRange { get; set; } = null!;

	[Required, MaxLength(40)] 
	public string PhoneNumber { get; set; } = null!;

	[ForeignKey("OwnerId")]
	public virtual User Owner { get; set; } = null!;

	public int OwnerId { get; set; }
}