namespace EvaluationSystem.Models
{
    public class EvaluationList
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string EvaluatorCode { get; set; } = "";

        public string PerformanceLevel { get; set; } = "";

        public decimal PerPersonScore { get; set; }

        public int EmployeeCount { get; set; }

        public decimal AvailableScore { get; set; }

        public decimal TotalFinalScore { get; set; }

        public bool IsValid { get; set; }
    }
}