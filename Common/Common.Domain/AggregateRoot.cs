using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain;

public class AggregateRoot : BaseEntity
{
    [NotMapped]
    public List<BaseDomainEvent> DomainEvents { get; } = new();

    public void AddDomainEvent(BaseDomainEvent eventItem)
    {
        DomainEvents.Add(eventItem);
    }

    public void RemoveDomainEvent(BaseDomainEvent eventItem)
    {
        DomainEvents?.Remove(eventItem);
    }
}