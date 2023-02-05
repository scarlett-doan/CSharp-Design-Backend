using Design.App.DTOs.Requests;
using Design.App.DTOs.Responses;

namespace Design.App.Services.ServiceInterfaces;

public interface IBookService
{
    Task<BaseResponse<BookDetails>> GetById(string bookId);
    Task<BaseResponse> CreateBook(BookCreationReq creationReq);
    Task<BaseResponse<BookDetails>> UpdateBook(BookUpdating updatingReq);
    Task<BaseResponse> DeleteBook(string bookId);
}