using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RhRecrutamento.Models
{
	public class EditarVaga
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "A Empresa é obrigatória")]
		public string Empresa { get; set; }

		[Required(ErrorMessage = "O Endereco é obrigatório")]
		public string Endereco { get; set; }

		[Required(ErrorMessage = "O Telefone é obrigatório")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "O Email é obrigatório")]
		[RegularExpression("(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$)", ErrorMessage = "O email inserido não parece ser inválido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "As Tecnologias é obrigatória")]
		public string Tecnologia { get; set; }

		[Required(ErrorMessage = "O Responsável é obrigatório")]
		public string Responsavel { get; set; }

		public string? Observacao { get; set; }
	}
}
