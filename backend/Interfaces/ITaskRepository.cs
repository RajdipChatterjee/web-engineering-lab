using TaskModel = backend.Models.Task;

namespace backend.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> GetAllTasksAsync();
        Task<TaskModel?> GetByIdAsync(string taskId);
        Task CreateTaskAsync(TaskModel task);
        Task UpdateTaskAsync(string taskId, TaskModel task);
        Task DeleteTaskAsync(string taskId);
    }
}