using Design.Core.Entities;

namespace Design.Core.Repositories;

public interface IBookBorrowingRepo : IBaseRepo<BookBorrowing>
{
    Task<BookBorrowing> HasBorrowedBookByUserId(string userId);

    Task<BookBorrowing> HasDueToReturnedBookByUserId(string userId);

    Task<BookBorrowing> IsBorrowedByBookId(string bookId);

    Task<List<BookBorrowing>> GetBorrowedListByUserId(string userId);
}