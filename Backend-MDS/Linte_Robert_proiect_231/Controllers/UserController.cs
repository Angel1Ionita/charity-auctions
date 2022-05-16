using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Entities.DTOs;
using Linte_Robert_proiect_231.Repositories.UserRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdWithComanda(string id)
        {
            var user = await _repository.GetByIdWithComanda(id);
            if (user == null)
            {
                return NotFound("User-ul nu exista!");
            }
            return Ok(new UserDTO(user));
        }

        [HttpGet("/cos/{id}")]
        public async Task<IActionResult> GetUserByIdWithCos(int id)
        {
            var user = await _repository.GetByIdWithCos(id);
            if (user == null)
            {
                return NotFound("User-ul nu exista!");
            }
            return Ok(new UserDTO(user));
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateUser(int id, string parola)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound("User-ul nu exista!");
            }
            user.Parola = parola;
            _repository.Update(user);
            await _repository.SaveAsync();
            return Ok(new UserDTO(user));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _repository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound("Produsul nu exista!");
            }

            _repository.Delete(user);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost]

        public async Task<IActionResult> CreateUser(CreateUserDTO dto)
        {
            User newuser = new User();
            newuser.Nume = dto.Nume;
            newuser.Parola = dto.Parola;
            newuser.Tip = dto.Tip;
            newuser.Adresa_email = dto.Adresa_email;
            newuser.cos_Cumparaturi = new Cos_cumparaturi();

            _repository.Create(newuser);

            await _repository.SaveAsync();

            return Ok(new UserDTO(newuser));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var produse =  _repository.GetAll();

            var produseToReturn = new List<UserDTO>();

            foreach (var produs in produse)
            {
                produseToReturn.Add(new UserDTO(produs));
            }
            return Ok(produseToReturn);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateUser(User user)
        {
            user.cos_Cumparaturi = new Cos_cumparaturi();
            _repository.Update(user);
            await _repository.SaveAsync();
            return Ok(new UserDTO(user));
        }

    }
}
