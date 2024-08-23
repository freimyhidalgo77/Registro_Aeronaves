using System.ComponentModel.DataAnnotations;
namespace RegistroAeronaves.Models
{
	public class Aeronaves
	{
		[Key]
		public int AeronavesId { get; set; }

		[Required(ErrorMessage =  "Campo tipo de aeronave obligatorio")]
		public string TipoAeronave { get; set; }

		[Required(ErrorMessage = "Campo aerolinea obligatorio")]
		  
		public string Aerolinea { get; set; }

		[Required(ErrorMessage = "Campo matricula obligatorio")]

		public string Matricula { get; set; }

		[Required(ErrorMessage = "Campo capacidad obligatorio")]

		public int capacidad { get; set; }


	}
}
