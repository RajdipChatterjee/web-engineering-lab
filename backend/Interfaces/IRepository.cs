using backend.DTOs.Task;

namespace backend.Interfaces
{
    public interface IRepository<Filter, T>
    {
        Task CreateAsync(T dto, string author);
        Task<T?> GetByIdAsync(string id);
        Task<List<T>> GetAsync(Filter? filter);
        Task UpdateAsync(string id, T body, string author);
        Task DeleteAsync(string id, string author);
    }
}