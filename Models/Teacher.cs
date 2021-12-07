namespace ManagementCollege.Models
{
    public class Teacher
    {
        public Teacher(string teacherName, DateTime birthDate, decimal salary)
        {
            TeacherName = teacherName;
            BirthDate = birthDate;
            Salary = salary;
        }

        public string TeacherName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}
