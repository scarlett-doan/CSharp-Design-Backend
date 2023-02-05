using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;

namespace Design.Core.Enums;

public enum Categories
{
    [Display(Description = "History")]
    History = 0,
    
    [Display(Description = "Science")]
    Science = 1,
    
    [Display(Description = "Novel")]
    Novel = 2,
    
    [Display(Description = "Action And Adventure")]
    ActionAndAdventure = 3,
    
    [Display(Description = "Comic And Graphic Novel")]
    ComicAndGraphicNovel = 4,
    
    [Display(Description = "Fantasy")]
    Fantasy = 5,
    
    [Display(Description = "Poem")]
    Poem = 6,
    
    [Display(Description = "Other")]
    Other = 7
}