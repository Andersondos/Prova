using Microsoft.AspNetCore.Mvc;
using RhRecrutamento.Models;
using RhRecrutamento.Services.Interface;
using System;

namespace RhRecrutamento.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class VagaController : ControllerBase
	{
		private readonly IVagaService _vagaService;

		public VagaController( IVagaService vagaService)
		{
			_vagaService = vagaService;
		}

        [HttpPost]
        public IActionResult RegisterJobVacancy(VagaRequest modelVaga)
		{
            try
			{
                _vagaService.SaveJobVacancy(modelVaga);
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
                return Ok(_vagaService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult EditJobVacancy(EditarVaga modelVaga)
        {
            try
            {
                _vagaService.EditVacancy(modelVaga);
                return Ok(new { Message = "Atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteJobVacancy(int id)
        {
            try
            {
                _vagaService.DeleteVacancy(id);
                return Ok(new { Message = "Excluido com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
