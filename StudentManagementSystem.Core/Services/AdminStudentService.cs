using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Student;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Core.Services
{
    public class AdminStudentService : IAdminStudentService
    {
        private readonly IRepository repository;

        public AdminStudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<StudentQueryServiceModel> AllAsync(string? studentClass = null, string? searchTerm = null, StudentSorting sorting = StudentSorting.Name, int currentPage = 1, int studentsPerPage = 10)
        {
            var studentsQuery = repository.AllAsReadOnly<Student>();

            if (!string.IsNullOrWhiteSpace(studentClass))
            {
                studentsQuery = studentsQuery.Where(s => s.Class.Name == studentClass);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                studentsQuery = studentsQuery
                    .Where(s => s.FirstName.ToLower().Contains(searchTerm) ||
                            s.MiddleName.ToLower().Contains(searchTerm) ||
                            s.LastName.ToLower().Contains(searchTerm) ||
                            s.ContactDetails.Contains(searchTerm) ||
                            s.Email.ToLower().Contains(searchTerm) ||
                            s.Class.Name.ToLower().Contains(searchTerm));
            }

            studentsQuery = sorting switch
            {
                StudentSorting.Name => studentsQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName),
                StudentSorting.Email => studentsQuery.OrderBy(s => s.Email),
                StudentSorting.Class => studentsQuery.OrderBy(s => s.Class.Name),
                StudentSorting.Grade => studentsQuery.OrderByDescending(s => s.Performance),
                _ => studentsQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName)
            };

            var students = await studentsQuery
                .Skip((currentPage - 1) * studentsPerPage)
                .Take(studentsPerPage)
                .Select(s => new StudentServiceModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    Class = s.Class.Name
                })
                .ToListAsync();

            var totalStudentsCount = await studentsQuery.CountAsync();

            return new StudentQueryServiceModel
            {
                TotalStudentsCount = totalStudentsCount,
                Students = students
            };
        }

        public async Task<int> CreateStudentAsync(StudentFormViewModel model)
        {
            var userId = await repository.GetIdByEmailAsync(model.Email);

            var entity = new Student
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactDetails = model.ContactDetails,
                Email = model.Email,
                PersonalId = model.PersonalId,
                DateOfBirth = model.DateOfBirth,
                UserId = userId,
                ClassId = model.ClassId
            };

            await repository.AddAsync(entity);
            await repository.SaveChangesAsync();

            return entity.Id;
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditStudentAsync(int id, StudentFormViewModel model)
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
                entity.ClassId = model.ClassId;
                entity.ProfilePicturePath = model.ProfilePicturePath;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllAsReadOnly<Student>().AnyAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<StudentServiceModel>> GetAllStudentsAsync()
        {
            return await repository.AllAsReadOnly<StudentServiceModel>().ToListAsync();
        }

        public Task<StudentServiceModel> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<StudentDetailsViewModel> GetStudentDetailsModelByIdAsync(int id)
        {
            return await repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == id)
                .Select(s => new StudentDetailsViewModel()
                {
                    Id = s.Id,
                    ProfilePicturePath = s.ProfilePicturePath,
                    PersonalId = s.PersonalId,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    DateOfBirth = s.DateOfBirth,
                    ContactDetails = s.ContactDetails,
                    Performance = s.Performance.ToString(),
                    Grades = s.Grades
                })
                .FirstAsync();
        }

        public Task<StudentFormViewModel?> GetStudentFormModelByIdAsync(int id)
        {
            var student = repository.AllAsReadOnly<Student>()
                .Where(s => s.Id == id)
                .Select(s => new StudentFormViewModel
                {
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                    ContactDetails = s.ContactDetails,
                    Email = s.Email,
                    PersonalId = s.PersonalId,
                    DateOfBirth = s.DateOfBirth,
                    ClassId = s.ClassId
                })
                .FirstOrDefaultAsync();

            return student;
        }
    }
}
