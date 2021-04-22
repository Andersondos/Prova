using System;
using System.Collections.Generic;
using System.Linq;
using RhRecrutamento.Entities;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;

namespace RhRecrutamento_Test.ServiceMocks
{
	public class VagaServiceMock : IVagaService
	{
		private List<Vaga> _vagas;

		public VagaServiceMock()
		{
			_vagas = new List<Vaga>()
			{
				new Vaga()
				{
					Id = 1,
					Empresa = "Grupo Services",
					Telefone = "11 7070-7070",
					Email = "rh.contato@gruposervices.com",
					Endereco = "rua logo ali N 70",
					Tecnologia = "C#, Angular, React, node",
					Responsavel = "Marcos Vinicius Nicolas",
					Observacao = "Vaga para programador Junior"
				},

				new Vaga()
				{
					Id = 2,
					Empresa = "TecLog",
					Telefone = "11 7070-7070",
					Email = "TecLog@gruposervices.com",
					Endereco = "rua baixo da logo ali N 70",
					Tecnologia = "Java, sql",
					Responsavel = "Paulo Santos",
					Observacao = "Vaga para programador Pleno"
				}
			};

		}

		public void DeleteVacancy(int id)
		{
			Vaga vaga = _vagas.Where(vg => vg.Id == id).FirstOrDefault();
			_vagas.Remove(vaga);
		}

		public void EditVacancy(EditarVaga modelVaga)
		{
			Vaga vaga = _vagas.Where(vg => vg.Id == modelVaga.Id).FirstOrDefault();

			vaga.Empresa = modelVaga.Empresa;
			vaga.Telefone = modelVaga.Telefone;
			vaga.Email = modelVaga.Email;
			vaga.Endereco = modelVaga.Endereco;
			vaga.Tecnologia = modelVaga.Tecnologia;
			vaga.Responsavel = modelVaga.Responsavel;
			vaga.Observacao = modelVaga.Observacao;
		}

		public IEnumerable<Vaga> GetAll()
		{
			return _vagas.ToList();
		}

		public void SaveJobVacancy(VagaRequest modelVaga)
		{
			Vaga vaga = new Vaga()
			{
				Empresa = modelVaga.Empresa,
				Telefone = modelVaga.Telefone,
				Email = modelVaga.Email,
				Endereco = modelVaga.Endereco,
				Tecnologia = modelVaga.Tecnologia,
				Responsavel = modelVaga.Responsavel,
				DataCadastro = DateTime.Now.ToString("dd-MM-yyyy h:mm tt"),
				Observacao = modelVaga.Observacao

			};

			_vagas.Add(vaga);
		}
	}
}
