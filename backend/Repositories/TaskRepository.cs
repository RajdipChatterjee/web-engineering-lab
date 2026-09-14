using backend.Configurations;
using backend.DTOs.Task;
using backend.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using TaskModel = backend.Models.Task;

namespace backend.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IMongoCollection<TaskModel> _taskCollection;
        public TaskRepository(IOptions<MongoDbSettings> mongoDbSettings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _taskCollection = database.GetCollection<TaskModel>(mongoDbSettings.Value.TasksCollectionName);
        }

        public async Task CreateAsync(TaskModel dto, string author)
        {
            await _taskCollection.InsertOneAsync(dto);
        }

        public async Task DeleteAsync(string id, string author)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskModel>> GetAsync(TaskFilterDto? filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TaskModel?> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string id, TaskModel dto, string author)
        {
            throw new NotImplementedException();
        }
    }
}
