namespace Design.Core.Entities;

public class BaseEntity
{
    public string ID { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime LastUpdatedDateTime { get; set; }
}