using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Charity_Auctions.Entities;
using Charity_Auctions.Entities.DTOs;
using Charity_Auctions.Repositories.ProdusRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusRepository _repository;
        public ProdusController(IProdusRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduse()
        {
            var produse = await _repository.GetAllProdusWithMarimi();

            var produseToReturn = new List<ProdusDTO>();

            foreach (var produs in produse)
            {
                produseToReturn.Add(new ProdusDTO(produs));
            }
            return Ok(produseToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdusById(int id)
        {
            var produs = await _repository.GetByIdWithTabel(id);
            if( produs == null)
            {
                return NotFound("Produsul nu exista");
            }
            return Ok(new ProdusDTO(produs));
        }
        [HttpPut("")]
        public async Task<IActionResult> UpdateProdus(Produs produs)
        {
            produs.Tabel_Marimi = new Tabel_Marimi();
            
            _repository.Update(produs);
            await _repository.SaveAsync();
            return Ok(new ProdusDTO(produs));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdus(int id)
        {
            var produs = await _repository.GetByIdAsync(id);

            if (produs == null)
            {
                return NotFound("Produsul nu exista!");
            }

            _repository.Delete(produs);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost]

        public async Task<IActionResult> CreateProdus(CreateProdusDTO dto)
        {
            Produs newprodus = new Produs();
            newprodus.Denumire = dto.Denumire;
            newprodus.Pret = dto.Pret;
            newprodus.Url_poza = dto.Url_poza;
            newprodus.Poster_name = dto.Poster_name;
            newprodus.Charity_name = dto.Charity_name;

            newprodus.Tabel_Marimi = new Tabel_Marimi();

            _repository.Create(newprodus);

            await _repository.SaveAsync();

            return Ok(new ProdusDTO(newprodus));
        }
    }

}

    

