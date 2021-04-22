using Microsoft.AspNetCore.Mvc;
using RhRecrutamento.Controllers;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;
using RhRecrutamento_Test.ServiceMocks;
using System.Text.Json;
using Xunit;

namespace RhRecrutamento_Test.Controllers
{
	public class VagaControllerTest
	{
		VagaController _controller;
		IVagaService _service;

		public VagaControllerTest()
		{
			_service = new VagaServiceMock();
			_controller = new VagaController(_service);
		}
        [Fact]
        public void GetPaginationSuccess()
        {

            var result = _controller.JobOpportunity() as OkObjectResult;

            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void PostVacancySucess()
        {
            VagaRequest vaga = new VagaRequest()
            {
                Empresa = "Grupo Ti",
                Telefone = "11 7070-7070",
                Email = "rh.contato@grupoTI.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var result = _controller.RegisterJobVacancy(vaga) as OkObjectResult;
            var item = JsonSerializer.Serialize(result.Value);
            var itemExpected = JsonSerializer.Serialize(new { Message = "Salvo com sucesso" });

            Assert.Equal(itemExpected, item);
        }

        [Fact]
        public void PutVacancySucess()
        {
            EditarVaga vaga = new EditarVaga()
            {
                Id = 2,
                Empresa = "Grupo Ti",
                Telefone = "11 7070-7070",
                Email = "rh.contato@grupoTI.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var result = _controller.EditJobVacancy(vaga) as OkObjectResult;
            var item = JsonSerializer.Serialize(result.Value);
            var itemExpected = JsonSerializer.Serialize(new { Message = "Atualizado com sucesso" });

            Assert.Equal(itemExpected, item);
        }

        [Fact]
        public void DeleteVacancySucess()
        {
            var result = _controller.DeleteJobVacancy(1) as OkObjectResult;
            var item = JsonSerializer.Serialize(result.Value);
            var itemExpected = JsonSerializer.Serialize(new { Message = "Excluido com sucesso" });

            Assert.Equal(itemExpected, item);
        }
    }
}
