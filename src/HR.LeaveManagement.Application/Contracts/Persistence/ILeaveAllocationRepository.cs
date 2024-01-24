﻿using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetails(Guid id);

    Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();

    Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userId);

    Task<bool> AllocationExists(string userId, Guid leaveTypeId, int period);

    Task AddAllocations(List<LeaveAllocation> allocations);

    Task<LeaveAllocation> GetUserAllocations(string userId, Guid leaveTypeid);
}