using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veterinaria.Data;
using veterinaria.Models;

[ApiController]
[Route("api/[controller]")]
public class  VeterinariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public VeterinariosController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Veterinario>> GetById(int id)
    {
        var veterinario = await _context.Veterinarios.FindAsync(id);
        if (veterinario == null) return NotFound();
        return veterinario;
    }

    [HttpPost]
    public async Task<ActionResult<Veterinario>> Post(Veterinario veterinario)
    {
        _context.Veterinarios.Add(veterinario);
        await _context.SaveChangesAsync();
        return Ok(veterinario);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Veterinario veterinario)
    {
        _context.Entry(veterinario).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var veterinario = await _context.Veterinarios.FindAsync(id);
        if (veterinario == null) return NotFound();
        _context.Veterinarios.Remove(veterinario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}