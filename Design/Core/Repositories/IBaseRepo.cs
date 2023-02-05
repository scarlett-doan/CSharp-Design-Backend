namespace Design.Core.Repositories;

public interface IBaseRepo<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> GetById(string id);
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}