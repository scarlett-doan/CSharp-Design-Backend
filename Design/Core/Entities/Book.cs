using Design.Core.Enums;

namespace Design.Core.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string? ImagePath { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateOnly PublishedYear { get; set; } = new DateOnly();
    public string Description { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;

    public string CategoryId { get; set; } = string.Empty;
    public Categories Category { get; set; } = Categories.Other;
    
    public IEnumerable<Review> AvarageRate { get; set; }
    public int AvailableCopies { get; set; } = 0;
}