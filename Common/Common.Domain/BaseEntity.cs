namespace Common.Domain;

public class BaseEntity
{
    public BaseEntity()
    {
        CreationDate = DateTime.Now;
    }

    public long Id { get; protected set; }
    public DateTime CreationDate { get; private set; }
}