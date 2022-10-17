namespace SeniorProject.Models
{
    public class ArticulationMatrix
    {
        public int Id { get; set; }
        public TeachersCourse teacherCourse_Id { get; set; }
        public string CLO { get; set; }
        public LOD LOD_Id { get; set; }
        public int SO { get; set; }
        public bool Assessing_SO { get; set; }
    }
}
