using Design.App.DTOs.Requests;
using Design.App.DTOs.Responses;

namespace Design.App.Services.ServiceInterfaces;

public interface IReviewService
{
    Task<BaseResponse> CreateReview(ReviewCreationReq reviewCreationReq);
    Task<BaseResponse<ReviewDetails>> GetById(string reviewId);
    Task<BaseResponse> DeleteReview(string reviewId);
}