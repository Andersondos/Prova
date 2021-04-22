using Microsoft.Extensions.Options;
using RhRecrutamento.Data;
using RhRecrutamento.Entities;
using RhRecrutamento.Helpers;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhRecrutamento.Services
{
	public class VagaService : IVagaService
	{
		private readonly DataContext _context;
        private readonly AppSettings _appSettings;

        public VagaService(DataContext context,
                           IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

		public void DeleteVacancy(int id)
		{
            Vaga vaga = _context.Vagas.Where(vg => vg.Id == id).FirstOrDefault();
            _context.Vagas.Remove(vaga);
            _context.SaveChanges();
        }

		public void EditVacancy(EditarVaga modelVaga)
		{
			Vaga vaga = _context.Vagas.Where(vg => vg.Id == modelVaga.Id).FirstOrDefault();

			vaga.Empresa = modelVaga.Empresa;
			vaga.Telefone = modelVaga.Telefone;
            vaga.Email = modelVaga.Email;
			vaga.Endereco = modelVaga.Endereco;
			vaga.Tecnologia = modelVaga.Tecnologia;
			vaga.Responsavel = modelVaga.Responsavel;
			vaga.Observacao = modelVaga.Observacao;

            _context.Update(vaga);
            _context.SaveChanges();
        }

		public IEnumerable<Vaga> GetAll()
        {
            return _context.Vagas.ToList();
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

            _context.Vagas.Add(vaga);
            _context.SaveChanges();
        }
	}
}
