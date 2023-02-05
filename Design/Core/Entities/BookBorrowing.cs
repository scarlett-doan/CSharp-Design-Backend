namespace Design.Core.Entities;

public class BookBorrowing : BaseEntity
{
    public string UserId { get; set; }
    public User User { get; set; }
    
    public string BookId { get; set; }
    public Book Book { get; set; }
    
    public DateOnly ReturnDueDate { get; set; }
    
    public bool IsReturned { get; set; }
}