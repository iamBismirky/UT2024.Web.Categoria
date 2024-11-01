namespace UT2024P4LP4.Web.Data.Dtos;

public record CategoriaDto(int Id = 0, string? Nombre = null)
{

	public int Id { get; set; }
	public string Nombre { get; set; } = null!;

	public CategoriaRequest ToRequest()
	=> new()
	{
		Id = this.Id,
		Nombre = this.Nombre


	};
};
public class CategoriaRequest
{
	public int Id { get; set; } = 0;
	public string Nombre { get; set; } = "";
}