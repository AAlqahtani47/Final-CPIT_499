namespace SeniorProject.Models
{
    public class Session
    {
        public int session_Id { get; set; }
        public string title { get; set; }
        public Department Dept_Id { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string description { get; set; }


    }
}
