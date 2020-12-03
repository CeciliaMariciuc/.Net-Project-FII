using Autentification.Controllers;
using Autentification.Model;
using MongoDB.Driver;

namespace Autentification.Data
{
    public class DataContext
    {
        public DataContext(IUsersDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public IMongoCollection<User> Users { get; }
    }
}
