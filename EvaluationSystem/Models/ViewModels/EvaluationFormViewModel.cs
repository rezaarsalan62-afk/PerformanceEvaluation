using EvaluationSystem.Models;

namespace EvaluationSystem.Models.ViewModels
{
    public class EvaluationFormViewModel
    {
        public Employee Employee { get; set; } = new();

        public Job Job { get; set; } = new();

        public List<EvaluationItem> Items { get; set; } = new();

        public string? Comment { get; set; }
    }
}