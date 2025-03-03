using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Models.Admin.Teacher;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminTeacherServiceTests
    {
        private Mock<IRepository> mockRepository;
        private AdminTeacherService adminTeacherService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            adminTeacherService = new AdminTeacherService(mockRepository.Object);
        }

        [Test]
        public async Task AllAsync_ShouldReturnTeachers_WhenNoFilterIsApplied()
        {
            
            var teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    IsDeleted = false,
                    School = new School { Name = "School A" },
                    Courses = new List<Course>
                    {
                        new Course { Id = 1, Name = "Math" },
                        new Course { Id = 2, Name = "Science" }
                    }
                },
                new Teacher
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    IsDeleted = false,
                    School = new School { Name = "School B" },
                    Courses = new List<Course>
                    {
                        new Course { Id = 3, Name = "English" }
                    }
                }
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Teacher>())
                          .Returns(teachers.AsQueryable().BuildMock());

            var result = await adminTeacherService.AllAsync();

            Assert.That(result.Teachers, Is.Not.Null); 
            Assert.That(result.Teachers.Count(), Is.EqualTo(2));

            var teacher1 = result.Teachers.Last();
            Assert.That(teacher1.FirstName, Is.EqualTo("John"));
            Assert.That(teacher1.LastName, Is.EqualTo("Doe"));
            Assert.That(teacher1.SchoolName, Is.EqualTo("School A"));
            Assert.That(teacher1.Courses.Count(), Is.EqualTo(2));

            var teacher2 = result.Teachers.First();
            Assert.That(teacher2.FirstName, Is.EqualTo("Jane"));
            Assert.That(teacher2.LastName, Is.EqualTo("Smith"));
            Assert.That(teacher2.SchoolName, Is.EqualTo("School B"));
            Assert.That(teacher2.Courses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task AllAsync_ShouldReturnTeachers_WhenCalled()
        {
            
            var teachers = new List<Teacher>
            {
                new Teacher { Id = 1, FirstName = "John", LastName = "Doe", IsDeleted = false, School = new School { Name = "School1" }, Courses = new List<Course> { new Course { Name = "Math" } } },
                new Teacher { Id = 2, FirstName = "Jane", LastName = "Smith", IsDeleted = false, School = new School { Name = "School2" }, Courses = new List<Course> { new Course { Name = "Science" } } }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(teachers);

            
            var result = await adminTeacherService.AllAsync();

            
            Assert.That(result.TotalTeachersCount, Is.EqualTo(2));
            Assert.That(result.Teachers.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task CreateTeacherAsync_ShouldCreateTeacher_WhenValidDataIsProvided()
        {
            
            var teacherModel = new TeacherFormViewModel
            {
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123",
                Titles = "Mr.",
                Email = "john@example.com",
                SelectedCourseIds = new List<int> { 1 }
            };

            var mockFile = new Mock<IFormFile>();
            var userId = "user-123";
            mockRepository.Setup(repo => repo.GetIdByEmailAsync(teacherModel.Email)).ReturnsAsync(userId);

            mockRepository.Setup(repo => repo.AddAsync(It.IsAny<Teacher>()))
                   .Callback<Teacher>(t => t.Id = 1);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            var result = await adminTeacherService.CreateTeacherAsync(teacherModel, mockFile.Object);

            
            Assert.That(result, Is.EqualTo(1));
            mockRepository.Verify(repo => repo.AddAsync(It.IsAny<Teacher>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }
        [Test]
        public async Task DeleteTeacherAsync_ShouldDeleteTeacher_WhenTeacherIsNotDeleted()
        {
            
            var teacher = new Teacher { Id = 1, IsDeleted = false, UserId = "user-123" };
            mockRepository.Setup(repo => repo.GetByIdAsync<Teacher>(teacher.Id)).ReturnsAsync(teacher);
            mockRepository.Setup(repo => repo.GetIdentityUserByIdAsync(teacher.UserId)).ReturnsAsync(new IdentityUser());

            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminTeacherService.DeleteTeacherAsync(teacher.Id);

            
            Assert.IsTrue(teacher.IsDeleted);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditTeacherAsync_ShouldUpdateTeacherDetails()
        {
            
            var teacherId = 1;
            var teacher = new Teacher
            {
                Id = teacherId,
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123456789",
                Titles = "Mr.",
                Email = "john.doe@example.com",
                ProfilePicturePath = "/images/profiles/jane.jpg",
                IsDeleted = false,
                Courses = new List<Course> { new Course { Id = 1, Name = "Math" } }
            };

            var model = new TeacherFormViewModel
            {
                FirstName = "Jane",
                LastName = "Smith",
                ContactDetails = "987654321",
                Titles = "Ms.",
                Email = "jane.smith@example.com",
                ProfilePicturePath = "/images/profiles/jane.jpg",
                SelectedCourseIds = new List<int> { 2 }
            };

            mockRepository.Setup(r => r.All<Teacher>())
                          .Returns(new List<Teacher> { teacher }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.GetByIdAsync<Course>(It.IsAny<int>()))
                          .ReturnsAsync(new Course { Id = 2, Name = "Science" });

            
            await adminTeacherService.EditTeacherAsync(teacherId, model, null);

            
            Assert.That(teacher.FirstName, Is.EqualTo("Jane"));
            Assert.That(teacher.LastName, Is.EqualTo("Smith"));
            Assert.That(teacher.ContactDetails, Is.EqualTo("987654321"));
            Assert.That(teacher.Titles, Is.EqualTo("Ms."));
            Assert.That(teacher.Email, Is.EqualTo("jane.smith@example.com") );
            Assert.That(teacher.ProfilePicturePath, Is.EqualTo("/images/profiles/jane.jpg"));
            Assert.That(teacher.Courses.Count, Is.EqualTo(1));
            Assert.That(teacher.Courses.First().Id, Is.EqualTo(2));
        }

        [Test]
        public async Task EditTeacherAsync_ShouldAddAndRemoveCourses()
        {
            
            var teacherId = 1;
            var teacher = new Teacher
            {
                Id = teacherId,
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123456789",
                Titles = "Mr.",
                Email = "john.doe@example.com",
                IsDeleted = false,
                Courses = new List<Course> { new Course { Id = 1, Name = "Math" }, new Course { Id = 3, Name = "History" } }
            };

            var model = new TeacherFormViewModel
            {
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123456789",
                Titles = "Mr.",
                Email = "john.doe@example.com",
                ProfilePicturePath = "/images/profiles/john.jpg",
                SelectedCourseIds = new List<int> { 2 }
            };

            mockRepository.Setup(r => r.All<Teacher>())
                          .Returns(new List<Teacher> { teacher }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.GetByIdAsync<Course>(It.IsAny<int>()))
                          .ReturnsAsync(new Course { Id = 2, Name = "Science" });

            
            await adminTeacherService.EditTeacherAsync(teacherId, model, null);

            
            Assert.That(teacher.Courses.Count, Is.EqualTo(1));
            Assert.That(teacher.Courses.First().Id, Is.EqualTo(2));
        }
    
        [Test]
        public async Task ExistAsync_ShouldReturnTrue_WhenTeacherExists()
        {
            
            var teacherId = 1;
            mockRepository.Setup(repo => repo.AllAsReadOnly<Teacher>())
                          .Returns(new List<Teacher> { new Teacher { Id = teacherId, IsDeleted = false } }.AsQueryable().BuildMock());

            
            var result = await adminTeacherService.ExistAsync(teacherId);

            
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistAsync_ShouldReturnFalse_WhenTeacherDoesNotExist()
        {
            
            var teacherId = 1;
            mockRepository.Setup(repo => repo.AllAsReadOnly<Teacher>())
                          .Returns(new List<Teacher>().AsQueryable().BuildMock());

            
            var result = await adminTeacherService.ExistAsync(teacherId);

            
            Assert.IsFalse(result);
        }
        [Test]
        public async Task GetTeacherDetailsModelByIdAsync_ShouldReturnTeacherDetails_WhenTeacherExists()
        {
            
            var teacherId = 1;
            var teacher = new Teacher
            {
                Id = teacherId,
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123456789",
                Email = "john.doe@example.com",
                ProfilePicturePath = "/images/profiles/john.jpg",
                School = new School { Name = "Test School" },
                Courses = new List<Course>
            {
                new Course { Id = 1, Name = "Math", IsDeleted = false }
            },
                IsDeleted = false
            };

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>())
                .Returns(new List<Teacher> { teacher }.AsQueryable().BuildMock());

            
            var result = await adminTeacherService.GetTeacherDetailsModelByIdAsync(teacherId);

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(teacherId));
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.ContactDetails, Is.EqualTo("123456789"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.ProfilePicturePath, Is.EqualTo("/images/profiles/john.jpg"));
            Assert.That(result.SchoolName, Is.EqualTo("Test School"));
            Assert.That(result.Courses, Has.Exactly(1).Items);
            Assert.That(result.Courses.First().Id, Is.EqualTo(1));
            Assert.That(result.Courses.First().Name, Is.EqualTo("Math"));
        }

        [Test]
        public async Task GetTeacherDetailsModelByIdAsync_ShouldThrowArgumentException_WhenTeacherDoesNotExist()
        {
            
            var teacherId = 1;

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>())
                .Returns(new List<Teacher>().AsQueryable().BuildMock());

             
            await Task.Run(() => Assert.ThrowsAsync<ArgumentException>(async () => await adminTeacherService.GetTeacherDetailsModelByIdAsync(teacherId)));
        }

        [Test]
        public async Task CreateTeacherAsync_ShouldReturnTeacherId_WhenTeacherIsCreated()
        {
            
            var model = new TeacherFormViewModel
            {
                FirstName = "John",
                LastName = "Doe",
                ContactDetails = "123456789",
                Titles = "Mr.",
                Email = "john.doe@example.com",
                SelectedCourseIds = new List<int> { 1, 2 }
            };
            var teacherId = 1;
            mockRepository.Setup(r => r.GetIdByEmailAsync(model.Email)).ReturnsAsync("userId");
            mockRepository.Setup(r => r.AddAsync(It.IsAny<Teacher>())).Callback<Teacher>(t => t.Id = teacherId);

            
            var result = await adminTeacherService.CreateTeacherAsync(model, null);

            
            Assert.That(result, Is.EqualTo(teacherId));
        }

        [Test]
        public async Task DeleteTeacherAsync_ShouldMarkTeacherAsDeleted_WhenTeacherExists()
        {
            
            var teacherId = 1;
            var teacher = new Teacher { Id = teacherId, IsDeleted = false };
            mockRepository.Setup(r => r.GetByIdAsync<Teacher>(teacherId)).ReturnsAsync(teacher);

            
            await adminTeacherService.DeleteTeacherAsync(teacherId);

            
            Assert.That(teacher.IsDeleted, Is.True);
        }

        [Test]
        public async Task GetAllTeachersNamesAsync_ShouldReturnAllTeacherNames()
        {
            
            var teachers = new List<Teacher>
            {
                new Teacher { FirstName = "John", LastName = "Doe", Titles = "Mr.", IsDeleted = false },
                new Teacher { FirstName = "Jane", LastName = "Smith", Titles = "Ms.", IsDeleted = false }
            };
            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(teachers.AsQueryable().BuildMock());

            
            var result = await adminTeacherService.GetAllTeachersNamesAsync();

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Contains.Item("Mr. John Doe"));
            Assert.That(result, Contains.Item("Ms. Jane Smith"));
        }
    }
}
