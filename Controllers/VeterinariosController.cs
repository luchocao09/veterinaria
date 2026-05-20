using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veterinaria.Data;
using veterinaria.Models;
using veterinaria.DTOs;

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
    public async Task<ActionResult<Veterinario>> Post(VeterinarioDto dto)
    {
        var veterinario = new Veterinario
        {
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Telefono = dto.Telefono,
            NombreMascota = dto.NombreMascota,
        };
        _context.Veterinarios.Add(veterinario);
        await _context.SaveChangesAsync();
        return Ok(veterinario);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, VeterinarioDto dto)
    {
        var veterinario = await _context.Veterinarios.FindAsync(id);
        if (veterinario == null) return NotFound();
        veterinario.Nombre = dto.Nombre;
        veterinario.Apellido = dto.Apellido;
        veterinario.Telefono = dto.Telefono;
        veterinario.NombreMascota = dto.NombreMascota;
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