namespace ITIAcademy.Models
{
    public class TraineeCourseBL
    {
        List<TraineeCourse> traineeCourses;
        public TraineeCourseBL()
        {
            traineeCourses = new List<TraineeCourse>();

            traineeCourses.Add(new TraineeCourse { Id = 1, TraineeId = 1, CourseId = 1, Degree = 85 });
            traineeCourses.Add(new TraineeCourse { Id = 2, TraineeId = 2, CourseId = 2, Degree = 90 });
            traineeCourses.Add(new TraineeCourse { Id = 3, TraineeId = 3, CourseId = 3, Degree = 78 });
        }
        public List<TraineeCourse> GetTraineeCourses()
        {
            return traineeCourses;
        }
    }
}
