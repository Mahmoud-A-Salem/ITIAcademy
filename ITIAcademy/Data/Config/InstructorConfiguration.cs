using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedNever();

            builder.Property(t => t.Name)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.ImageURL)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.Salary)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(t => t.Address)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("Instructors");

            InstructorBL instructorBL = new InstructorBL();

            builder.HasData(instructorBL.GetInstructors());

        }
    }
}
