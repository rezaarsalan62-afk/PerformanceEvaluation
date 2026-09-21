using System.Collections.Generic;
using EvaluationSystem.Models;

namespace EvaluationSystem.Models.ViewModels
{
    public class EmployeeListViewModel
    {
        public EvaluationList? EvaluationList { get; set; }

        public List<Employee> Employees { get; set; } = new();

        public List<Job> Jobs { get; set; } = new();

        public List<EvaluationCriterion> Criteria { get; set; } = new();
    }
}