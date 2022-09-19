namespace CIMS.Auditing;

public interface ICurrentAuditInfoProvider
{
    AuditInfo Current { get; }
}