namespace Entities.Abstractions;
public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CreatedById { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public Guid UpdatedById { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
    public Guid DeletedById { get; set; }
    public DateTime? DeletedDate { get; set; }
}
