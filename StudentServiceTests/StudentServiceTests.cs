using MockQueryable;
using MockQueryable.Moq;
using Moq;
using StudentManagementSystem.Core.Services;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests
{
    [TestFixture]
    public class StudentServiceTests
    {
        private StudentService studentService;
        private Mock<IRepository> mockRepository;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            studentService = new StudentService(mockRepository.Object);
        }

        [Test]
        public async Task ExistByIdAsync_ShouldReturnTrue_WhenStudentExists()
        {
            
            var students = new List<Student>
        {
            new Student { UserId = "user1" }
        }.AsQueryable();

            var mockStudents = students.BuildMock(); // Converts to an async-compatible IQueryable

            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudents);

            
            var result = await studentService.ExistByIdAsync("user1");

            
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistByIdAsync_ShouldReturnFalse_WhenStudentDoesNotExist()
        {
            
            var students = new List<Student>
        {
            new Student { UserId = "user1" }
        }.AsQueryable();

            var mockStudents = students.BuildMock(); // Converts to an async-compatible IQueryable
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudents);

            
            var result = await studentService.ExistByIdAsync("nonexistentUser");

            
            Assert.IsFalse(result);
        }
        [Test]
        public async Task GetAllAbsencesAsync_ShouldReturnAbsences_WhenStudentHasAbsences()
        {
            
            var studentId = 1;
            var absences = new List<Absence>
            {
                new Absence { StudentId = studentId, Date = DateTime.Now, Course = new Course { Name = "Math" }, IsDeleted = false },
                new Absence { StudentId = studentId, Date = DateTime.Now.AddDays(-1), Course = new Course { Name = "History" }, IsDeleted = true }
            };

            var mockAbsences = absences.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Absence>()).Returns(mockAbsences);

            
            var result = await studentService.GetAllAbsencesAsync(studentId);

            
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().CourseName, Is.EqualTo("Math"));
            Assert.That(result.First().ExcusedAbsences, Is.EqualTo(1));
        }



        [Test]
        public async Task GetAllRemarksAsync_ShouldReturnRemarks_WhenStudentHasRemarks()
        {
            
            var studentId = 1;
            var remarks = new List<Remark>
            {
                new Remark { StudentId = studentId, RemarkText = "Excellent", Date = DateTime.Now, Course = new Course { Name = "Math" }, Teacher = new Teacher {Titles = "prof.",  FirstName = "Mr.", LastName = "Smith" } },
                new Remark { StudentId = studentId, RemarkText = "Needs Improvement", Date = DateTime.Now.AddDays(-1), Course = new Course { Name = "History" }, Teacher = new Teacher {Titles="dr", FirstName = "Ms.", LastName = "Johnson" } }
            };

            var mockRemarks = remarks.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Remark>()).Returns(mockRemarks);

            
            var result = await studentService.GetAllRemarksAsync(studentId);

            
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().CourseName, Is.EqualTo("Math"));
            Assert.That(result.First().TeacherName, Is.EqualTo("prof. Mr. Smith"));
            Assert.That(result.Last().CourseName, Is.EqualTo("History"));
            Assert.That(result.Last().TeacherName, Is.EqualTo("dr Ms. Johnson"));
        }

        [Test]
        public async Task GetHomePageAsync_ShouldReturnHomePage_WhenStudentExists()
        {
            
            var studentId = 1;
            var student = new Student
            {
                Id = studentId,
                FirstName = "John",
                LastName = "Doe",
                School = new School { Name = "Sample School" },
                Class = new Class { Name = "10A", Teacher = new Teacher { Titles = "prof.", FirstName = "Mr.", LastName = "Smith" } },
                Grades = new List<Grade> { new Grade { GradeScore = 90 } },
                Аbsences = new List<Absence> { new Absence() },
                Remarks = new List<Remark> { new Remark() }
            };

            var mockStudent = new List<Student> { student }.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudent);

            
            var result = await studentService.GetHomePageAsync(studentId);

            
            Assert.That(result.AbsencesCount, Is.EqualTo("1"));
            Assert.That(result.AverageGrade, Is.EqualTo("90,00"));
            Assert.That(result.Remarks, Is.EqualTo("1"));
            Assert.That(result.ClassName, Is.EqualTo("10A"));
            Assert.That(result.SchoolName, Is.EqualTo("Sample School"));
            Assert.That(result.ClassTeacher, Is.EqualTo("prof. Mr. Smith"));
            Assert.That(result.Name, Is.EqualTo("John Doe"));
        }

        [Test]
        public async Task GetScheduleAsync_ShouldReturnSchedule_WhenStudentHasSchedule()
        {
            
            var studentId = 1;
            var classId = 1;
            var schedule = new List<CourseSchedule>
            {
                new CourseSchedule { ClassId = classId, Course = new Course { Name = "Math", Teacher = new Teacher {Titles="prof.", FirstName = "Mr.", LastName = "Smith" } }, StartTime =new TimeSpan(8,0,0), EndTime = new TimeSpan(9,0,0), Day = DayOfWeek.Monday },
                new CourseSchedule { ClassId = classId, Course = new Course { Name = "History", Teacher = new Teacher {Titles="dr.", FirstName = "Ms.", LastName = "Johnson" } },StartTime =new TimeSpan(8,0,0), EndTime = new TimeSpan(9,0,0), Day = DayOfWeek.Tuesday }
            };

            var mockSchedule = schedule.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<CourseSchedule>()).Returns(mockSchedule);
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(new List<Student> { new Student { Id = studentId, ClassId = classId } }.AsQueryable().BuildMock());

            
            var result = await studentService.GetScheduleAsync(studentId);

            
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().CourseName, Is.EqualTo("Math"));
            Assert.That(result.First().TeacherName, Is.EqualTo("prof. Mr. Smith"));
            Assert.That(result.Last().CourseName, Is.EqualTo("History"));
            Assert.That(result.Last().TeacherName, Is.EqualTo("dr. Ms. Johnson"));
        }

        [Test]
        public async Task GetStudentDetailsAsync_ShouldReturnDetails_WhenStudentExists()
        {
            
            var studentId = 1;
            var student = new Student
            {
                Id = studentId,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now,
                PersonalId = "123456789",
                School = new School { Name = "Sample School" },
                Class = new Class { Name = "10A", Teacher = new Teacher { FirstName = "Mr.", LastName = "Smith" } },
                Email = "john.doe@example.com",
                ContactDetails = "123-456-7890",
                ProfilePicturePath = "/images/johndoe.jpg"
            };

            var mockStudent = new List<Student> { student }.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudent);

            
            var result = await studentService.GetStudentDetailsAsync(studentId);

            
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.BirthDate, Is.EqualTo(DateTime.Now.ToString("dd/MM/yyyy")));
            Assert.That(result.PersonalIdentificationNumber, Is.EqualTo("123456789"));
            Assert.That(result.SchoolName, Is.EqualTo("Sample School"));
            Assert.That(result.ClassName, Is.EqualTo("10A"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.ContactDetails, Is.EqualTo("123-456-7890"));
            Assert.That(result.ProfilePicturePath, Is.EqualTo("/images/johndoe.jpg"));

        }

        [Test]
        public async Task GetStudentIdAsync_ShouldReturnStudentId_WhenUserIdExists()
        {
            
            var userId = "user123";
            var student = new Student
            {
                Id = 1,
                UserId = userId
            };

            var mockStudents = new List<Student> { student }.AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudents);

            
            var result = await studentService.GetStudentIdAsync(userId);

            
            Assert.AreEqual(1, result);
        }

        [Test]
        public async Task GetStudentIdAsync_ShouldReturnZero_WhenUserIdDoesNotExist()
        {
            
            var userId = "user123";
            var mockStudents = new List<Student>().AsQueryable().BuildMock();
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(mockStudents);

            
            var result = await studentService.GetStudentIdAsync(userId);

            
            Assert.AreEqual(0, result);
        }
    }
}
