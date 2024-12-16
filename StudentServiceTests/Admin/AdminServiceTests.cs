using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminServiceTests
    {
        private Mock<IRepository> mockRepository;
        private AdminService adminService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            adminService = new AdminService(mockRepository.Object);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteStudent_WhenStudentTypeIsProvided()
        {
            
            var student = new Student();
            mockRepository.Setup(repo => repo.DeleteStudent(It.IsAny<Student>()));
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminService.DeleteAsync<Student>();

            
            mockRepository.Verify(repo => repo.DeleteStudent(It.IsAny<Student>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteTeacher_WhenTeacherTypeIsProvided()
        {
            
            var teacher = new Teacher();
            mockRepository.Setup(repo => repo.DeleteTeacher(It.IsAny<Teacher>()));
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminService.DeleteAsync<Teacher>();

            
            mockRepository.Verify(repo => repo.DeleteTeacher(It.IsAny<Teacher>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteAsync_ShouldDeleteCourse_WhenCourseTypeIsProvided()
        {
            
            var course = new Course();
            mockRepository.Setup(repo => repo.DeleteCourse(It.IsAny<Course>()));
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminService.DeleteAsync<Course>();

            
            mockRepository.Verify(repo => repo.DeleteCourse(It.IsAny<Course>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetAllAsync_ShouldReturnAllStudents_WhenStudentTypeIsProvided()
        {
            
            var students = new List<Student> { new Student(), new Student() };
            mockRepository.Setup(repo => repo.All<Student>()).Returns(students.AsQueryable().BuildMock());

            
            var result = await adminService.GetAllAsync<Student>();

            
            Assert.That(result.Count(), Is.EqualTo(2));
            mockRepository.Verify(repo => repo.All<Student>(), Times.Once);
        }

        [Test]
        public async Task GetAllAsync_ShouldReturnAllTeachers_WhenTeacherTypeIsProvided()
        {
            
            var teachers = new List<Teacher> { new Teacher(), new Teacher() };
            mockRepository.Setup(repo => repo.All<Teacher>()).Returns(teachers.AsQueryable().BuildMock());

            
            var result = await adminService.GetAllAsync<Teacher>();

            
            Assert.That(result.Count(), Is.EqualTo(2));
            mockRepository.Verify(repo => repo.All<Teacher>(), Times.Once);
        }

        [Test]
        public async Task GetByIdAsync_ShouldReturnStudent_WhenStudentTypeIsProvided()
        {
            
            var student = new Student();
            mockRepository.Setup(repo => repo.AllAsReadOnly<Student>()).Returns(new List<Student> { student }.AsQueryable().BuildMock());

            
            var result = await adminService.GetByIdAsync<Student>();

            
            Assert.IsNotNull(result);
            mockRepository.Verify(repo => repo.AllAsReadOnly<Student>(), Times.Once);
        }

        [Test]
        public async Task GetByIdAsync_ShouldReturnTeacher_WhenTeacherTypeIsProvided()
        {
            
            var teacher = new Teacher();
            mockRepository.Setup(repo => repo.AllAsReadOnly<Teacher>()).Returns(new List<Teacher> { teacher }.AsQueryable().BuildMock());

            
            var result = await adminService.GetByIdAsync<Teacher>();

            
            Assert.IsNotNull(result);
            mockRepository.Verify(repo => repo.AllAsReadOnly<Teacher>(), Times.Once);
        }

        [Test]
        public async Task GetUserIdByEmail_ShouldReturnUserId_WhenEmailExists()
        {
            
            var email = "test@example.com";
            var userId = "user-123";
            mockRepository.Setup(repo => repo.GetIdByEmailAsync(email)).ReturnsAsync(userId);

            
            var result = await adminService.GetUserIdByEmail(email);

            
            Assert.That(result, Is.EqualTo(userId));
            mockRepository.Verify(repo => repo.GetIdByEmailAsync(email), Times.Once);
        }

        [Test]
        public async Task EmailExistAsync_ShouldReturnTrue_WhenEmailExists()
        {
            
            var email = "test@example.com";
            mockRepository.Setup(repo => repo.EmailExistAsync(email)).ReturnsAsync(true);

            
            var result = await adminService.EmailExistAsync(email);

            
            Assert.IsTrue(result);
            mockRepository.Verify(repo => repo.EmailExistAsync(email), Times.Once);
        }

        [Test]
        public async Task EmailExistAsync_ShouldReturnFalse_WhenEmailDoesNotExist()
        {
            
            var email = "test@example.com";
            mockRepository.Setup(repo => repo.EmailExistAsync(email)).ReturnsAsync(false);

            
            var result = await adminService.EmailExistAsync(email);

            
            Assert.IsFalse(result);
            mockRepository.Verify(repo => repo.EmailExistAsync(email), Times.Once);
        }

    }
}
