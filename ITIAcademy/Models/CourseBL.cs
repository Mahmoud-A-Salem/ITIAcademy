namespace ITIAcademy.Models
{
    public class CourseBL
    {
        List<Course> courses;

        public CourseBL()
        {
            courses = new List<Course>();

            // Initialize with some sample courses
            courses.Add(new Course { Id = 1, Name = "Introduction to Programming", Degree = 100, MinDegree = 50, Hours = 30, DepartmentId = 1});
            courses.Add(new Course { Id = 2, Name = "Database Management", Degree = 100, MinDegree = 50, Hours = 40, DepartmentId = 2});
            courses.Add(new Course { Id = 3, Name = "Web Development", Degree = 100, MinDegree = 50, Hours = 35, DepartmentId = 3});
        }

        public List<Course> GetCourses()
        {
            return courses;
        }
    }
}
