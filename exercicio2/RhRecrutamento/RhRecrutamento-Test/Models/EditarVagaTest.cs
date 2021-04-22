using RhRecrutamento.Models;
using RhRecrutamento_Test.Helpers;
using System.Linq;
using Xunit;

namespace RhRecrutamento_Test.Models
{
	public class EditarVagaTest
	{
        [Fact]
        public void ValidVacancyRequestTemplate()
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "11 7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(0, results.Count);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingCompany(string nomeEmpresa)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = nomeEmpresa,
                Telefone = "11 7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("A Empresa é obrigatória", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingPhone(string telefone)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = telefone,
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O Telefone é obrigatório", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingEmail(string email)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "11 7070-7070",
                Email = email,
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O Email é obrigatório", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("rh.contatogruposervices.com")]
        [InlineData("@")]
        [InlineData("rh.contato@")]
        [InlineData("@gruposervices.com")]
        public void EmailValidation(string email)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "11 7070-7070",
                Email = email,
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O email inserido não parece ser inválido", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingTechnologies(string tecnologia)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = tecnologia,
                Responsavel = "Marcos Vinicius Nicolas",
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("As Tecnologias é obrigatória", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ResponsiblePersonMissingAnInvalidModel(string responsavel)
        {
            var model = new EditarVaga()
            {
                Id = 1,
                Empresa = "Grupo Services",
                Telefone = "7070-7070",
                Email = "rh.contato@gruposervices.com",
                Endereco = "rua logo ali N 70",
                Tecnologia = "C#, Angular, React, node",
                Responsavel = responsavel,
                Observacao = "Vaga para programador Junior"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O Responsável é obrigatório", results[0].ErrorMessage);
        }
    }
}
