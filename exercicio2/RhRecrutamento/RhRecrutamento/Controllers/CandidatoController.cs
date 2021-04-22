using Microsoft.AspNetCore.Mvc;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;
using System;

namespace RhRecrutamento.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CandidatoController : ControllerBase
	{
		private readonly ICandidatoService _candidatoService;
		public CandidatoController(ICandidatoService vagaService)
		{
			_candidatoService = vagaService;
		}


        [HttpPost]
        public IActionResult RegisterCandidate(CandidatoRequest modelCandidato)
        {
            try
            {
                _candidatoService.SaveCandidate(modelCandidato);
                return Ok(new { Message = "Salvo com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult JobOpportunity()
        {
            try
            {
                return Ok(_candidatoService.GetAllCandidate());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult EditJobVacancy(EditarCandidato modelCandidato)
        {
            try
            {
                _candidatoService.EditCandidate(modelCandidato);
                return Ok(new { Message = "Atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteCandidate(int id)
        {
            try
            {
                _candidatoService.DeleteCandidate(id);
                return Ok(new { Message = "Excluido com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}