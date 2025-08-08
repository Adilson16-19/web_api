using Microsoft.AspNetCore.Mvc;
using PessoaAPI.Models;

namespace PessoaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetPessoa(int id)
        {
            var pessoa = new Pessoa
            {
                Id = id,
                Nome = "João Silva",
                Idade = 30,
                Email = "joao@email.com"
            };

            return Ok(pessoa);
        }
    }
}
