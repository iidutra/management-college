namespace ManagementCollege.Models
{
    public class Student : Entity
    {
        public Student(string studentName, DateTime birthDate, int registrationNumber, double gradeStudent)
        {
            StudentName = studentName;
            BirthDate = birthDate;
            RegistrationNumber = registrationNumber;
            GradeStudent = gradeStudent;
        }

        public string StudentName { get; set; }
        public DateTime BirthDate { get; set; }
        public int RegistrationNumber { get; set; }
        public double GradeStudent { get; set; }
    }
}
