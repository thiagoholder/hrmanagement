using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveAlocation : BaseEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType? LeaveType { get; set; }
    public Guid LeaveTypeId { get; set; }
    public int Period { get; set; }
}