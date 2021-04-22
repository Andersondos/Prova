using Microsoft.EntityFrameworkCore;
using RhRecrutamento.Data;
using RhRecrutamento.Models;
using RhRecrutamento.Services;
using RhRecrutamento.Services.Interface;
using RhRecrutamento_Test.Helpers;
using System;
using System.Linq;
using Xunit;

namespace RhRecrutamento_Test.Services
{
	public class VagaServiceTest
	{
		private readonly IVagaService _service;

		private readonly DataContext _context;

        public VagaServiceTest()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            var appSettings = new OptionsHelper();

            _context = new DataContext(options);
            _service = new VagaService(_context, appSettings);
        }

        [Fact]
        public void CRUDSuccess()
        {
            VagaRequest vaga = new VagaRequest()
            {
                Empresa = "Grupo Services",
                Telefone = "11 7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            _service.SaveJobVacancy(vaga);

            var chargeResult = _service.GetAll().ToList();

            Assert.NotNull(chargeResult);
            Assert.Equal(vaga.Empresa, chargeResult[0].Empresa);
            Assert.Equal(vaga.Telefone, chargeResult[0].Telefone);
            Assert.Equal(vaga.Email, chargeResult[0].Email);
            Assert.Equal(vaga.Endereco, chargeResult[0].Endereco);
            Assert.Equal(vaga.Observacao, chargeResult[0].Observacao);

            EditarVaga editeVaga = new EditarVaga()
            {   
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "11 7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, AWS, node",
                Responsavel = "Paulo",
                Observacao = "Vaga para programador Pleno"
            };

			_service.EditVacancy(editeVaga);

			var editResult = _service.GetAll().ToList();

            Assert.NotNull(chargeResult);
            Assert.Equal(editeVaga.Empresa, editResult[0].Empresa);
            Assert.Equal(editeVaga.Telefone, editResult[0].Telefone);
            Assert.Equal(editeVaga.Email, editResult[0].Email);
            Assert.Equal(editeVaga.Endereco, editResult[0].Endereco);
            Assert.Equal(editeVaga.Responsavel, editResult[0].Responsavel);
            Assert.Equal(editeVaga.Observacao, editResult[0].Observacao);

			_service.DeleteVacancy(1);

            var result = _service.GetAll().ToList();
            Assert.Empty(result);
        }
    }
}
