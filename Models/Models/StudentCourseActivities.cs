namespace SeniorProject.Models
{
    public class StudentCourseActivities
    {
        public int Id { get; set; }
        public StudentCourse StuCourse_Id { get; set; }
        public Activities Activities_Id { get; set; }
        public string remarks { get; set; }
        public string result { get; set; }
        public string date { get; set; }

    }
}
