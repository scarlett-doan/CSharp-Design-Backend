using Design.App.DTOs.Requests;
using Design.App.DTOs.Responses;

namespace Design.App.Services.ServiceInterfaces;

public interface IUserService
{
    Task<BaseResponse<UserDetails>> GetUserDetailById(string userId);
    Task<BaseResponse> AddToRole(RoleAssignmentReq roleAssignmentReq);
    Task<BaseResponse<UserDetails>> UpdateUser(UserUpdatingReq userUpdatingReq);
    Task<BaseResponse> DeleteUser(string userId);
}