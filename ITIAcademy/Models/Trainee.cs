using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Trainee
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name of the Trainee is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
        [RegularExpression(@".\.(jpg|png)")]
        public string? ImageURL { get; set; }
        [Required(ErrorMessage = "The address is required")]
        public string Address { get; set; }
        public string Grade { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<TraineeCourse>? traineeCourses { get; set; } = new List<TraineeCourse>();
    }
}
