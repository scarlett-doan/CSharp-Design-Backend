using System.ComponentModel.DataAnnotations;

namespace Design.Core.Enums;

public enum UserRoles
{
    [Display (Description = "Guess")]
    Guess = 0,
    
    [Display (Description = "Admin")]
    Admin = 1,
    
    [Display (Description = "Mod")]
    Mod = 2
}