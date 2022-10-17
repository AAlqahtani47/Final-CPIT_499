namespace SeniorProject.Models
{
    public class ArticulationMatrixActivities
    {
        public int Id { get; set; }
        public ArticulationMatrix ar_Id { get; set; }
        public Activities activity_Id { get; set; }
        public bool status { get; set; }
    }
}
