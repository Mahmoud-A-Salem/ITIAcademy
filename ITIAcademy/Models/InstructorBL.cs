namespace ITIAcademy.Models
{
    public class InstructorBL
    {
        List<Instructor> Instructors;
        public InstructorBL()
        {

            Instructors = new List<Instructor>();

            Instructors.Add(new Instructor { Id = 1, Name = "Mahmoud Ali", ImageURL = "1.png", Salary = 5000m, Address = "Cairo, Egypt", DepartmentId = 1, CourseId = 1 });
            Instructors.Add(new Instructor { Id = 2, Name = "Jane Smith", ImageURL = "1.png", Salary = 4500m, Address = "New York, USA", DepartmentId = 2, CourseId = 2 });
            Instructors.Add(new Instructor { Id = 3, Name = "Bob Johnson", ImageURL = "1.png", Salary = 4700m, Address = "Los Angeles, USA", DepartmentId = 3, CourseId = 3 });
            Instructors.Add(new Instructor { Id = 4, Name = "Alice Brown", ImageURL = "2.png", Salary = 4800m, Address = "Miami, USA", DepartmentId = 1, CourseId = 1 });
        }

        public List<Instructor>? GetInstructors()
        {
            return Instructors;
        }
    }
}
