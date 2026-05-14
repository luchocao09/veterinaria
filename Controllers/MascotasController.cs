using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veterinaria.Data;
using veterinaria.Models;

[ApiController]
[Route("api/[controller]")]
public class MascotasController : ControllerBase
{
    private readonly AppDbContext _context;

    public MascotasController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Mascota>>> GetById(int id)
    {
        var mascota = await _context.Mascotas.FindAsync(id);
        if (mascota == null) return NotFound();
        return await _context.Mascotas.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Mascota>> Post(Mascota mascota)
    {
        _context.Mascotas.Add(mascota);
        await _context.SaveChangesAsync();
        return Ok(mascota);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Mascota mascota)
    {
        _context.Entry(mascota).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var mascota = await _context.Mascotas.FindAsync(id);
        if (mascota == null) return NotFound();
        _context.Mascotas.Remove(mascota);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
