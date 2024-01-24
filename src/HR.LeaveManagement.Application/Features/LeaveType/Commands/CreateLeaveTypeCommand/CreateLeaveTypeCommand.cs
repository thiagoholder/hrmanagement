using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveTypeCommand
{
    public class CreateLeaveTypeCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}