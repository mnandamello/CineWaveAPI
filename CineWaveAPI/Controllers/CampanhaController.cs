using CineWaveAPI.Models;
using CineWaveAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineWaveAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampanhaController : ControllerBase
    {
        private readonly ICampanhaRepository _campanhaRepository;

        public CampanhaController(ICampanhaRepository campanhaRepository)
        {
            _campanhaRepository = campanhaRepository;
        }


        [Authorize]
        [HttpGet("PorID/{id:int}")]
        public async Task<ActionResult<Campanha>> GetCampanha(int id)
        {
            try
            {
                var campanha = await _campanhaRepository.GetCampanha(id);

                if (campanha == null) return NotFound("Campanha nn encontrada");

                return Ok(campanha);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Authorize]
        [HttpGet("AllCampanhas")]
        public async Task<ActionResult<Campanha>> GetCampanhas()
        {
            try
            {
                return Ok(await _campanhaRepository.GetCampanhas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("CampByUser/{id}")]
        public async Task<ActionResult<Campanha>> GetCampanhaByUser(string id)
        {
            try
            {
                return Ok(await _campanhaRepository.GetCampanhaByUser(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Campanha>> AddCampanha([FromBody] Campanha campanha)
        {

            try
            {
                if (campanha == null) return BadRequest("Info faltando");

                var createCp = await _campanhaRepository.AddCampanha(campanha);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpDelete("{id:int}")]
        public void DeleteCampanha(int id)
        {
            _campanhaRepository.DeleteCampanha(id);
        }
    }
}
