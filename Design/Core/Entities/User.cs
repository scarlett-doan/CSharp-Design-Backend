using Design.Core.Enums;

namespace Design.Core.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserRoles UserRole { get; set; } = UserRoles.Guess;
    public string ImagePath { get; set; } = string.Empty;
    public UserStatuses UserStatus { get; set; } = UserStatuses.Disabled;
}