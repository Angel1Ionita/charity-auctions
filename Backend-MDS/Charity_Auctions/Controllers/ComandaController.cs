using Charity_Auctions.Entities;
using Charity_Auctions.Entities.DTOs;
using Charity_Auctions.Repositories.ComandaRepository;
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
    public class ComandaController : ControllerBase
    {
        private readonly IComandaRepository _repository;
        public ComandaController(IComandaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAllComenziByIdUser(int id)
        {
            var comenzi = await _repository.GetComenziByUserId(id);

            var comenziToReturn = new List<ComandaDTO>();

            foreach( var comanda in comenzi)
            {
                comenziToReturn.Add(new ComandaDTO(comanda));

            }
            return Ok(comenziToReturn);
        }
        
        [HttpGet]

        public async Task<IActionResult> GetAllComenzi()
        {
            var comenzi = await _repository.GetAllComenziWithProduse();

            var comenziToReturn = new List<ComandaDTO>();

            foreach (var comanda in comenzi)
            {
                comenziToReturn.Add(new ComandaDTO(comanda));

            }
            return Ok(comenziToReturn);
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateComanda(int id, string adresa)
        {
            var comanda = await _repository.GetByIdAsync(id);
            if (comanda == null)
            {
                return NotFound("Comanda nu exista!");
            }

            comanda.Adresa_livrare = adresa;
            _repository.Update(comanda);
            await _repository.SaveAsync();

            return Ok(new ComandaDTO(comanda));
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteComanda(int id)
        {
            var comanda = await _repository.GetByIdWithProduse(id);

            if(comanda == null)
            {
                return NotFound("Comanda nu exista!");
            }

            _repository.Delete(comanda);

            await _repository.SaveAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateComanda(CreateComandaDTO dto)
        {
            Comanda newcomanda = new Comanda();
            newcomanda.Adresa_livrare = dto.Adresa_livrare;
            newcomanda.Data_comanda = dto.Data_comanda;
            newcomanda.Produs_Comandas = dto.Produs_Comandas;
            newcomanda.Userid = dto.Userid;

            return Ok(new ComandaDTO(newcomanda));
        }


    }
}
