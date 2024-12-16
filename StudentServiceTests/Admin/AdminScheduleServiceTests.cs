using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Contracts.Admin;
using StudentManagementSystem.Core.Models.Admin.Schedule;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminScheduleServiceTests
    {
        private Mock<IRepository> mockRepository;
        private AdminScheduleService adminScheduleService;

        [SetUp]
        public void SetUp()
        {
            mockRepository = new Mock<IRepository>();
            adminScheduleService = new AdminScheduleService(mockRepository.Object);
        }

        [Test]
        public async Task GetCourseSchedulesByIdAsync_ShouldReturnCorrectSchedules()
        {
            
            int classId = 1;
            var courseSchedules = new List<CourseSchedule>
            {
                new CourseSchedule
                {
                    Id = 1,
                    Course = new Course { Name = "Math" },
                    Class = new Class { Name = "Class A" },
                    Day = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(10, 0, 0),
                    ClassId = classId
                },
                new CourseSchedule
                {
                    Id = 2,
                    Course = new Course { Name = "Science" },
                    Class = new Class { Name = "Class A" },
                    Day = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(11, 0, 0),
                    ClassId = classId
                }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<CourseSchedule>())
                .Returns(courseSchedules);

            
            var result = await adminScheduleService.GetCourseSchedulesByIdAsync(classId);

            
            Assert.NotNull(result);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result, Has.Exactly(1).Matches<CourseScheduleViewModel>(cs =>
                cs.Id == 1 &&
                cs.CourseName == "Math" &&
                cs.ClassName == "Class A" &&
                cs.Day == "Monday" &&
                cs.StartTime == "09:00" &&
                cs.EndTime == "10:00"));
        
        }

        [Test]
        public async Task GetCourseSchedulesByIdAsync_ShouldReturnEmptyList_WhenNoSchedulesExist()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<CourseSchedule>())
                .Returns(Enumerable.Empty<CourseSchedule>().AsQueryable().BuildMock());

            
            var result = await adminScheduleService.GetCourseSchedulesByIdAsync(1);

            
            Assert.IsNotNull(result);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task AddCourseScheduleAsync_ShouldAddCourseSchedule_WhenValidModelProvided()
        {
            
            var model = new CourseScheduleInputModel
            {
                CourseId = 1,
                ClassId = 1,
                Day = DayOfWeek.Monday,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0)
            };

            mockRepository.Setup(repo => repo.AddAsync(It.IsAny<CourseSchedule>())).Returns(Task.CompletedTask);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminScheduleService.AddCourseScheduleAsync(model);

            
            mockRepository.Verify(repo => repo.AddAsync(It.IsAny<CourseSchedule>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteCourseScheduleAsync_ShouldDeleteSchedule_WhenScheduleExists()
        {
            
            var courseSchedule = new CourseSchedule
            {
                Id = 1,
                CourseId = 1,
                ClassId = 1,
                Day = DayOfWeek.Monday,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0)
            };

            mockRepository.Setup(repo => repo.GetByIdAsync<CourseSchedule>(1))
                .ReturnsAsync(courseSchedule);
            mockRepository.Setup(repo => repo.DeleteSchedule(It.IsAny<CourseSchedule>())).Verifiable();
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminScheduleService.DeleteCourseScheduleAsync(1);

            
            mockRepository.Verify(repo => repo.DeleteSchedule(It.IsAny<CourseSchedule>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteCourseScheduleAsync_ShouldDoNothing_WhenScheduleDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.GetByIdAsync<CourseSchedule>(1))
                .ReturnsAsync((CourseSchedule)null);

            
            await adminScheduleService.DeleteCourseScheduleAsync(1);

            
            mockRepository.Verify(repo => repo.DeleteSchedule(It.IsAny<CourseSchedule>()), Times.Never);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Never);
        }
        [Test]
        public async Task EditCourseScheduleAsync_ShouldUpdateSchedule_WhenValidModelProvided()
        {
            
            var existingSchedule = new CourseSchedule
            {
                Id = 1,
                CourseId = 1,
                ClassId = 1,
                Day = DayOfWeek.Monday,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0)
            };

            var model = new CourseScheduleInputModel
            {
                CourseId = 2,
                ClassId = 2,
                Day = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(11, 0, 0)
            };

            mockRepository.Setup(repo => repo.All<CourseSchedule>())
                .Returns(new List<CourseSchedule> { existingSchedule }.AsQueryable().BuildMock());
            mockRepository.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1);

            
            await adminScheduleService.EditCourseScheduleAsync(1, model);

            
            Assert.That(existingSchedule.CourseId, Is.EqualTo(2));
            Assert.That(existingSchedule.ClassId, Is.EqualTo(2));
            Assert.That(existingSchedule.Day, Is.EqualTo(DayOfWeek.Wednesday));
            Assert.That(existingSchedule.StartTime, Is.EqualTo(new TimeSpan(9, 0, 0)));
            Assert.That(existingSchedule.EndTime, Is.EqualTo(new TimeSpan(11, 0, 0)));
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }
        [Test]
        public async Task GetCourseScheduleByIdAsync_ShouldReturnCourseSchedule_WhenScheduleExists()
        {
            
            var courseSchedule = new CourseSchedule
            {
                Id = 1,
                CourseId = 1,
                ClassId = 1,
                Day = DayOfWeek.Monday,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0)
            };

            var expected = new CourseScheduleInputModel
            {
                CourseId = 1,
                ClassId = 1,
                Day = DayOfWeek.Monday,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                SelectedClassId = 1,
                SelectedCourseId = 1,
                SelectedDay = DayOfWeek.Monday
            };

            mockRepository.Setup(repo => repo.AllAsReadOnly<CourseSchedule>())
                .Returns(new List<CourseSchedule> { courseSchedule }.AsQueryable().BuildMock());

            
            var result = await adminScheduleService.GetCourseScheduleByIdAsync(1);

            
            Assert.IsNotNull(result);
            Assert.That(result.CourseId, Is.EqualTo(expected.CourseId));
            Assert.That(result.ClassId, Is.EqualTo(expected.ClassId));
            Assert.That(result.Day, Is.EqualTo(expected.Day));
            Assert.That(result.StartTime, Is.EqualTo(expected.StartTime));
            Assert.That(result.EndTime, Is.EqualTo(expected.EndTime));
        }

        [Test]
        public async Task GetCourseScheduleByIdAsync_ShouldThrowException_WhenScheduleDoesNotExist()
        {
            
            mockRepository.Setup(repo => repo.AllAsReadOnly<CourseSchedule>())
                .Returns(Enumerable.Empty<CourseSchedule>().AsQueryable().BuildMock());

            var exception = Assert.ThrowsAsync<Exception>(() => adminScheduleService.GetCourseScheduleByIdAsync(99));
            Assert.That(exception.Message, Is.EqualTo("Course schedule not found"));
        }

    }
}
