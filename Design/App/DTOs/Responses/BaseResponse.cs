namespace Design.App.DTOs.Responses;

public class BaseResponse
{
    public bool Status { get; set; }
    public string Message { get; set; }

    public static BaseResponse Success(string? message = null)
    {
        return new BaseResponse()
        {
            Status = true,
            Message = message ?? "Successful",
        };
    }

    public static BaseResponse Failure(string? message = null)
    {
        return new BaseResponse()
        {
            Message = message ?? "Failed",
        };
    }
}

public class BaseResponse<T> : BaseResponse
{
    public T Input { get; set; }

    public static BaseResponse<T> Success(T input, string? message = null)
    {
        return new BaseResponse<T>()
        {
            Status = true,
            Message = message ?? "Successful",
            Input = input
        };
    }

    public static BaseResponse<T> Failure(T inphut, string? message = null)
    {
        return new BaseResponse<T>()
        {
            Message = message ?? "Failed",
            Input = inphut
        };
    }
}