using Alura.Dotnet.Filmes.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alura.Dotnet.Filmes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> _filmes = new List<Filme>();

        [HttpGet]
        public IActionResult Get()
        {
            return  Ok(_filmes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            _filmes.Add(filme);

            Console.WriteLine(filme);

            return Created();
        }
    }
}
