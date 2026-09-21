using EvaluationSystem.Models;
using EvaluationSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        // =========================================================
        // رسته‌های شغلی
        // =========================================================

        private List<JobCategory> GetJobCategoriesData()
        {
            return new List<JobCategory>
            {
                new JobCategory
                {
                    Id = 1,
                    Title = "منابع انسانی"
                },

                new JobCategory
                {
                    Id = 2,
                    Title = "مالی و حسابداری"
                }
            };
        }


        // =========================================================
        // مشاغل
        // =========================================================

        private List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "مدیر منابع انسانی",
                    JobCategoryId = 1,
                    Level = JobLevel.Managerial
                },

                new Job
                {
                    Id = 2,
                    Title = "کارشناس مالی",
                    JobCategoryId = 2,
                    Level = JobLevel.Specialist
                },

                new Job
                {
                    Id = 3,
                    Title = "کارشناس منابع انسانی",
                    JobCategoryId = 1,
                    Level = JobLevel.Specialist
                }
            };
        }


        // =========================================================
        // شرح وظایف
        // =========================================================

        private List<JobDuty> GetJobDuties()
        {
            return new List<JobDuty>
            {
                // -------------------------------------------------
                // مدیر منابع انسانی
                // -------------------------------------------------

                new JobDuty
                {
                    Id = 101,
                    JobId = 1,
                    Description = "برنامه‌ریزی و سازماندهی فعالیت‌های منابع انسانی"
                },

                new JobDuty
                {
                    Id = 102,
                    JobId = 1,
                    Description = "نظارت بر اجرای فرآیندهای منابع انسانی"
                },

                new JobDuty
                {
                    Id = 103,
                    JobId = 1,
                    Description = "مدیریت و کنترل فرآیند ارزیابی عملکرد کارکنان"
                },

                new JobDuty
                {
                    Id = 104,
                    JobId = 1,
                    Description = "تدوین و بهبود سیاست‌ها و رویه‌های منابع انسانی"
                },

                new JobDuty
                {
                    Id = 105,
                    JobId = 1,
                    Description = "ارائه گزارش‌های مدیریتی حوزه منابع انسانی"
                },


                // -------------------------------------------------
                // کارشناس مالی
                // -------------------------------------------------

                new JobDuty
                {
                    Id = 201,
                    JobId = 2,
                    Description = "بررسی و کنترل اسناد مالی"
                },

                new JobDuty
                {
                    Id = 202,
                    JobId = 2,
                    Description = "تهیه گزارش‌های مالی دوره‌ای"
                },

                new JobDuty
                {
                    Id = 203,
                    JobId = 2,
                    Description = "کنترل حساب‌ها و بررسی مغایرت‌های مالی"
                },

                new JobDuty
                {
                    Id = 204,
                    JobId = 2,
                    Description = "ثبت و پیگیری اسناد و اطلاعات مالی"
                },

                new JobDuty
                {
                    Id = 205,
                    JobId = 2,
                    Description = "همکاری در تهیه صورت‌های مالی"
                },


                // -------------------------------------------------
                // کارشناس منابع انسانی
                // -------------------------------------------------

                new JobDuty
                {
                    Id = 301,
                    JobId = 3,
                    Description = "اجرای فرآیندهای امور کارکنان"
                },

                new JobDuty
                {
                    Id = 302,
                    JobId = 3,
                    Description = "تهیه گزارش‌های منابع انسانی"
                },

                new JobDuty
                {
                    Id = 303,
                    JobId = 3,
                    Description = "پیگیری و ثبت اطلاعات پرسنلی"
                },

                new JobDuty
                {
                    Id = 304,
                    JobId = 3,
                    Description = "همکاری در اجرای فرآیند ارزیابی عملکرد"
                },

                new JobDuty
                {
                    Id = 305,
                    JobId = 3,
                    Description = "پاسخگویی و پیگیری درخواست‌های کارکنان"
                }
            };
        }


        // =========================================================
        // معیارهای ارزیابی
        // =========================================================

        private List<EvaluationCriterion> GetCriteria()
        {
            return new List<EvaluationCriterion>
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
        }


        // =========================================================
        // کارکنان
        // =========================================================

        private List<Employee> GetEmployees()
        {
            return new List<Employee>
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
        }


        // =========================================================
        // لیست‌های ارزیابی
        // =========================================================

        private List<EvaluationList> GetEvaluationLists()
        {
            return new List<EvaluationList>
            {
                new EvaluationList
                {
                    Id = 1,
                    Title = "لیست مدیریت ۱",
                    EvaluatorCode = "1001",
                    PerformanceLevel = "B",
                    PerPersonScore = 85
                },

                new EvaluationList
                {
                    Id = 2,
                    Title = "لیست مدیریت ۲",
                    EvaluatorCode = "1002",
                    PerformanceLevel = "C",
                    PerPersonScore = 75
                }
            };
        }


        // =========================================================
        // اعضای لیست‌های ارزیابی
        // =========================================================

        private List<EvaluationListMember> GetEvaluationListMembers()
        {
            return new List<EvaluationListMember>
            {
                // لیست ۱
                new EvaluationListMember
                {
                    Id = 1,
                    EvaluationListId = 1,
                    PersonnelCode = "1002"
                },

                new EvaluationListMember
                {
                    Id = 2,
                    EvaluationListId = 1,
                    PersonnelCode = "1003"
                },


                // لیست ۲
                new EvaluationListMember
                {
                    Id = 3,
                    EvaluationListId = 2,
                    PersonnelCode = "1004"
                }
            };
        }


        // =========================================================
        // لیست ارزیابی‌های ثبت‌شده
        // فعلاً خالی است چون ذخیره واقعی هنوز پیاده نشده
        // =========================================================

        private List<Evaluation> GetEvaluations()
        {
            return new List<Evaluation>();
        }


        // =========================================================
        // محاسبه اطلاعات یک لیست
        // =========================================================

        private void CalculateEvaluationListInfo(
            EvaluationList evaluationList)
        {
            var members =
                GetEvaluationListMembers()
                    .Where(x =>
                        x.EvaluationListId ==
                        evaluationList.Id)
                    .ToList();


            evaluationList.EmployeeCount =
                members.Count;


            evaluationList.AvailableScore =
                evaluationList.EmployeeCount *
                evaluationList.PerPersonScore;


            /*
             * در این مرحله ذخیره واقعی امتیاز نهایی افراد
             * هنوز پیاده نشده است.
             *
             * بنابراین فعلاً مجموع امتیاز نهایی صفر است.
             */

            evaluationList.TotalFinalScore = 0;

            evaluationList.IsValid = false;
        }


        // =========================================================
        // صفحه لیست‌های ارزیابی
        // =========================================================

        public IActionResult Index()
        {
            string currentEvaluatorCode =
                User.FindFirst("EvaluatorCode")?.Value ?? "";


            var evaluationLists =
                GetEvaluationLists()
                    .Where(x =>
                        x.EvaluatorCode ==
                        currentEvaluatorCode)
                    .ToList();


            foreach (var evaluationList in evaluationLists)
            {
                CalculateEvaluationListInfo(
                    evaluationList);
            }


            var model =
                new EvaluationListsViewModel
                {
                    EvaluationLists =
                        evaluationLists,

                    EvaluatorCode =
                        currentEvaluatorCode
                };


            return View(model);
        }


        // =========================================================
        // اعضای یک لیست
        // =========================================================

        public IActionResult Members(int id)
        {
            string currentEvaluatorCode =
                User.FindFirst("EvaluatorCode")?.Value ?? "";


            var evaluationList =
                GetEvaluationLists()
                    .FirstOrDefault(x =>
                        x.Id == id &&
                        x.EvaluatorCode ==
                        currentEvaluatorCode);


            if (evaluationList == null)
            {
                return NotFound();
            }


            CalculateEvaluationListInfo(
                evaluationList);


            var memberCodes =
                GetEvaluationListMembers()
                    .Where(x =>
                        x.EvaluationListId ==
                        id)
                    .Select(x =>
                        x.PersonnelCode)
                    .ToHashSet();


            var employees =
                GetEmployees()
                    .Where(x =>
                        memberCodes.Contains(
                            x.PersonnelCode))
                    .ToList();


            var model =
                new EmployeeListViewModel
                {
                    EvaluationList =
                        evaluationList,

                    Employees =
                        employees,

                    Jobs =
                        GetJobs(),

                    Criteria =
                        GetCriteria()
                };


            return View(model);
        }


        // =========================================================
        // فرم ارزیابی
        // =========================================================

        public IActionResult Evaluate(
            string id,
            int? listId)
        {
            string currentEvaluatorCode =
                User.FindFirst("EvaluatorCode")?.Value ?? "";


            var jobs = GetJobs();

            var criteria = GetCriteria();

            var employees = GetEmployees();

            var lists = GetEvaluationLists();

            var members = GetEvaluationListMembers();


            EvaluationList? evaluationList =
                null;

            Employee? employee =
                null;


            // -----------------------------------------------------
            // وقتی ارزیابی از داخل یک لیست باز شده
            // -----------------------------------------------------

            if (listId.HasValue)
            {
                evaluationList =
                    lists.FirstOrDefault(x =>
                        x.Id == listId.Value &&
                        x.EvaluatorCode ==
                        currentEvaluatorCode);


                if (evaluationList == null)
                {
                    return NotFound();
                }


                var isMember =
                    members.Any(x =>
                        x.EvaluationListId ==
                        evaluationList.Id &&
                        x.PersonnelCode ==
                        id);


                if (!isMember)
                {
                    return NotFound();
                }


                employee =
                    employees.FirstOrDefault(x =>
                        x.PersonnelCode == id);
            }


            // -----------------------------------------------------
            // سازگاری با لینک‌های قدیمی
            // -----------------------------------------------------

            else
            {
                employee =
                    employees.FirstOrDefault(x =>
                        x.PersonnelCode == id &&
                        x.EvaluatorCode ==
                        currentEvaluatorCode);


                if (employee != null)
                {
                    evaluationList =
                        lists.FirstOrDefault(list =>
                            list.EvaluatorCode ==
                            currentEvaluatorCode &&
                            members.Any(member =>
                                member.EvaluationListId ==
                                list.Id &&
                                member.PersonnelCode ==
                                employee.PersonnelCode));
                }
            }


            if (employee == null)
            {
                return NotFound();
            }


            if (evaluationList == null)
            {
                return NotFound();
            }


            var job =
                jobs.FirstOrDefault(x =>
                    x.Id == employee.JobId);


            if (job == null)
            {
                return NotFound();
            }


            var employeeCriteria =
                criteria
                    .Where(x =>
                        x.JobId ==
                        employee.JobId)
                    .ToList();


            var items =
                employeeCriteria
                    .Select(c =>
                        new EvaluationItem
                        {
                            Criterion = c,
                            Score = 0
                        })
                    .ToList();


            var model =
                new EvaluationFormViewModel
                {
                    Employee =
                        employee,

                    Job =
                        job,

                    Items =
                        items,

                    EvaluationListId =
                        evaluationList.Id
                };


            return View(model);
        }


        // =========================================================
        // دریافت رسته‌های شغلی
        // =========================================================

        [HttpGet]
        public IActionResult GetJobCategories()
        {
            var categories =
                GetJobCategoriesData()
                    .Select(c =>
                        new
                        {
                            id = c.Id,
                            title = c.Title
                        })
                    .ToList();


            return Json(categories);
        }


        // =========================================================
        // دریافت مشاغل یک رسته
        // =========================================================

        [HttpGet]
        public IActionResult GetJobsByCategory(
            int categoryId)
        {
            var jobs =
                GetJobs()
                    .Where(j =>
                        j.JobCategoryId ==
                        categoryId)
                    .Select(j =>
                        new
                        {
                            id = j.Id,
                            title = j.Title
                        })
                    .ToList();


            return Json(jobs);
        }


        // =========================================================
        // دریافت شرح وظایف یک شغل
        // =========================================================

        [HttpGet]
        public IActionResult GetJobDuties(
            int jobId)
        {
            var duties =
                GetJobDuties()
                    .Where(d =>
                        d.JobId == jobId)
                    .Select(d =>
                        new
                        {
                            id = d.Id,
                            description =
                                d.Description
                        })
                    .ToList();


            return Json(duties);
        }
    }
}