using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Models;

namespace Yellow_Cube.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehicleCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VehicleCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleCategory>>> GetVehicleCategories()
        {
            return await _context.VehicleCategories.ToListAsync();
        }

        // GET: api/VehicleCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleCategory>> GetVehicleCategory(Guid id)
        {
            var vehicleCategory = await _context.VehicleCategories.FindAsync(id);

            if (vehicleCategory == null)
            {
                return NotFound();
            }

            return vehicleCategory;
        }

        // PUT: api/VehicleCategories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleCategory(Guid id, VehicleCategory vehicleCategory)
        {
            if (id != vehicleCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehicleCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/VehicleCategories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<VehicleCategory>> PostVehicleCategory(VehicleCategory vehicleCategory)
        {
            _context.VehicleCategories.Add(vehicleCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicleCategory", new { id = vehicleCategory.Id }, vehicleCategory);
        }

        // DELETE: api/VehicleCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VehicleCategory>> DeleteVehicleCategory(Guid id)
        {
            var vehicleCategory = await _context.VehicleCategories.FindAsync(id);
            if (vehicleCategory == null)
            {
                return NotFound();
            }

            _context.VehicleCategories.Remove(vehicleCategory);
            await _context.SaveChangesAsync();

            return vehicleCategory;
        }

        private bool VehicleCategoryExists(Guid id)
        {
            return _context.VehicleCategories.Any(e => e.Id == id);
        }
    }
}
