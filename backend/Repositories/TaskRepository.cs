using backend.Configurations;
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

        public async Task CreateTaskAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTaskAsync(string taskId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskModel>> GetAllTasksAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TaskModel?> GetByIdAsync(string taskId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTaskAsync(string taskId, TaskModel task)
        {
            throw new NotImplementedException();
        }

    }
}
