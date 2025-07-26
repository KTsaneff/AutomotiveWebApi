using AutomotiveWebApi.Models;

namespace AutomotiveWebApi.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetAllAsync();

        Task<Vehicle> GetByIdAsync(string id);

        Task AddAsync(Vehicle vehicle);

        Task<bool> DeleteAsync(string id);

        Task<bool> UpdateAsync(string id, Vehicle updateVehicle);
    }
}
