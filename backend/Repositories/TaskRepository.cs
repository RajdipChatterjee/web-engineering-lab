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
            await _taskCollection.InsertOneAsync(task);
        }

        public async Task DeleteTaskAsync(string taskId)
        {
            var filter = Builders<TaskModel>.Filter.And(
                Builders<TaskModel>.Filter.Eq(t => t.TaskId, taskId),
                Builders<TaskModel>.Filter.Eq(t => t.DeletedAt, null)
            );
            var update = Builders<TaskModel>.Update.Set(t => t.DeletedAt, DateTime.UtcNow);
            var result = await _taskCollection.UpdateOneAsync(filter, update);
            if (result.MatchedCount == 0) throw new Exception("Task not found or already deleted.");
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
