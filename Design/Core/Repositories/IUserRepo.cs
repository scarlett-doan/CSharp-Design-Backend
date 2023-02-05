using Design.Core.Entities;
using Design.Core.Enums;

namespace Design.Core.Repositories;

public interface IUserRepo : IBaseRepo<User>
{
    Task<List<User>> GetAllUserByStatus(UserStatuses status);
    Task<List<User>> GetAllUserByBorrowedBook(string bookId);
    Task<User> GetUserByEmail(string email);
}