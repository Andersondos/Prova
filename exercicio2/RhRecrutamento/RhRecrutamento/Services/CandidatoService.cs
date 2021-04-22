using Microsoft.Extensions.Options;
using RhRecrutamento.Data;
using RhRecrutamento.Entities;
using RhRecrutamento.Helpers;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RhRecrutamento.Services
{
	public class CandidatoService : ICandidatoService
	{
		private readonly DataContext _context;
		private readonly AppSettings _appSettings;

		public CandidatoService(DataContext context,
						   IOptions<AppSettings> appSettings)
		{
			_context = context;
			_appSettings = appSettings.Value;
		}

		public void DeleteCandidate(int id)
		{
			Candidato candidato = _context.Candidatos.Where(cd => cd.Id == id).FirstOrDefault();
			_context.Candidatos.Remove(candidato);
			_context.SaveChanges();
		}

		public void EditCandidate(EditarCandidato modelCandidato)
		{
			Candidato candidato = _context.Candidatos.Where(cd => cd.Id == modelCandidato.Id).FirstOrDefault();

			candidato.Nome = modelCandidato.Nome;
			candidato.Endereco = modelCandidato.Endereco;
			candidato.Telefone = modelCandidato.Telefone;
			candidato.Email = modelCandidato.Email;
			candidato.Cargo = modelCandidato.Cargo;
			candidato.Experiencia = modelCandidato.Experiencia;
			candidato.Tecnologia = modelCandidato.Tecnologia;
			candidato.Observacao = modelCandidato.Observacao; 

			_context.Update(candidato);
			_context.SaveChanges();
		}

		public IEnumerable<Candidato> GetAllCandidate()
		{
			return _context.Candidatos.ToList();
		}

		public void SaveCandidate(CandidatoRequest modelCandidato)
		{
			Candidato candidato = new Candidato()
			{
				Nome = modelCandidato.Nome,
				Endereco = modelCandidato.Endereco,
				Telefone = modelCandidato.Telefone,
				Email = modelCandidato.Email,
				Cargo = modelCandidato.Cargo,
				Experiencia = modelCandidato.Experiencia,
				Tecnologia = modelCandidato.Tecnologia,
				DataCadastro = DateTime.Now.ToString("dd-MM-yyyy h:mm tt"),
				Observacao = modelCandidato.Observacao
			};

			_context.Candidatos.Add(candidato);
			_context.SaveChanges();
		}
	}
}
