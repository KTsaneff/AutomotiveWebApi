using AutomotiveWebApi.Models;
using AutomotiveWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add([FromBody] Vehicle vehicle)
        {
            await _vehicleService.AddAsync(vehicle);
            return Ok("Vehicle added successfully.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicles = await _vehicleService.GetAllAsync();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetById(string id)
        {
            Vehicle vehicle = await _vehicleService.GetByIdAsync(id);
            if(vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(string id, [FromBody] Vehicle vehicle)
        {
            var updated = await _vehicleService.UpdateAsync(id, vehicle);
            if (!updated)
            {
                return NotFound("Vehicle not found or update failed.");
            }

            return Ok("Vehicle updated successfully.");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            var deleted = await _vehicleService.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound("Vehicle not found or delete failed.");
            }

            return Ok("Vehicle deleted successfully.");
        }
    }
}
