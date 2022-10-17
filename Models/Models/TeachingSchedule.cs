namespace SeniorProject.Models
{
    public class TeachingSchedule
    {
        public int Id { get; set; }
        public TeachersCourse teacherCourse_Id { get; set; }
        public int week_Number { get; set; }
    }
}
