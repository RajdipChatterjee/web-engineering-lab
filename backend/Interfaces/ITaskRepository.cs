using backend.DTOs.Task;
using TaskModel = backend.Models.Task;

namespace backend.Interfaces
{
    public interface ITaskRepository : IRepository<TaskFilterDto, TaskModel>
    {
    }
}