using Chapter.Models;
using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Controllers
{
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{

    private readonly LivroRepository _livroRepository;

    public LivroController(LivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    [HttpGet]

    public IActionResult Listar()
    {
        try
        {
            return Ok(_livroRepository.Listar);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult BuscarPorId(int id)
    {
        try
        {
            Livro livrobuscado = _livroRepository.BuscarPorId(id);
            if (livrobuscado == null)
            {
                return NotFound();
            }
            {
                return Ok(livrobuscado);
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPost]

    public IActionResult Cadastrar(Livro li)
    {
        try
        {
            _livroRepository.Cadastrar(li);
            return StatusCode(201);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpDelete("{id}")]

    public IActionResult Excluir(int id)
    {

        try
        {
            _livroRepository.Excluir(id);

            return Ok("Livro excluido com sucesso!");
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("{id}")]

    public IActionResult Atualizar(int id, Livro li)
    {

        try
        {
            _livroRepository.Atualizar(id, li);

            return StatusCode(204);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

    }
}

}

