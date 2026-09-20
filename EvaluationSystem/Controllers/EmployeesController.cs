using EvaluationSystem.Models;
using EvaluationSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            // دریافت کد ارزیاب از کاربر وارد شده
            string currentEvaluatorCode =
                User.FindFirst("EvaluatorCode")?.Value ?? "";

            // لیست مشاغل - فعلاً آزمایشی
            var jobs = new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "مدیر منابع انسانی"
                },
                new Job
                {
                    Id = 2,
                    Title = "کارشناس مالی"
                },
                new Job
                {
                    Id = 3,
                    Title = "کارشناس منابع انسانی"
                }
            };

            // لیست معیارهای ارزیابی - فعلاً آزمایشی
            var criteria = new List<EvaluationCriterion>
            {
                new EvaluationCriterion
                {
                    Id = 1,
                    JobId = 2,
                    Title = "مسئولیت‌پذیری",
                    Description = "میزان مسئولیت‌پذیری در انجام وظایف"
                },
                new EvaluationCriterion
                {
                    Id = 2,
                    JobId = 2,
                    Title = "دقت در انجام کار",
                    Description = "میزان دقت و توجه به جزئیات"
                },
                new EvaluationCriterion
                {
                    Id = 3,
                    JobId = 2,
                    Title = "کار تیمی",
                    Description = "توانایی همکاری و تعامل با سایر همکاران"
                },
                new EvaluationCriterion
                {
                    Id = 4,
                    JobId = 3,
                    Title = "مسئولیت‌پذیری",
                    Description = "میزان مسئولیت‌پذیری در انجام وظایف"
                },
                new EvaluationCriterion
                {
                    Id = 5,
                    JobId = 3,
                    Title = "مهارت ارتباطی",
                    Description = "توانایی برقراری ارتباط مؤثر"
                }
            };

            // لیست کارکنان - فعلاً آزمایشی
            var employees = new List<Employee>
            {
                new Employee
                {
                    PersonnelCode = "1001",
                    FirstName = "رضا",
                    LastName = "محمدی",
                    JobId = 1,
                    EvaluatorCode = null
                },
                new Employee
                {
                    PersonnelCode = "1002",
                    FirstName = "علی",
                    LastName = "احمدی",
                    JobId = 2,
                    EvaluatorCode = "1001"
                },
                new Employee
                {
                    PersonnelCode = "1003",
                    FirstName = "مریم",
                    LastName = "رضایی",
                    JobId = 3,
                    EvaluatorCode = "1001"
                },
                new Employee
                {
                    PersonnelCode = "1004",
                    FirstName = "سارا",
                    LastName = "اکبری",
                    JobId = 2,
                    EvaluatorCode = "1002"
                }
            };

            // فقط کارکنان مربوط به ارزیاب فعلی
            var myEmployees = employees
                .Where(e => e.EvaluatorCode == currentEvaluatorCode)
                .ToList();

            var model = new EmployeeListViewModel
            {
                Employees = myEmployees,
                Jobs = jobs,
                Criteria = criteria
            };

            return View(model);
        }

        public IActionResult Evaluate(string id)
        {
            // کد ارزیاب وارد شده
            string currentEvaluatorCode =
                User.FindFirst("EvaluatorCode")?.Value ?? "";

            // لیست مشاغل
            var jobs = new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "مدیر منابع انسانی"
                },
                new Job
                {
                    Id = 2,
                    Title = "کارشناس مالی"
                },
                new Job
                {
                    Id = 3,
                    Title = "کارشناس منابع انسانی"
                }
            };

            // لیست معیارها
            var criteria = new List<EvaluationCriterion>
            {
                new EvaluationCriterion
                {
                    Id = 1,
                    JobId = 2,
                    Title = "مسئولیت‌پذیری",
                    Description = "میزان مسئولیت‌پذیری در انجام وظایف"
                },
                new EvaluationCriterion
                {
                    Id = 2,
                    JobId = 2,
                    Title = "دقت در انجام کار",
                    Description = "میزان دقت و توجه به جزئیات"
                },
                new EvaluationCriterion
                {
                    Id = 3,
                    JobId = 2,
                    Title = "کار تیمی",
                    Description = "توانایی همکاری و تعامل با سایر همکاران"
                },
                new EvaluationCriterion
                {
                    Id = 4,
                    JobId = 3,
                    Title = "مسئولیت‌پذیری",
                    Description = "میزان مسئولیت‌پذیری در انجام وظایف"
                },
                new EvaluationCriterion
                {
                    Id = 5,
                    JobId = 3,
                    Title = "مهارت ارتباطی",
                    Description = "توانایی برقراری ارتباط مؤثر"
                }
            };

            // لیست کارکنان
            var employees = new List<Employee>
            {
                new Employee
                {
                    PersonnelCode = "1001",
                    FirstName = "رضا",
                    LastName = "محمدی",
                    JobId = 1,
                    EvaluatorCode = null
                },
                new Employee
                {
                    PersonnelCode = "1002",
                    FirstName = "علی",
                    LastName = "احمدی",
                    JobId = 2,
                    EvaluatorCode = "1001"
                },
                new Employee
                {
                    PersonnelCode = "1003",
                    FirstName = "مریم",
                    LastName = "رضایی",
                    JobId = 3,
                    EvaluatorCode = "1001"
                },
                new Employee
                {
                    PersonnelCode = "1004",
                    FirstName = "سارا",
                    LastName = "اکبری",
                    JobId = 2,
                    EvaluatorCode = "1002"
                }
            };

            // پیدا کردن کارمند مورد نظر
            var employee = employees
                .FirstOrDefault(e =>
                    e.PersonnelCode == id &&
                    e.EvaluatorCode == currentEvaluatorCode);

            // اگر این کارمند متعلق به ارزیاب فعلی نباشد
            if (employee == null)
            {
                return NotFound();
            }

            // پیدا کردن شغل
            var job = jobs
                .FirstOrDefault(j => j.Id == employee.JobId);

            if (job == null)
            {
                return NotFound();
            }

            // معیارهای مربوط به شغل
            var employeeCriteria = criteria
                .Where(c => c.JobId == employee.JobId)
                .ToList();

            // ساخت آیتم‌های ارزیابی
            var items = employeeCriteria
                .Select(c => new EvaluationItem
                {
                    Criterion = c,
                    Score = 0
                })
                .ToList();

            // ساخت ViewModel
            var model = new EvaluationFormViewModel
            {
                Employee = employee,
                Job = job,
                Items = items
            };

            return View(model);
        }
    }
}