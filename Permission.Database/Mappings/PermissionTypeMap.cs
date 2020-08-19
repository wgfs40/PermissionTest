using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permission.Domain.Models;
using permit = Permission.Domain.Models;

namespace Permission.Database.Mappings 
{
    public class PermissionTypeMap : IEntityTypeConfiguration<permit.PermissionType>
    {
        public void Configure(EntityTypeBuilder<PermissionType> builder)
        {
            builder.HasKey(pt => pt.Id);
            builder.Property(pt => pt.Description).HasColumnType("nvarchar(600)").IsRequired();

            //association
            builder.HasMany(pt => pt.Permissions);

            builder.ToTable("PermissionTypes");
        }
    }
}
