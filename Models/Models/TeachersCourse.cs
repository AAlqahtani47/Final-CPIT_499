namespace SeniorProject.Models
{
    public class TeachersCourse
    {
        public int teacherCourse_Id { get; set; }
        public Course course_Id { get; set; }
        public Teachers teacher_Id { get; set; }
        public String SemesterStart { get; set; }
        public String SemesterEnd { get; set; }
    }
}
