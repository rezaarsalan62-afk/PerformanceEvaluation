namespace EvaluationSystem.Models
{
    public class Employee
    {
        public string PersonnelCode { get; set; } = "";

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public int JobId { get; set; }

        public string? EvaluatorCode { get; set; }
    }
}