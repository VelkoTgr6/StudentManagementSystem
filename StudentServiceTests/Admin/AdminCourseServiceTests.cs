using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Models.Admin.Course;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminCourseServiceTests
    {
        private Mock<IRepository> mockRepository;
        private AdminCourseService courseService;

        [SetUp]
        public void SetUp()
        {
            mockRepository = new Mock<IRepository>();
            courseService = new AdminCourseService(mockRepository.Object);
        }

        [Test]
        public async Task AllAsync_ShouldReturnCourses_WhenCoursesExist()
        {
            
            var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false, Teacher = new Teacher { FirstName = "John", LastName = "Doe" } },
                new Course { Id = 2, Name = "Science 101", IsDeleted = false, Teacher = new Teacher { FirstName = "Jane", LastName = "Smith" } }
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>()).Returns(courses.AsQueryable().BuildMock());

            
            var result = await courseService.AllAsync();

            
            Assert.IsNotNull(result);
            Assert.That(result.Courses, Has.Exactly(2).Items);
            Assert.That(result.Courses, Has.Exactly(1).Matches<CourseServiceModel>(c => c.Name == "Math 101"));
        }

        [Test]
        public async Task AllAsync_ShouldFilterByTeacher_WhenTeacherNameIsProvided()
        {
            
            var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false, Teacher = new Teacher { Titles = "Dr.", FirstName = "John", LastName = "Doe" } },
                new Course { Id = 2, Name = "Science 101", IsDeleted = false, Teacher = new Teacher { FirstName = "Jane", LastName = "Smith" } }
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>()).Returns(courses.AsQueryable().BuildMock());

            
            var result = await courseService.AllAsync(teacher: "Dr. John Doe");

            
            Assert.IsNotNull(result);
            Assert.That(result.Courses, Has.Exactly(1).Items);
            Assert.That(result.Courses, Has.Exactly(1).Matches<CourseServiceModel>(c => c.Name == "Math 101"));
        }

        [Test]
        public async Task CourseExistAsync_ShouldReturnTrue_WhenCourseExists()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>()).Returns(new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false }
            }.AsQueryable().BuildMock());

            
            var result = await courseService.CourseExistAsync(1);

            
            Assert.IsTrue(result);
        }

        [Test]
        public async Task CourseExistAsync_ShouldReturnFalse_WhenCourseDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>()).Returns(new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false }
            }.AsQueryable().BuildMock());

            
            var result = await courseService.CourseExistAsync(99);

            
            Assert.IsFalse(result);
        }

        [Test]
        public async Task CreateCourseAsync_ShouldReturnCourseId_WhenCourseIsCreated()
        {
            
            var courseForm = new CourseFormViewModel
            {
                Name = "History 101",
                Description = "Basic history course",
                TeacherId = 1
            };

            var publisherId = "publisher123";
            var newCourseId = 1;

            mockRepository.Setup(repo => repo.AddAsync(It.IsAny<Course>())).Callback<Course>(c => c.Id = newCourseId).Returns(Task.CompletedTask);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            var result = await courseService.CreateCourseAsync(courseForm, publisherId);

            
            Assert.That(result, Is.EqualTo(newCourseId));
            mockRepository.Verify(repo => repo.AddAsync(It.Is<Course>(c =>
                c.Name == courseForm.Name &&
                c.Description == courseForm.Description &&
                c.TeacherId == courseForm.TeacherId &&
                c.PublisherId == publisherId)), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetCourseDetailsModelByIdAsync_ShouldReturnCourseDetailsViewModel_WhenCourseExistsAndNotDeleted()
        {
            
            var course = new Course
            {
                Id = 1,
                Name = "Math 101",
                Description = "Basic Math Course",
                Teacher = new Teacher
                {
                    Titles = "Dr.",
                    FirstName = "John",
                    LastName = "Doe"
                },
                IsDeleted = false
            };

            var expectedCourseDetailsViewModel = new CourseDetailsViewModel
            {
                Id = course.Id,
                Teacher = "Dr. John Doe",
                Name = course.Name,
                Description = course.Description
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course> { course }.AsQueryable().BuildMock());

            
            var result = await courseService.GetCourseDetailsModelByIdAsync(1);

            
            Assert.IsNotNull(result);
            Assert.That(result.Id, Is.EqualTo(expectedCourseDetailsViewModel.Id));
            Assert.That(result.Teacher, Is.EqualTo(expectedCourseDetailsViewModel.Teacher));
            Assert.That(result.Name, Is.EqualTo(expectedCourseDetailsViewModel.Name));
            Assert.That(result.Description, Is.EqualTo(expectedCourseDetailsViewModel.Description));
        }

        [Test]
        public async Task GetCourseDetailsModelByIdAsync_ShouldThrowArgumentException_WhenCourseDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course>().AsQueryable().BuildMock());

             
            var exception = Assert.ThrowsAsync<ArgumentException>(() => courseService.GetCourseDetailsModelByIdAsync(99));
            Assert.That(exception.Message, Is.EqualTo("Course with ID 99 not found."));
        }

        [Test]
        public async Task GetCourseDetailsModelByIdAsync_ShouldThrowArgumentException_WhenCourseIsDeleted()
        {
            
            var course = new Course
            {
                Id = 1,
                Name = "Math 101",
                Description = "Basic Math Course",
                Teacher = new Teacher
                {
                    Titles = "Dr.",
                    FirstName = "John",
                    LastName = "Doe"
                },
                IsDeleted = true
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course> { course }.AsQueryable().BuildMock());

             
            var exception = Assert.ThrowsAsync<ArgumentException>(() => courseService.GetCourseDetailsModelByIdAsync(1));
            Assert.That(exception.Message, Is.EqualTo("Course with ID 1 not found."));
        }


        [Test]
        public async Task DeleteCourseAsync_ShouldSetCourseToDeleted_WhenCourseExistsAndNotDeleted()
        {
            
            var course = new Course { Id = 1, Name = "Math 101", IsDeleted = false };
            mockRepository.Setup(repo => repo.GetByIdAsync<Course>(1)).ReturnsAsync(course);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await courseService.DeleteCourseAsync(1);

            
            Assert.IsTrue(course.IsDeleted);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteCourseAsync_ShouldNotChangeCourse_WhenCourseAlreadyDeleted()
        {
            
            var course = new Course { Id = 1, Name = "Math 101", IsDeleted = true };
            mockRepository.Setup(repo => repo.GetByIdAsync<Course>(1)).ReturnsAsync(course);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await courseService.DeleteCourseAsync(1);

            
            Assert.IsTrue(course.IsDeleted);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditCourseAsync_ShouldUpdateCourse_WhenCourseExistsAndNotDeleted()
        {
            
            var course = new Course { Id = 1, Name = "Math 101", Description = "Old Description", IsDeleted = false };
            var model = new CourseFormViewModel
            {
                Name = "Math 102",
                Description = "New Description",
                TeacherId = 2
            };
            var publisherId = "publisher123";

            mockRepository.Setup(repo => repo.GetByIdAsync<Course>(1)).ReturnsAsync(course);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await courseService.EditCourseAsync(1, model, publisherId);

            
            Assert.That(course.Name, Is.EqualTo("Math 102"));
            Assert.That(course.Description, Is.EqualTo("New Description"));
            Assert.That(course.TeacherId, Is.EqualTo(2));
            Assert.That(course.PublisherId, Is.EqualTo("publisher123"));
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditCourseAsync_ShouldNotUpdateCourse_WhenCourseIsDeleted()
        {
            
            var course = new Course { Id = 1, Name = "Math 101", Description = "Old Description", IsDeleted = true };
            var model = new CourseFormViewModel
            {
                Name = "Math 102",
                Description = "New Description",
                TeacherId = 2
            };
            var publisherId = "publisher123";

            mockRepository.Setup(repo => repo.GetByIdAsync<Course>(1)).ReturnsAsync(course);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await courseService.EditCourseAsync(1, model, publisherId);

            
            Assert.That(course.Name, Is.EqualTo("Math 101"));
            Assert.That(course.Description, Is.EqualTo("Old Description"));
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetAllCoursesAsync_ShouldReturnListOfCourses_WhenCoursesExist()
        {
            
            var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false },
                new Course { Id = 2, Name = "Science 101", IsDeleted = false }
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(courses.AsQueryable().BuildMock());

            
            var result = await courseService.GetAllCoursesAsync();

            
            Assert.IsNotNull(result);
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result, Has.Exactly(1).Matches<CourseServiceModel>(c => c.Name == "Math 101"));
        }

        [Test]
        public async Task GetAllCoursesNamesAsync_ShouldReturnCourseNames_WhenCoursesExist()
        {
            
            var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Math 101", IsDeleted = false },
                new Course { Id = 2, Name = "Science 101", IsDeleted = false }
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(courses.AsQueryable().BuildMock());

            
            var result = await courseService.GetAllCoursesNamesAsync();

            
            Assert.IsNotNull(result);
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result, Has.Exactly(1).EqualTo("Math 101"));
        }

        [Test]
        public async Task GetCourseByIdAsync_ShouldReturnCourse_WhenCourseExists()
        {
            
            var course = new CourseServiceModel { Id = 1, Name = "Math 101" };
            mockRepository.Setup(repo => repo.GetByIdAsync<CourseServiceModel>(1)).ReturnsAsync(course);

            
            var result = await courseService.GetCourseByIdAsync(1);

            
            Assert.IsNotNull(result);
            Assert.That(result.Id, Is.EqualTo(1));
        }

        [Test]
        public async Task GetCourseByIdAsync_ShouldThrowException_WhenCourseDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.GetByIdAsync<CourseServiceModel>(99)).ReturnsAsync((CourseServiceModel)null);

             
            var exception = Assert.ThrowsAsync<ArgumentException>(() => courseService.GetCourseByIdAsync(99));
            Assert.That(exception.Message, Is.EqualTo("Course with ID 99 not found."));
        }

        [Test]
        public async Task GetCourseFormModelByIdAsync_ShouldReturnCourseFormViewModel_WhenCourseExistsAndNotDeleted()
        {
            
            var course = new Course
            {
                Id = 1,
                Name = "Math 101",
                Description = "Basic Math Course",
                TeacherId = 1,
                IsDeleted = false
            };

            var expectedCourseFormViewModel = new CourseFormViewModel
            {
                Name = course.Name,
                Description = course.Description,
                TeacherId = course.TeacherId ?? 0
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course> { course }.AsQueryable().BuildMock());

            
            var result = await courseService.GetCourseFormModelByIdAsync(1);

            
            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo(expectedCourseFormViewModel.Name));
            Assert.That(result.Description, Is.EqualTo(expectedCourseFormViewModel.Description));
            Assert.That(result.TeacherId, Is.EqualTo(expectedCourseFormViewModel.TeacherId));
        }

        [Test]
        public async Task GetCourseFormModelByIdAsync_ShouldThrowArgumentException_WhenCourseDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course>().AsQueryable().BuildMock());

             
            var exception = Assert.ThrowsAsync<ArgumentException>(() => courseService.GetCourseFormModelByIdAsync(99));
            Assert.AreEqual("Course with ID 99 not found.", exception.Message);
        }

        [Test]
        public async Task GetCourseFormModelByIdAsync_ShouldThrowArgumentException_WhenCourseIsDeleted()
        {
            
            var course = new Course
            {
                Id = 1,
                Name = "Math 101",
                Description = "Basic Math Course",
                TeacherId = 1,
                IsDeleted = true
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<Course>())
                .Returns(new List<Course> { course }.AsQueryable().BuildMock());

             
            var exception = Assert.ThrowsAsync<ArgumentException>(() => courseService.GetCourseFormModelByIdAsync(1));
            Assert.That(exception.Message, Is.EqualTo("Course with ID 1 not found."));
        }

    }
}
