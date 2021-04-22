using RhRecrutamento.Entities;
using RhRecrutamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhRecrutamento.Services.Interface
{
	public interface IVagaService
	{
		IEnumerable<Vaga> GetAll();
		void SaveJobVacancy(VagaRequest modelVaga);
		void EditVacancy(EditarVaga modelVaga);
		void DeleteVacancy(int id);
	}
}
