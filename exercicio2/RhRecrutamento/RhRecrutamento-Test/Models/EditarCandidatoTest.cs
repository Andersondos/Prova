using RhRecrutamento.Models;
using RhRecrutamento_Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RhRecrutamento_Test.Models
{
	public class EditarCandidatoTest
	{

        [Fact]
        public void ValidCandidateRequestModel()
        {
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson Douglas",
                Telefone = "11 7070-7070",
                Email = "anderson.devsan@gmail.com",
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(0, results.Count);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingCompany(string nome)
        {
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = nome,
                Telefone = "11 7070-7070",
                Email = "anderson.devsan@gmail.com",
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O Nome é obrigatório", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidModelMissingPhone(string telefone)
        {
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson",
                Telefone = telefone,
                Email = "anderson.devsan@gmail.com",
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
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
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson",
                Telefone = "11 7070-7070",
                Email = email,
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
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
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson",
                Telefone = "11 7070-7070",
                Email = email,
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
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
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson",
                Telefone = "11 7070-7070",
                Email = "anderson.devsan@gmail.com",
                Cargo = "Desenvolvedor",
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = tecnologia,
                Observacao = "Quero trabalhar"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("As Tecnologias é obrigatória", results[0].ErrorMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MissingAnInvalidModel(string cargo)
        {
            var model = new EditarCandidato()
            {
                Id = 1,
                Nome = "Anderson",
                Telefone = "11 7070-7070",
                Email = "anderson@anderson.com",
                Cargo = cargo,
                Experiencia = "Promeiro emprego",
                Endereco = "rua logo ali N 71",
                Tecnologia = "C#, Angular, React, node",
                Observacao = "Quero trabalhar"
            };

            var results = TestModelHelper.Validate(model);

            Assert.Equal(1, results.Count);
            Assert.Equal("O Cargo é obrigatório", results[0].ErrorMessage);
        }
    }
}
