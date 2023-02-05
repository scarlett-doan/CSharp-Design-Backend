using Design.Core.Entities;

namespace Design.Core.Repositories;

public interface IReviewRepo : IBaseRepo<Review>
{
    Task<List<Review>> GetAllReviewByBookId(string bookId);

    Task<List<Review>> GetAllReviewByUserId(string userId);
}