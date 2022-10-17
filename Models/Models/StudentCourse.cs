namespace SeniorProject.Models
{
    public class StudentCourse
    {
        public int StuCourse_Id { get; set; }
        public Student StudentId { get; set; }
        public Course course_Id { get; set; }
        public Session session_Id { get; set; }
        public double marks { get; set; }
        public string result { get; set; }
    }
}
