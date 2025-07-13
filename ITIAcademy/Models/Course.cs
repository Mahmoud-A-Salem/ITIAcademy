namespace ITIAcademy.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        
        public ICollection<Instructor>? Instructors { get; set; } = new List<Instructor>();
        public ICollection<TraineeCourse>? TraineeCourses { get; set; } = new List<TraineeCourse>();
    }
}
