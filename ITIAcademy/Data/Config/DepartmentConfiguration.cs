using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.Property(d => d.Name)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(d => d.Manager)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder.HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.DepartmentId)
                .IsRequired(false);

            builder.HasMany(d => d.Trainees)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentId)
                .IsRequired(false);

            builder.HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentId)
                .IsRequired(false);

            builder.ToTable("Departments");

            DepartmentBL departmentBL = new DepartmentBL();

            builder.HasData(departmentBL.GetDepartments());
        }
    }
}
