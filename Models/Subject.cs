namespace ManagementCollege.Models
{
    public class Subject : Entity
    {
        public Subject(string subjectName, IList<Student> students, Teacher teacher)
        {
            SubjectName = subjectName;
            Students = students;
            Teacher = teacher;
        }

        public string SubjectName { get; set; }
        public IList<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
