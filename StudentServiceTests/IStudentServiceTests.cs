using Moq;
using NUnit.Framework;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Student;

namespace StudentServiceTests
{
    [TestFixture]
    public class Tests
    {
        private Mock<IStudentService> _studentServiceMock;

        [SetUp]
        public void SetUp()
        {
            // Create a new mock instance of IStudentService
            _studentServiceMock = new Mock<IStudentService>();
        }

        [Test]
        public async Task ExistByIdAsync_ReturnsTrue_WhenUserExists()
        {
            // Arrange
            var userId = "existingUserId";
            _studentServiceMock.Setup(service => service.ExistByIdAsync(userId)).ReturnsAsync(true);

            // Act
            var result = await _studentServiceMock.Object.ExistByIdAsync(userId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task GetStudentIdAsync_ReturnsStudentId_WhenUserExists()
        {
            // Arrange
            var userId = "existingUserId";
            var expectedStudentId = 123;
            _studentServiceMock.Setup(service => service.GetStudentIdAsync(userId)).ReturnsAsync(expectedStudentId);

            // Act
            var result = await _studentServiceMock.Object.GetStudentIdAsync(userId);

            // Assert
            Assert.AreEqual(expectedStudentId, result);
        }

        [Test]
        public async Task GetAllNewsForStudentAsync_ReturnsNewsList_WhenStudentHasNews()
        {
            // Arrange
            var studentId = 123;
            var expectedNews = new List<StudentNewsViewModel>
            {
                new StudentNewsViewModel { Title = "News 1", Content = "Content 1" },
                new StudentNewsViewModel { Title = "News 2", Content = "Content 2" }
            };
            _studentServiceMock.Setup(service => service.GetAllNewsForStudentAsync(studentId)).ReturnsAsync(expectedNews);

            // Act
            var result = await _studentServiceMock.Object.GetAllNewsForStudentAsync(studentId);

            // Assert
            Assert.AreEqual(expectedNews.Count, result.Count());
        }

        [Test]
        public async Task GetAllGradesAsync_ReturnsGradesList_WhenStudentHasGrades()
        {
            // Arrange
            var studentId = 123;
            var expectedGrades = new List<StudentGradesViewModel>
            {
                new StudentGradesViewModel 
                {
                    CourseName = "Math",
                    Grades = new List<GradeServiceModel> 
                    {
                        new GradeServiceModel
                        {
                            GradeScore = "2",
                            GradeType = "Test"
                        }
                    },
                    AverageGrade = "4.50",
                    StudentName = "John Doe"
                },
                new StudentGradesViewModel {
                    CourseName = "English",
                    Grades =  new List<GradeServiceModel>
                    {
                        new GradeServiceModel
                        {
                            GradeScore = "2",
                            GradeType = "Test"
                        }
                    },
                    AverageGrade = "3.50",
                    StudentName = "John Doe"
                }
            };
            _studentServiceMock.Setup(service => service.GetAllGradesAsync(studentId)).ReturnsAsync(expectedGrades);

            // Act
            var result = await _studentServiceMock.Object.GetAllGradesAsync(studentId);

            // Assert
            Assert.AreEqual(expectedGrades.Count, result.Count());
        }

        [Test]
        public async Task GetAllRemarksAsync_ReturnsRemarksList_WhenStudentHasRemarks()
        {
            // Arrange
            var studentId = 123;
            var expectedRemarks = new List<StudentRemarksViewModel>
            {
                new StudentRemarksViewModel { Content = "Good performance" },
                new StudentRemarksViewModel { Content = "Needs improvement" }
            };
            _studentServiceMock.Setup(service => service.GetAllRemarksAsync(studentId)).ReturnsAsync(expectedRemarks);

            // Act
            var result = await _studentServiceMock.Object.GetAllRemarksAsync(studentId);

            // Assert
            Assert.AreEqual(expectedRemarks.Count, result.Count());
        }

        [Test]
        public async Task GetAllAbsencesAsync_ReturnsAbsencesList_WhenStudentHasAbsences()
        {
            // Arrange
            var studentId = 123;
            var expectedAbsences = new List<StudentAbsencesViewModel>
            {
                new StudentAbsencesViewModel { Date = "2024-12-01", CourseName = "Biology" },
                new StudentAbsencesViewModel { Date = "2024-12-05", CourseName = "Math" }
            };
            _studentServiceMock.Setup(service => service.GetAllAbsencesAsync(studentId)).ReturnsAsync(expectedAbsences);

            // Act
            var result = await _studentServiceMock.Object.GetAllAbsencesAsync(studentId);

            // Assert
            Assert.AreEqual(expectedAbsences.Count, result.Count());
        }

        [Test]
        public async Task GetScheduleAsync_ReturnsSchedule_WhenStudentHasSchedule()
        {
            // Arrange
            var studentId = 123;
            var expectedSchedule = new List<StudentScheduleViewModel>
            {
                new StudentScheduleViewModel { Day = "Monday", StartTime = "8:00 AM", CourseName = "Math" },
                new StudentScheduleViewModel { Day = "Tuesday", StartTime = "10:00 AM", CourseName = "English" }
            };
            _studentServiceMock.Setup(service => service.GetScheduleAsync(studentId)).ReturnsAsync(expectedSchedule);

            // Act
            var result = await _studentServiceMock.Object.GetScheduleAsync(studentId);

            // Assert
            Assert.AreEqual(expectedSchedule.Count, result.Count());
        }

        [Test]
        public async Task GetHomePageAsync_ReturnsHomePage_WhenStudentExists()
        {
            // Arrange
            var studentId = 123;
            var expectedHomePage = new StudentHomePageViewModel 
            {
                SchoolName = "School of Science",
                AbsencesCount = "2",
                GradesCount = "3",
                AverageGrade = "4.20",
                ClassName = "12 A",
                ClassTeacher = "Mr. Smith",
                NewsCount = "5",
                Remarks = "3",
                Name = "John Doe"
            };
            _studentServiceMock.Setup(service => service.GetHomePageAsync(studentId)).ReturnsAsync(expectedHomePage);

            // Act
            var result = await _studentServiceMock.Object.GetHomePageAsync(studentId);

            // Assert
            Assert.AreEqual(expectedHomePage.Name, result.Name);
            Assert.AreEqual(expectedHomePage.ClassName, result.ClassName);
            Assert.AreEqual(expectedHomePage.SchoolName, result.SchoolName);
            Assert.AreEqual(expectedHomePage.ClassTeacher, result.ClassTeacher);
            Assert.AreEqual(expectedHomePage.AverageGrade, result.AverageGrade);
            Assert.AreEqual(expectedHomePage.GradesCount, result.GradesCount);
            Assert.AreEqual(expectedHomePage.Remarks, result.Remarks);
            Assert.AreEqual(expectedHomePage.NewsCount, result.NewsCount);
            Assert.AreEqual(expectedHomePage.AbsencesCount, result.AbsencesCount);
        }

        [Test]
        public async Task GetStudentDetailsAsync_ReturnsStudentDetails_WhenStudentExists()
        {
            // Arrange
            var studentId = 123;
            var expectedStudentDetails = new StudentProfileViewModel 
            { 
                FirstName = "John",
                MiddleName = "Doe",
                LastName = "Smith",
                ClassName = "12 A",
                SchoolName ="School of Mathematics",
                ClassTeacher ="Ms. Petkova",
                ContactDetails = "Gsm:",
                Email = "john@gmail.com",
                BirthDate = "2004-12-01",
                PersonalIdentificationNumber = "1234567890",
                ProfilePicturePath = "path/to/picture",
            };
            _studentServiceMock.Setup(service => service.GetStudentDetailsAsync(studentId)).ReturnsAsync(expectedStudentDetails);

            // Act
            var result = await _studentServiceMock.Object.GetStudentDetailsAsync(studentId);

            // Assert
            Assert.AreEqual(expectedStudentDetails.FirstName, result.FirstName);
            Assert.AreEqual(expectedStudentDetails.MiddleName, result.MiddleName);
            Assert.AreEqual(expectedStudentDetails.LastName, result.LastName);
            Assert.AreEqual(expectedStudentDetails.PersonalIdentificationNumber, result.PersonalIdentificationNumber);
            Assert.AreEqual(expectedStudentDetails.SchoolName, result.SchoolName);
            Assert.AreEqual(expectedStudentDetails.ClassName, result.ClassName);
            Assert.AreEqual(expectedStudentDetails.Email, result.Email);
            Assert.AreEqual(expectedStudentDetails.ContactDetails, result.ContactDetails);
            Assert.AreEqual(expectedStudentDetails.BirthDate, result.BirthDate);
            Assert.AreEqual(expectedStudentDetails.ProfilePicturePath, result.ProfilePicturePath);
            Assert.AreEqual(expectedStudentDetails.ClassTeacher, result.ClassTeacher);
        }
    }
}