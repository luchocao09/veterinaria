using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veterinaria.Data; 
using veterinaria.Models;
using veterinaria.DTOs;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientesController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Cliente>> GetById(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) return NotFound();
        return cliente;
    }

    [HttpPost]
    public async Task<ActionResult<Cliente>> Post(ClienteDto dto)
    {
        var cliente = new Cliente
        {
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Fechanac = dto.Fechanac,
            Telefono = dto.Telefono,
            NombreMascota = dto.NombreMascota,
        };
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return Ok(cliente);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ClienteDto dto)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) return NotFound();
        cliente.Nombre = dto.Nombre;
        cliente.Apellido = dto.Apellido;
        cliente.Fechanac = dto.Fechanac;
        cliente.Telefono = dto.Telefono;
        cliente.NombreMascota = dto.NombreMascota;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) return NotFound();
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}