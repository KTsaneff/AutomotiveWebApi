using AutomotiveWebApi.Models;
using AutomotiveWebApi.Services.Interfaces;
using AutomotiveWebApi.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AutomotiveWebApi.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IMongoCollection<Vehicle> _vehiclesCollection;

        public VehicleService(IOptions<MongoDbSettings> mongoSettings)
        {
            IMongoClient mongoClient = new MongoClient(mongoSettings.Value.ConnectionString);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(mongoSettings.Value.DatabaseName);

            _vehiclesCollection = mongoDatabase.GetCollection<Vehicle>(mongoSettings.Value.VehiclesCollectionName);
        }
        public async Task AddAsync(Vehicle vehicle)
        {
            await _vehiclesCollection.InsertOneAsync(vehicle);
        }

        public Task<bool> DeleteAsync(string id)
        {
            var result = _vehiclesCollection.DeleteOneAsync(v => v.Id == id);
            return result.ContinueWith(task => task.Result.DeletedCount > 0);
        }

        public async Task<List<Vehicle>> GetAllAsync()
        {
            return await _vehiclesCollection.Find(_ => true).ToListAsync();
        }

        public async Task<Vehicle> GetByIdAsync(string id)
        {
            return await _vehiclesCollection.Find(v => v.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(string id, Vehicle updateVehicle)
        {
            var result = await _vehiclesCollection.ReplaceOneAsync(
                v => v.Id == id,
                updateVehicle,
                new ReplaceOptions { IsUpsert = false });

            return result.ModifiedCount > 0;
        }
    }
}
