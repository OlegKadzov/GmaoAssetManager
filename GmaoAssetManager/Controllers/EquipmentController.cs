using GmaoAssetManager.Data;
using GmaoAssetManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GmaoAssetManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly AppDbContext _context;

        // La BBDD
        public EquipmentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Equipment
        // Vuelve toda la lista de equipos desde la base de datos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetAllEquipment()
        {
            return await _context.Equipments.ToListAsync();
        }

        // POST: api/Equipment
        // Agrega un nuevo equipo a la base de datos
        [HttpPost]
        public async Task<ActionResult<Equipment>> AddEquipment(Equipment equipment)
        {
            _context.Equipments.Add(equipment);
            await _context.SaveChangesAsync();

            return Ok(equipment);
        }
        // PUT: api/Equipment/5
        // Actualiza un equipo existente en la base de datos
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEquipment(int id, Equipment equipment)
        {
            // Comrpuebo que el ID en la URL coincide con el ID del equipo en el cuerpo de la solicitud
            if (id != equipment.Id)
            {
                return BadRequest("El valor «D» de la URL no coincide con el ID del equipo que figura en el cuerpo de la solicitud");
            }

            // El objeto de equipo se marca como modificado en el contexto de la base de datos
            _context.Entry(equipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Si el equipo con el ID especificado no existe, devolvemos un error
                if (!_context.Equipments.Any(e => e.Id == id))
                {
                    return NotFound($"Equipos con ID {id} no encontrado.");
                }
                else
                {
                    throw;
                }
            }

            // Vuelve un código de estado 404 No Content para indicar que la actualización fue exitosa
            return NoContent();
        }

        // DELETE: api/Equipment/5
        // Elimina un equipo existente de la base de datos
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipment(int id)
        {
            var equipment = await _context.Equipments.FindAsync(id);

            if (equipment == null)
            {
                return NotFound($"Equipos con ID {id} no encotrado.");
            }

            _context.Equipments.Remove(equipment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}