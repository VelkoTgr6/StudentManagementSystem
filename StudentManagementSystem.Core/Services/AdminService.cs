﻿using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Course;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Core.Models.Teacher;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> CreateCourseAsync(CourseFormViewModel model, string publisherId)
        {
            
            var entity = new Course
            {
                Name = model.Name,
                Description = model.Description,
                TeacherId = model.TeacherId,
                PublisherId = publisherId
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<int> CreateStudentAsync(StudentFormViewModel model)
        {
            var entity = new Student
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth,
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<int> CreateTeacherAsync(TeacherFormViewModel model)
        {
            var entity = new Teacher
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Titles = model.Titles
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteAsync<T>()
        {
            switch (typeof(T).Name)
            {
                case "Student":
                    repository.DeleteStudent(new Student());
                    break;
                case "Teacher":
                    repository.DeleteTeacher(new Teacher());
                    break;
                case "Course":
                    repository.DeleteCourse(new Course());
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
            }

            await repository.SaveChangesAsync();
            
        }

        public async Task EditCourseAsync<T>(int id, CourseFormViewModel model,string publisherId)
        {
            var course = await repository.GetByIdAsync<Course>(id);

            if (course != null)
            {
                course.Name = model.Name;
                course.Description = model.Description;
                course.TeacherId = model.TeacherId;
                course.PublisherId = publisherId;
            }

            await repository.SaveChangesAsync();
        }

        public async Task EditStudentAsync<T>(int id,StudentFormViewModel model)
        {
            var entity = await repository.GetByIdAsync<Student>(id);

            if (entity != null)
            {
                entity.FirstName = model.FirstName;
                entity.MiddleName = model.MiddleName;
                entity.LastName = model.LastName;
                entity.ContactDetails = model.ContactDetails;
                entity.Email = model.Email;
                entity.PersonalId = model.PersonalId;
                entity.DateOfBirth = model.DateOfBirth;
            }

            await repository.SaveChangesAsync();
        }

        public async Task EditTeacherAsync<T>(int id, TeacherFormViewModel model)
        {
            var teacher = await repository.GetByIdAsync<Teacher>(id);

            if (teacher != null)
            {
                teacher.FirstName = model.FirstName;
                teacher.LastName = model.LastName;
                teacher.ContactDetails = model.ContactDetails;
                teacher.Titles = model.Titles;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            var students = await repository.All<T>().ToListAsync();

            return students;
        }

        public Task<T> GetByIdAsync<T>() where T : class
        {
            return repository.AllAsReadOnly<T>().FirstAsync();
        }

    }
}
