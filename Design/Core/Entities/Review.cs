using Design.Core.Enums;

namespace Design.Core.Entities;

public class Review : BaseEntity
{
    public string UserId { get; set; }
    public User User { get; set; }
    
    public string BookId { get; set; }
    public Book Book { get; set; }
    
    public RatingList Rate { get; set; }
    public string? ReviewSubject { get; set; }
    public string? ReviewContent { get; set; }
}