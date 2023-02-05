using System.ComponentModel.DataAnnotations;

namespace Design.Core.Enums;

public enum UserStatuses
{
    [Display(Description = "Disabled")]
    Disabled = 0,
    
    [Display(Description = "Active")]
    Active = 1,
    
    [Display(Description = "Pending")]
    Pending = 2
}