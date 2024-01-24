using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public record GetLeaveTypesDetailsQuery(Guid Id) : IRequest<LeaveTypeDetailsDto>;