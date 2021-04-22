
using System.ComponentModel.DataAnnotations;

namespace RhRecrutamento.Models
{
	public class EditarCandidato
	{
		[Required(ErrorMessage = "O Id é obrigatório")]
		public int Id { get; set; }
		[Required(ErrorMessage = "O Nome é obrigatório")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O Endereco é obrigatório")]
		public string Endereco { get; set; }

		[Required(ErrorMessage = "O Telefone é obrigatório")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "O Email é obrigatório")]
		[RegularExpression("(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$)", ErrorMessage = "O email inserido não parece ser inválido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O Cargo é obrigatório")]
		public string Cargo { get; set; }

		[Required(ErrorMessage = "A experiência é obrigatória")]
		public string Experiencia { get; set; }

		[Required(ErrorMessage = "As Tecnologias é obrigatória")]
		public string Tecnologia { get; set; }

		public string? Observacao { get; set; }
	}
}
