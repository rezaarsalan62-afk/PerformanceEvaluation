namespace EvaluationSystem.Models
{
    public class Evaluation
    {
        public string EmployeeCode { get; set; } = "";

        public int EvaluationListId { get; set; }

        public string EvaluatorCode { get; set; } = "";

        public int CriterionId { get; set; }

        public int Score { get; set; }

        public string Comment { get; set; } = "";

        public DateTime EvaluationDate { get; set; }
    }
}