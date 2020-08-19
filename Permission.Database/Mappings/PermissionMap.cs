using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using permit = Permission.Domain.Models;

namespace Permission.Database.Mappings
{
    public class PermissionMap : IEntityTypeConfiguration<permit.Permission>
    {
        public void Configure(EntityTypeBuilder<permit.Permission> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.EmployeeName).HasColumnType("nvarchar(450)").IsRequired();
            builder.Property(p => p.LastNameEmployee).HasColumnType("nvarchar(550)").IsRequired();
            builder.Property(p => p.PermissionTypeId).HasColumnType("int").IsRequired();
            builder.Property(p => p.PermitDate).HasColumnType("datetime").IsRequired();

            //association
            builder.HasOne(p => p.PermissionType)
                .WithMany(pt => pt.Permissions)
                .HasForeignKey(p => p.PermissionTypeId);


            builder.ToTable("Permissions");
                

        }
    }
}
