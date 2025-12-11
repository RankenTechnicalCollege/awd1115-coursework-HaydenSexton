namespace SummitV2.Models
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(string id, QueryOptions<T> options);
        
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);
    }
}
