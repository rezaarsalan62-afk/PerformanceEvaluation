namespace EvaluationSystem.Models
{
    public class EvaluationCriterion
    {
        public int Id { get; set; }

        public int JobId { get; set; }

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";
    }
}