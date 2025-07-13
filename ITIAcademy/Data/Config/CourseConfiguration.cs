using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();

            builder.Property(c => c.Name)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Degree)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(c => c.MinDegree)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(c => c.Hours)
                .HasColumnType("INT")
                .IsRequired();

            builder.HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentId)
                .IsRequired(false);

            builder.HasMany(c => c.Instructors)
                .WithOne(i => i.Course)
                .HasForeignKey(i => i.CourseId)
                .IsRequired(false);

            builder.HasMany(c => c.TraineeCourses)
                .WithOne(tc => tc.Course)
                .HasForeignKey(tc => tc.CourseId)
                .IsRequired(false);

            builder.ToTable("Courses");

            CourseBL courseBL = new CourseBL();

            builder.HasData(courseBL.GetCourses());
        }
    }
}
