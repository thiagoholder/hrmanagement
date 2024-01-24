﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    public LeaveAllocationRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task AddAllocations(List<LeaveAllocation> allocations)
    {
        await _context.AddRangeAsync(allocations);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> AllocationExists(string userId, Guid leaveTypeId, int period)
    {
        var leaveAllocations = await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == userId
                                    && q.LeaveTypeId == leaveTypeId
                                    && q.Period == period);
        return leaveAllocations;
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(Guid id)
    {
        var leaveAllocation = await _context.LeaveAllocations
             .Include(q => q.LeaveType)
             .FirstOrDefaultAsync(q => q.Id == id);

        return leaveAllocation;
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
    {
        var leaveAllocations = await _context.LeaveAllocations
           .Include(q => q.LeaveType)
           .ToListAsync();
        return leaveAllocations;
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userId)
    {
        var leaveAllocations = await _context.LeaveAllocations
            .Where(q => q.EmployeeId == userId)
            .Include(q => q.LeaveType)
            .ToListAsync();
        return leaveAllocations;
    }

    public async Task<LeaveAllocation> GetUserAllocations(string userId, Guid leaveTypeid)
    {
        return await _context.LeaveAllocations
           .FirstOrDefaultAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeid);
           
    }
}