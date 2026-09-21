namespace EvaluationSystem.Models
{
    public class EvaluationListMember
    {
        public int Id { get; set; }

        public int EvaluationListId { get; set; }

        public string PersonnelCode { get; set; } = "";
    }
}