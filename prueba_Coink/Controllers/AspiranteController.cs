using Dominio;
using Persistencia.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dominio.DTO;

namespace prueba_Coink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspiranteController : ControllerBase
    {

        /**
         * inyección de dependencia de nuestro repositorio
         * para evitar el alto acoplamiento entre capas
         */

        private readonly IAspiranteoRepository _repo;

        // Utilizamos inyección de dependencias via constructor
        public AspiranteController(IAspiranteoRepository repo)
        {
            _repo = repo;
        }

        
        // POST api/aspirante
        [HttpPost]
        public async Task<IActionResult> Post(AspiranteDTO aspiranteDTO)
        {
            if (ModelState.IsValid)
            {

                var usuario = new Aspirante
                {
                    Nombre = aspiranteDTO.Nombre,
                    Apellido = aspiranteDTO.Apellido,
                    Edad = aspiranteDTO.Edad,
                    Casa = aspiranteDTO.Casa,
                    Identificacion = aspiranteDTO.Identificacion,
                };
                await _repo.Insert(usuario);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // UPDATE api/aspirante
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AspiranteDTO aspiranteDTO)
        {
            if (ModelState.IsValid)
            {
                var aspirante = new Aspirante
                {
                    AspiranteId = id,
                    Nombre = aspiranteDTO.Nombre,
                    Apellido = aspiranteDTO.Apellido,
                    Edad = aspiranteDTO.Edad,
                    Casa = aspiranteDTO.Casa,
                    Identificacion = aspiranteDTO.Identificacion
                };
                await _repo.Update(aspirante);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/Aspirante
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _repo.DeleteById(id);
        }


        // GET api/Aspirante
        [HttpGet]
        public async Task<IActionResult> GetUsuario()
        {
            var aspirantes = await _repo.GetAspirantes();
            return Ok(aspirantes);
        }

    }
}
