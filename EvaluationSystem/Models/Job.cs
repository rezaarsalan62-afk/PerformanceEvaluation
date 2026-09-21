namespace EvaluationSystem.Models
{
    public enum JobLevel
    {
        Managerial = 1,
        Specialist = 2,
        Other = 3
    }

    public class Job
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public int JobCategoryId { get; set; }

        public JobLevel Level { get; set; }
    }
}