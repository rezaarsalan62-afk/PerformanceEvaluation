namespace EvaluationSystem.Models
{
    public class EvaluationItem
    {
        public EvaluationCriterion Criterion { get; set; } = new();

        public int Score { get; set; }
    }
}