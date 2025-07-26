using AutomotiveWebApi.Models;
using AutomotiveWebApi.Services.Interfaces;
using AutomotiveWebApi.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AutomotiveWebApi.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserService(IOptions<MongoDbSettings> mongoSettings)
        {
            IMongoClient mongoClient = new MongoClient(mongoSettings.Value.ConnectionString);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(mongoSettings.Value.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<User>(mongoSettings.Value.UsersCollectionName);
        }

        public async Task RegisterUserAsync(User user)
        {
            await _usersCollection.InsertOneAsync(user);
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _usersCollection.Find(u => u.Email == email).FirstOrDefaultAsync();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            return _usersCollection.Find(_ => true).ToListAsync();
        }
    }
}
