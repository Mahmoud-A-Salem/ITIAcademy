namespace ITIAcademy.Models
{
    public class DepartmentBL
    {
        List<Department> departments;
        public DepartmentBL()
        {
            departments = new List<Department>();

            departments.Add(new Department { Id = 1, Name = "Computer Science", Manager = "Dr. Maha Ali" });
            departments.Add(new Department { Id = 2, Name = "Information Technology", Manager = "Dr. Ahmed Hassan" });
            departments.Add(new Department { Id = 3, Name = "Software Development", Manager = "Dr. Sara Maged" });
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
    }
}
