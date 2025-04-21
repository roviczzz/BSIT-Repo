using Microsoft.AspNetCore.Mvc;
using UniversityGradingSystem.Data;
using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Controllers
{
    public class SyncController : Controller
    {
        private readonly StudentInfoContext _studentContext;
        private readonly GradesInfoContext _gradesContext;
        private readonly TuitionInforContext _tuitionContext;

        public SyncController(StudentInfoContext studentContext, GradesInfoContext gradesContext, TuitionInforContext tuitionContext)
        {
            _studentContext = studentContext;
            _gradesContext = gradesContext;
            _tuitionContext = tuitionContext;
        }

        public IActionResult SyncGrades()
        {
            var students = _studentContext.StudentInfo.ToList();
            var grades = _gradesContext.GradesInfo.ToList();

            // Ensure every student has a corresponding grade entry
            foreach (var student in students)
            {
                var existingGrade = _gradesContext.GradesInfo.FirstOrDefault(g => g.StudentId == student.Id);
                if (existingGrade == null)
                {
                    _gradesContext.GradesInfo.Add(new GradesInfo { StudentId = student.Id, Name = student.Name });
                }
                else
                {
                    // Sync student name to grade entry in case of name changes
                    existingGrade.Name = student.Name;
                }
            }

            // Ensure every grade entry corresponds to an existing student
            foreach (var grade in grades)
            {
                var existingStudent = _studentContext.StudentInfo.FirstOrDefault(s => s.Id == grade.StudentId);
                if (existingStudent == null)
                {
                    _studentContext.StudentInfo.Add(new StudentInfo { Id = grade.StudentId, Name = grade.Name });
                }
                else
                {
                    // Sync grade name to student entry in case of name changes
                    existingStudent.Name = grade.Name;
                }
            }

            _gradesContext.SaveChanges();
            _studentContext.SaveChanges();
            return RedirectToAction("ViewSummary");
        }

        public IActionResult SyncTuition()
        {
            var students = _studentContext.StudentInfo.ToList();
            var tuitionRecords = _tuitionContext.TuitionInfor.ToList();

            // Ensure every student has a corresponding tuition entry
            foreach (var student in students)
            {
                var existingTuition = _tuitionContext.TuitionInfor.FirstOrDefault(t => t.StudentId == student.Id);
                if (existingTuition == null)
                {
                    _tuitionContext.TuitionInfor.Add(new TuitionInfor { StudentId = student.Id, Name = student.Name });
                }
                else
                {
                    // Sync student name to tuition entry in case of name changes
                    existingTuition.Name = student.Name;
                }
            }

            // Ensure every tuition entry corresponds to an existing student
            foreach (var tuition in tuitionRecords)
            {
                var existingStudent = _studentContext.StudentInfo.FirstOrDefault(s => s.Id == tuition.StudentId);
                if (existingStudent == null)
                {
                    _studentContext.StudentInfo.Add(new StudentInfo { Id = tuition.StudentId, Name = tuition.Name });
                }
                else
                {
                    // Sync tuition name to student entry in case of name changes
                    existingStudent.Name = tuition.Name;
                }
            }

            _tuitionContext.SaveChanges();
            _studentContext.SaveChanges();
            return RedirectToAction("ViewSummary");
        }
            public IActionResult ViewSummary()
        {
            var students = _studentContext.StudentInfo.ToList();
            var grades = _gradesContext.GradesInfo.ToList();
            var tuitions = _tuitionContext.TuitionInfor.ToList();

            var summary = from student in students
                          join grade in grades on student.Id equals grade.StudentId into g
                          from grade in g.DefaultIfEmpty()
                          join tuition in tuitions on student.Id equals tuition.StudentId into t
                          from tuition in t.DefaultIfEmpty()
                          select new StudentSummaryViewModel
                          {
                              Name = student.Name,
                              Section = student.Section,
                              SemesterGrade = grade != null ? grade.SemesterGrade : (decimal?)null,
                              Balance = tuition != null ? tuition.Balance : (decimal?)null
                          };

            return View(summary.ToList());
        }
    }
}

