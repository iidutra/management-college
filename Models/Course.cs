namespace ManagementCollege.Models
{
    public class Course : Entity
    {
        public Course(string courseName, IList<Subject> subjects, IList<Student> students, Teacher teacher)
        {
            CourseName = courseName;
            Subjects = subjects;
            Students = students;
            Teacher = teacher;
        }

        public string CourseName { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
