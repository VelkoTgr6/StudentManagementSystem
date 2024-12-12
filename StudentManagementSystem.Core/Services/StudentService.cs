﻿using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistByIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Student>()
                .AnyAsync(s => s.UserId == userId);
        }

        public async Task<IEnumerable<StudentAbsencesViewModel>> GetAllAbsencesAsync(int studentId)
        {
            var excusedAbsences = await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId && a.IsDeleted)
                .CountAsync();

            var absences =await repository.AllAsReadOnly<Absence>()
                .Where(a => a.StudentId == studentId)
                .Select(a => new StudentAbsencesViewModel
                {
                    Date = a.Date.ToString("dd/MM/yyyy"),
                    CourseName = a.Course.Name,
                    ExcusedAbsences = excusedAbsences
                })
                .ToListAsync();

            return absences;
        }

        public async Task<IEnumerable<StudentGradesViewModel>> GetAllGradesAsync(int studentId)
        {
            var studentClassId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => s.ClassId)
                .FirstOrDefaultAsync();

            var courses = await repository.AllAsReadOnly<Course>()
                .Where(c => c.CourseClasses.Any(cc => cc.ClassId == studentClassId))
                .ToListAsync();

            var student = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName
                })
                .FirstOrDefaultAsync();

            var grades = await repository.AllAsReadOnly<Grade>()
                .Where(g => g.StudentId == studentId)
                .Include(g => g.Course)
                .ToListAsync();

            var courseGrades = courses.Select(course => new StudentGradesViewModel
            {
                CourseName = course.Name,
                Grades = grades
                    .Where(grade => grade.CourseId == course.Id)
                    .Select(g=> new GradeServiceModel()
                    {
                        GradeScore = g.GradeScore.ToString(),
                        GradeType = g.GradeType,
                    })
                    .ToList(),
                AverageGrade = grades.Average(g => g.GradeScore).ToString(),
                StudentName = student.FirstName + " " + student.LastName
            }).ToList();

            

            return courseGrades;
        }

        public async Task<IEnumerable<StudentNewsViewModel>> GetAllNewsForStudentAsync(int studentId)
        {
            var teacherId = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s=>s.Class)
                .Include(s => s.Class.Teacher)
                .Select(s=>s.Class.Teacher.UserId)
                .FirstOrDefaultAsync();

            var teacherName = await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Include(s => s.Class)
                .Include(s => s.Class.Teacher)
                .Select(s => $"{s.Class.Teacher.Titles} {s.Class.Teacher.FirstName} {s.Class.Teacher.LastName}")
                .FirstOrDefaultAsync();


            var news = await repository.AllAsReadOnly<News>()
                .Where(n => n.PublisherId == teacherId)
                .OrderByDescending(n => n.Date)
                .Select(n => new StudentNewsViewModel
                {
                    Title = n.Title,
                    Content = n.Content,
                    CreatedAt = n.Date.ToString("dd/MM/yyyy"),
                    CreatedBy = teacherName
                })
                .ToListAsync();

            return news;
        }

        public async Task<IEnumerable<StudentRemarksViewModel>> GetAllRemarksAsync(int studentId)
        {
            var remarks =await repository.AllAsReadOnly<Remark>()
                .Where(r => r.StudentId == studentId)
                .Select(r => new StudentRemarksViewModel
                {
                    Content = r.RemarkText,
                    Date = r.Date.ToString("dd/MM/yyyy"),
                    TeacherName =r.Teacher.Titles + " " + r.Teacher.FirstName + " " + r.Teacher.LastName,
                    CourseName = r.Course.Name
                })
                .ToListAsync();

            return remarks;
        }

        public async Task<StudentHomePageViewModel> GetHomePageAsync(int studentId)
        {
            var student =await repository.AllAsReadOnly<Student>()
                .Include(s=>s.Аbsences)
                .Include(s => s.Class)
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new StudentHomePageViewModel
                {
                    Name = s.FirstName + " " + s.LastName,
                    SchoolName = s.School.Name,
                    ClassName = s.Class.Name,
                    ClassTeacher = s.Class.Teacher.Titles + " " + s.Class.Teacher.FirstName + " " + s.Class.Teacher.LastName,
                    AbsencesCount = s.Аbsences.Count().ToString(),
                    AverageGrade = s.Grades.Average(g => g.GradeScore).ToString(),
                    GradesCount = s.Grades.Count().ToString(),
                    Remarks = s.Remarks.Count().ToString(),
                })
                .FirstOrDefaultAsync();

            return student;
        }

        public async Task<IEnumerable<StudentScheduleViewModel>> GetScheduleAsync(int studentId)
        {
            var classId =await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => s.ClassId)
                .FirstOrDefaultAsync();

            var schedule =await repository.AllAsReadOnly<CourseSchedule>()
                .Include(s => s.Course)
                .Where(s => s.ClassId == classId)
                .Select(s => new StudentScheduleViewModel
                {
                    CourseName = s.Course.Name,
                    StartTime = s.StartTime.ToString(),
                    EndTime = s.EndTime.ToString(),
                    Day = s.Day.ToString(),
                    TeacherName = s.Course.Teacher.Titles + " " + s.Course.Teacher.FirstName + " " + s.Course.Teacher.LastName
                })
                .ToListAsync();

            return schedule;
        }

        public async Task<StudentProfileViewModel> GetStudentDetailsAsync(int studentId)
        {
            var student =await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == studentId && !s.IsDeleted)
                .Select(s => new StudentProfileViewModel
                {
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    BirthDate = s.DateOfBirth.ToString("dd/MM/yyyy"),
                    PersonalIdentificationNumber = s.PersonalId,
                    SchoolName = s.School.Name,
                    ClassName = s.Class.Name,
                    Email = s.Email,
                    ContactDetails = s.ContactDetails,
                    ProfilePicturePath = s.ProfilePicturePath
                })
                .FirstOrDefaultAsync();

            if (student == null)
            {
                throw new ArgumentException();
            }

            return student;
        }

        public async Task<int> GetStudentIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Student>()
                .Where(s => s.UserId == userId)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();
        }
    }
}
