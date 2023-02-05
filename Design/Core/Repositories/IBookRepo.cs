using Design.Core.Entities;

namespace Design.Core.Repositories;

public interface IBookRepo:IBaseRepo<Book>
{
    Task<List<Book>> GetAll();
    Task<Book> GetById(string id);
}