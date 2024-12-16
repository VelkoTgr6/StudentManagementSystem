using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Enumerations;
using StudentManagementSystem.Core.Models.Admin.Class;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminClassServiceTests
    {
        private Mock<IRepository> mockRepository;
        private AdminClassService adminClassService;

        [SetUp]
        public void SetUp()
        {
            mockRepository = new Mock<IRepository>();
            adminClassService = new AdminClassService(mockRepository.Object);
        }
        [Test]
        public async Task AllAsync_ShouldReturnPagedAndSortedClasses_WhenCalled()
        {

            var classes = new List<Class>
            {
                new Class
                {
                    Id = 1,
                    Name = "11 A",
                    Teacher = new Teacher { Titles = "Mr.", FirstName = "John", LastName = "Doe" },
                    Students = new List<Student> { new Student { IsDeleted = false }, new Student { IsDeleted = true } },
                    IsDeleted = false
                },
                new Class
                {
                    Id = 2,
                    Name = "12 B",
                    Teacher = new Teacher { Titles = "Ms.", FirstName = "Jane", LastName = "Smith" },
                    Students = new List<Student> { new Student { IsDeleted = false } },
                    IsDeleted = false
                }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Class>()).Returns(classes);


            var result = await adminClassService.AllAsync(sorting: ClassSorting.Name, currentPage: 1, classesPerPage: 2);

            Assert.That(result.TotalClassesCount, Is.EqualTo(2));
            Assert.That(result.Classes.Count, Is.EqualTo(2));
            Assert.That(result.Classes.First().Name, Is.EqualTo("11 A"));
            Assert.That(result.Classes.Last().Name, Is.EqualTo("12 B"));
        }

        [Test]
        public async Task ClassExistAsync_ShouldReturnTrue_WhenClassExists()
        {

            var classes = new List<Class>
            {
                new Class { Id = 1, IsDeleted = false },
                new Class { Id = 2, IsDeleted = true }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Class>()).Returns(classes);


            var result = await adminClassService.ClassExistAsync(1);


            Assert.That(result, Is.True);
        }

        [Test]
        public async Task CreateClassAsync_ShouldAddClass_WhenCalled()
        {

            var model = new ClassFormViewModel
            {
                Name = "Class C",
                TeacherId = 1,
                SelectedCourseIds = new List<int> { 1, 2 }
            };

            mockRepository.Setup(r => r.AddAsync(It.IsAny<Class>())).Returns(Task.CompletedTask);


            var result = await adminClassService.CreateClassAsync(model);


            mockRepository.Verify(r => r.AddAsync(It.Is<Class>(c => c.Name == "Class C" && c.TeacherId == 1)), Times.Once);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteClassAsync_ShouldMarkClassAsDeleted_WhenClassExists()
        {

            var classEntity = new Class { Id = 1, IsDeleted = false };

            mockRepository.Setup(r => r.GetByIdAsync<Class>(1)).ReturnsAsync(classEntity);


            await adminClassService.DeleteClassAsync(1);


            Assert.That(classEntity.IsDeleted, Is.True);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditClassAsync_ShouldUpdateClass_WhenClassExists()
        {

            var classEntity = new Class
            {
                Id = 1,
                Name = "Old Name",
                TeacherId = 1,
                ClassCourses = new List<ClassCourse>
                {
                    new ClassCourse { CourseId = 1 }
                }
            };

            var model = new ClassFormViewModel
            {
                Name = "New Name",
                TeacherId = 2,
                SelectedCourseIds = new List<int> { 2 }
            };

            mockRepository.Setup(r => r.All<Class>())
                          .Returns(new List<Class> { classEntity }.AsQueryable().BuildMock());


            await adminClassService.EditClassAsync(1, model);


            Assert.That(classEntity.Name, Is.EqualTo("New Name"));
            Assert.That(classEntity.TeacherId, Is.EqualTo(2));
            Assert.That(classEntity.ClassCourses.Count, Is.EqualTo(1));
            Assert.That(classEntity.ClassCourses.First().CourseId, Is.EqualTo(2));
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetAllClassesAsync_ShouldReturnNonDeletedClasses()
        {

            var classes = new List<Class>
            {
                new Class { Id = 1, Name = "11 A", IsDeleted = false },
                new Class { Id = 2, Name = "12 B", IsDeleted = true }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Class>()).Returns(classes);


            var result = await adminClassService.GetAllClassesAsync();


            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result.First().Name, Is.EqualTo("11 A"));
        }

        [Test]
        public async Task GetClassFormModelByIdAsync_ShouldReturnFormModel_WhenClassExists()
        {

            var classEntity = new List<Class>
            {
                new Class
                {
                    Id = 1,
                    Name = "Class A",
                    TeacherId = 2,
                    ClassCourses = new List<ClassCourse>
                    {
                        new ClassCourse { CourseId = 1 },
                        new ClassCourse { CourseId = 2 }
                    },
                    IsDeleted = false
                }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Class>()).Returns(classEntity);


            var result = await adminClassService.GetClassFormModelByIdAsync(1);


            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Class A"));
            Assert.That(result.TeacherId, Is.EqualTo(2));
            Assert.That(result.SelectedCourseIds, Is.EquivalentTo(new List<int> { 1, 2 }));
        }

        [Test]
        public void GetClassFormModelByIdAsync_ShouldThrowArgumentException_WhenClassDoesNotExist()
        {

            var classes = new List<Class>().AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Class>()).Returns(classes);

            Assert.ThrowsAsync<ArgumentException>(() => adminClassService.GetClassFormModelByIdAsync(1));
        }

        [Test]
        public void SortClassNames_ShouldSortNamesByNumberAndText_WhenCalled()
        {

            var classNames = new List<string> { "10B", "2A", "1A", "2B", "10A" };


            var result = adminClassService.SortClassNames(classNames);


            Assert.That(result, Is.EqualTo(new List<string> { "1A", "2A", "2B", "10A", "10B" }));
        }

    }
}
