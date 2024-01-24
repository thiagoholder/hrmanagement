using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsHandler : IRequestHandler<GetLeaveTypesDetailsQuery, LeaveTypeDetailsDto>
    {
        private readonly IMapper _mapper;
        private ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailsHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypesDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAsync(request.Id);

            var data = _mapper.Map<LeaveTypeDetailsDto>(leaveTypes);

            return data;
        }
    }
}