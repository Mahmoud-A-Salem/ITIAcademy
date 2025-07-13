namespace ITIAcademy.Models
{
    public class TraineeCourse
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        public int TraineeId { get; set; }
        public int CourseId { get; set; }
        public Trainee Trainee { get; set; }
        public Course Course { get; set; }

    }
}
