using System.Collections.Generic;

namespace EvaluationSystem.Models.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; } = new();

        public List<Job> Jobs { get; set; } = new();

        public List<EvaluationCriterion> Criteria { get; set; } = new();
    }
}