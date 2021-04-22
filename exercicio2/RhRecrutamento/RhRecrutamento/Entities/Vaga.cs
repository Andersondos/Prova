using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RhRecrutamento.Entities
{
	public class Vaga
	{
		[Key]
		public int Id { get; set; }
		public string Empresa { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Responsavel { get; set; }
		public string Tecnologia { get; set; }
		public string DataCadastro { get; set; }
		public string? Observacao { get; set; }
	}
}
