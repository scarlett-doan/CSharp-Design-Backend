using System.ComponentModel.DataAnnotations;

namespace Design.Core.Enums;

public enum RatingList
{
    [Display (Description = "Very Poor")]
    VeryPoor = 1,
    
    [Display (Description = "Poor")]
    Poor = 2,
    
    [Display (Description = "Average")]
    Average = 3,
    
    [Display (Description = "Good")]
    Good = 4,
    
    [Display (Description = "Excellent")]
    Excellent = 5
}