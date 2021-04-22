using RhRecrutamento.Entities;
using RhRecrutamento.Models;
using System.Collections.Generic;

namespace RhRecrutamento.Services.Interface
{
	public interface ICandidatoService
	{
		void EditCandidate(EditarCandidato modelCandidato);
		IEnumerable<Candidato> GetAllCandidate();
		void SaveCandidate(CandidatoRequest modelCandidato);
		void DeleteCandidate(int id);
	}
}
