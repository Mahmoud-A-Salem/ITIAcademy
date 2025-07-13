namespace ITIAcademy.Models
{
    public class TraineeBL
    {
        List<Trainee> trainees;

        public TraineeBL()
        {
            trainees = new List<Trainee>();
            // Initialize with some sample trainees
            trainees.Add(new Trainee { Id = 1, Name = "Ahmed Ali", ImageURL = "1.png", Address = "Cairo, Egypt", Grade = "Level 1", DepartmentId = 1 });
            trainees.Add(new Trainee { Id = 2, Name = "Sara Mohamed", ImageURL = "2.png", Address = "Giza, Egypt", Grade = "Level 2", DepartmentId = 2 });
            trainees.Add(new Trainee { Id = 3, Name = "Omar Hassan", ImageURL = "1.png", Address = "Alexandria, Egypt", Grade = "Level 3", DepartmentId = 3 });
        }

        public List<Trainee> GetTrainees()
        {
            return trainees;
        }
    }
}
