namespace ITIAcademy.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageURL { get; set; }
        public string Address { get; set; }
        public string Grade { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<TraineeCourse>? traineeCourses { get; set; } = new List<TraineeCourse>();
    }
}
