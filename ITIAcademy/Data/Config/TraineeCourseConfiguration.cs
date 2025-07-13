using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIAcademy.Data.Config
{
    public class TraineeCourseConfiguration : IEntityTypeConfiguration<TraineeCourse>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TraineeCourse> builder)
        {
            builder.HasKey(tc => tc.Id);
            builder.Property(tc => tc.Id).ValueGeneratedNever();

            builder.Property(tc => tc.Degree)
                .HasColumnType("INT")
                .IsRequired();
        }
    }
}
