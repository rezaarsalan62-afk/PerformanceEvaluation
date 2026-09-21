using EvaluationSystem.Models;

namespace EvaluationSystem.Models.ViewModels
{
    public class EvaluationListsViewModel
    {
        public List<EvaluationList> EvaluationLists { get; set; } = new();

        public string EvaluatorCode { get; set; } = "";
    }
}