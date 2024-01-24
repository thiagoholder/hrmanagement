using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveTypeCommand
{
    public class DeleteLeaveTypeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}