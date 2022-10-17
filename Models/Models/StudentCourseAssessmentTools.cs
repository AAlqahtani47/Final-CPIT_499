namespace SeniorProject.Models
{
    public class StudentCourseAssessmentTools
    {
        public int Id { get; set; }
        public StudentCourse StuCourse_Id { get; set; }
        public AssessmentTools toolId { get; set; }
        public double marks { get; set; }
        public string remarks { get; set; }
        public string result { get; set; }
        public string date { get; set; }
    }
}
