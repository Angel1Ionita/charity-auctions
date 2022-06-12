using Charity_Auctions.Entities;
using Charity_Auctions.Entities.DTOs;
using Charity_Auctions.Repositories.ComentariuRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariuController : ControllerBase
    {
        private readonly IComentariuRepository _repository;
        public ComentariuController(IComentariuRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAllComentariiById(int id)
        {
            var comenzi = await _repository.GetAllComentariiByProdusId(id);

            var comenziToReturn = new List<ComentariuDTO>();

            foreach (var comanda in comenzi)
            {
                comenziToReturn.Add(new ComentariuDTO(comanda));

            }
            return Ok(comenziToReturn);
        }

        [HttpGet]
        public IActionResult GetAllComentarii()
        {
            var produse = _repository.GetAll();

            var produseToReturn = new List<ComentariuDTO>();

            foreach (var produs in produse)
            {
                produseToReturn.Add(new ComentariuDTO(produs));
            }
            return Ok(produseToReturn);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteComentariu(int id)
        {
            var comanda = await _repository.GetByIdAsync(id);

            if (comanda == null)
            {
                return NotFound("Comentariul nu exista!");
            }

            _repository.Delete(comanda);

            await _repository.SaveAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateComentariu(Comentariu dto)
        {
            Comentariu newcomanda = new Comentariu();
            newcomanda.Id_produs = dto.Id_produs;
            newcomanda.Com = dto.Com;
            newcomanda.username = dto.username;

            _repository.Create(newcomanda);
            await _repository.SaveAsync();

            return Ok(new ComentariuDTO(newcomanda));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComentariu(Comentariu x)
        {

            _repository.Update(x);
            await _repository.SaveAsync();
            return Ok(new ComentariuDTO(x));
        }

    }
}
