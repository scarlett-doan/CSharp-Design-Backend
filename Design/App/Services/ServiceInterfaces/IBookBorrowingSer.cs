using Design.App.DTOs.Requests;
using Design.App.DTOs.Responses;

namespace Design.App.Services.ServiceInterfaces;

public interface IBookBorrowingSer
{
    Task<BaseResponse<BookBorrowingRes>> Borrow(BookBorrowingReq borrowingReq);
    Task<BaseResponse<BookReturningRes>> Return(BookReturningReq returningReq);
    Task<BaseResponse<List<BookBorrowingRes>>> GetAllBorrowingBook();
}