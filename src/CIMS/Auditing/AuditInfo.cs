namespace CIMS.Auditing;

public record struct AuditInfo 
{
    public int? UserId { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
}