    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetail
{
    internal class LeaveTypeDetailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }

    }
}
