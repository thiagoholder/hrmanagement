using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Persistence.Configurations
{
    public class LeaveTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
               new LeaveType
               {
                   Id = Guid.NewGuid(),
                   Name = "Vacation",
                   DefaultDays = 10,
                   DateCreated = DateTime.UtcNow,
                   DateModified = DateTime.UtcNow,
               });

            builder.Property(q => q.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}