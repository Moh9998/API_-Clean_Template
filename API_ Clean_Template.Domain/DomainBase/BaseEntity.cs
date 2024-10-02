namespace API__Clean_Template.Domain.DomainBase;

public class BaseEntity<T>
{
    public required T Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
