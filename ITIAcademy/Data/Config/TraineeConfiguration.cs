using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class TraineeConfiguration : IEntityTypeConfiguration<Trainee>
    {
        public void Configure(EntityTypeBuilder<Trainee> builder)
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

            builder.Property(t => t.Address)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.Grade)
                .HasColumnType("VarChar")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(t => t.traineeCourses)
                .WithOne(tc => tc.Trainee)
                .HasForeignKey(i => i.CourseId)
                .IsRequired(false);

            builder.ToTable("Trainees");

            TraineeBL traineeBL = new TraineeBL();

            builder.HasData(traineeBL.GetTrainees());
        }
    }
}
