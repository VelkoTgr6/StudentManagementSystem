using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MockQueryable;
using MockQueryable.Moq;
using Moq;
using StudentManagementSystem.Core.Models.Admin.Student;
using StudentManagementSystem.Core.Services.Admin;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests.Admin
{
    [TestFixture]
    public class AdminStudentServiceTests
    {
        private Mock<IRepository> repositoryMock;
        private AdminStudentService adminStudentService;

        [SetUp]
        public void SetUp()
        {
            repositoryMock = new Mock<IRepository>();
            adminStudentService = new AdminStudentService(repositoryMock.Object);
        }

        [Test]
        public async Task AllAsync_ShouldReturnCorrectData()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe", IsDeleted = false, Class = new Class { Name = "12 A" }, Performance = 90, School = new School { Name = "Test School" } },
                new Student { Id = 2, FirstName = "Jane", LastName = "Smith", IsDeleted = false, Class = new Class { Name = "11 B" }, Performance = 85, School = new School { Name = "Test School" } }
            }.AsQueryable().BuildMock();

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);

            // Act
            var result = await adminStudentService.AllAsync();

            // Assert
            Assert.That(result.TotalStudentsCount, Is.EqualTo(2));
            Assert.That(result.Students.First().FirstName, Is.EqualTo("Jane"));
        }


        [Test]
        public async Task CreateStudentAsync_ShouldCreateStudent_WhenValidDataIsProvided()
        {
            // Arrange: Create an instance of the model to be used
            var model = new StudentFormViewModel
            {
                FirstName = "Michael",
                LastName = "Jordan",
                Email = "michael.jordan@example.com",
                ContactDetails = "123-456-789",
                PersonalId = "123456789",
                DateOfBirth = new DateTime(2000, 1, 1),
                ClassId = 1
            };
            var mockFile = new Mock<IFormFile>();

            // Mock repository methods
            repositoryMock.Setup(r => r.GetIdByEmailAsync(It.IsAny<string>())).ReturnsAsync("1");

            // Mock the AddAsync method to set the ID of the student
            repositoryMock.Setup(r => r.AddAsync(It.IsAny<Student>())).Callback<Student>(s => s.Id = 1).Returns(Task.CompletedTask);

            // Mock the SaveChangesAsync method
            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act: Call the method being tested
            var result = await adminStudentService.CreateStudentAsync(model, mockFile.Object);

            // Assert: Verify the expected outcome
            Assert.That(result, Is.GreaterThan(0)); // Check that the result is a positive student ID
            repositoryMock.Verify(r => r.AddAsync(It.IsAny<Student>()), Times.Once);
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }


        [Test]
        public async Task DeleteStudentAsync_ShouldDeleteStudent_WhenStudentExists()
        {
            // Arrange
            var student = new Student { Id = 1, IsDeleted = false, UserId = "test-user" };
            repositoryMock.Setup(r => r.GetByIdAsync<Student>(It.IsAny<int>())).ReturnsAsync(student);
            repositoryMock.Setup(r => r.GetIdentityUserByIdAsync(It.IsAny<string>())).ReturnsAsync(new IdentityUser());

            // Act
            await adminStudentService.DeleteStudentAsync(1);

            // Assert
            Assert.That(student.IsDeleted, Is.True);
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditStudentAsync_ShouldEditStudent_WhenValidDataIsProvided()
        {
            // Arrange
            var student = new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                IsDeleted = false
            };
            var model = new StudentFormViewModel
            {
                FirstName = "Johnny",
                LastName = "Doey",
                Email = "johnny.doey@example.com"
            };
            repositoryMock.Setup(r => r.GetByIdAsync<Student>(It.IsAny<int>())).ReturnsAsync(student);

            // Act
            await adminStudentService.EditStudentAsync(1, model, null);

            // Assert
            Assert.That(student.FirstName, Is.EqualTo("Johnny"));
            Assert.That(student.LastName, Is.EqualTo("Doey"));
            Assert.That(student.Email, Is.EqualTo("johnny.doey@example.com"));
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetStudentByIdAsync_ShouldReturnStudent_WhenStudentExists()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var studentId = 1;
            var student = new Student
            {
                Id = studentId,
                FirstName = "John",
                MiddleName = "A.",
                LastName = "Doe",
                School = new School { Name = "Test School" },
                ContactDetails = "123456789",
                Email = "john.doe@example.com",
                PersonalId = "1234567890",
                DateOfBirth = new DateTime(2000, 1, 1),
                Class = new Class { Name = "10A" },
                Performance = 85.5,
                IsDeleted = false
            };

            var students = new List<Student> { student }.AsQueryable().BuildMockDbSet();

            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students.Object);

            var service = new AdminStudentService(mockRepository.Object);

            // Act
            var result = await service.GetStudentByIdAsync(studentId);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(studentId));
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.MiddleName, Is.EqualTo("A."));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.SchoolName, Is.EqualTo("Test School"));
            Assert.That(result.ContactDetails, Is.EqualTo("123456789"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.PersonalId, Is.EqualTo("1234567890"));
            Assert.That(result.DateOfBirth, Is.EqualTo(new DateTime(2000, 1, 1)));
            Assert.That(result.Class, Is.EqualTo("10A"));
            Assert.That(result.Performance, Is.EqualTo("85,50"));
        }

        [Test]
        public async Task GetStudentByIdAsync_ShouldThrowException_WhenStudentDoesNotExist()
        {
            // Arrange
            repositoryMock.Setup(r => r.AllAsReadOnly<Student>()).Returns(Enumerable.Empty<Student>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await adminStudentService.GetStudentByIdAsync(1));
            Assert.That(ex.Message, Is.EqualTo("Student not found."));
        }

        [Test]
        public async Task ExistAsync_ShouldReturnTrue_WhenStudentExistsAndIsNotDeleted()
        {
            // Arrange
            var studentId = 1;
            var student = new Student { Id = studentId, IsDeleted = false };

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student> { student }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.ExistAsync(studentId);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistAsync_ShouldReturnFalse_WhenStudentDoesNotExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student>().AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.ExistAsync(studentId);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task ExistAsync_ShouldReturnFalse_WhenStudentIsDeleted()
        {
            // Arrange
            var studentId = 1;
            var student = new Student { Id = studentId, IsDeleted = true };

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student> { student }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.ExistAsync(studentId);

            // Assert
            Assert.That(result, Is.False);
        }
        [Test]
        public async Task GetAllStudentsAsync_ShouldReturnAllStudents_WhenCalled()
        {
            // Arrange
            var students = new List<StudentServiceModel>
            {
                new StudentServiceModel { Id = 1, FirstName = "John", LastName = "Doe" },
                new StudentServiceModel { Id = 2, FirstName = "Jane", LastName = "Doe" }
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<StudentServiceModel>())
                .Returns(students.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetAllStudentsAsync();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(students.Count));
            Assert.That(result.First().FirstName, Is.EqualTo("John"));
            Assert.That(result.Last().FirstName, Is.EqualTo("Jane"));
        }

        [Test]
        public async Task GetAllStudentsNamesAsync_ShouldReturnAllStudentNames_WhenCalled()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe" },
                new Student { Id = 2, FirstName = "Jane", LastName = "Doe" }
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(students.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetAllStudentsNamesAsync();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(students.Count));
            Assert.That(result.First(), Is.EqualTo("John Doe"));
            Assert.That(result.Last(), Is.EqualTo("Jane Doe"));
        }
        [Test]
        public async Task GetStudentDetailsModelByIdAsync_ShouldReturnStudentDetails_WhenStudentExists()
        {
            // Arrange
            var studentId = 1;
            var student = new Student
            {
                Id = studentId,
                FirstName = "John",
                LastName = "Doe",
                IsDeleted = false,
                School = new School { Name = "Test School" },
                Class = new Class { Name = "A1" },
                Email = "john.doe@example.com",
                DateOfBirth = new DateTime(2000, 1, 1),
                ContactDetails = "123-456-789",
                Performance = 85.5,
                Grades = new List<Grade> { new Grade { GradeScore = 90.5 }, new Grade { GradeScore = 80.5 } },
                ProfilePicturePath = "/path/to/picture",
                PersonalId = "123456789"
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student> { student }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentDetailsModelByIdAsync(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(studentId));
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.SchoolName, Is.EqualTo("Test School"));
            Assert.That(result.Performance, Is.EqualTo("85,50"));
            Assert.That(result.ProfilePicturePath, Is.EqualTo("/path/to/picture"));
        }

        [Test]
        public async Task GetStudentDetailsModelByIdAsync_ShouldThrowArgumentException_WhenStudentDoesNotExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.GetStudentDetailsModelByIdAsync(studentId));
            Assert.That(ex.Message, Is.EqualTo("Student not found."));
        }

        [Test]
        public async Task GetStudentFormModelByIdAsync_ShouldReturnStudentForm_WhenStudentExists()
        {
            // Arrange
            var studentId = 1;
            var student = new Student
            {
                Id = studentId,
                FirstName = "John",
                LastName = "Doe",
                IsDeleted = false,
                Email = "john.doe@example.com",
                ContactDetails = "123-456-789",
                PersonalId = "123456789",
                DateOfBirth = new DateTime(2000, 1, 1),
                ClassId = 1,
                ProfilePicturePath = "/path/to/picture"
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student> { student }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentFormModelByIdAsync(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.FirstName, Is.EqualTo("John"));
            Assert.That(result.LastName, Is.EqualTo("Doe"));
            Assert.That(result.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(result.ClassId, Is.EqualTo(1));
        }

        [Test]
        public async  Task GetStudentFormModelByIdAsync_ShouldThrowArgumentException_WhenStudentDoesNotExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Student>())
                .Returns(new List<Student>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.GetStudentFormModelByIdAsync(studentId));
            Assert.That(ex.Message, Is.EqualTo("Student not found."));
        }
        [Test]
        public async Task GetStudentGradesAsync_ShouldReturnStudentGrades()
        {
            // Arrange
            var studentId = 1;
            var grades = new List<Grade>
            {
                new Grade
                {
                    Id = 1,
                    StudentId = studentId,
                    GradeScore = 90,
                    GradeAssignedDate = new DateTime(2023, 1, 1),
                    GradeType = "Midterm",
                    Course = new Course { Name = "Math" },
                    Student = new Student { Class = new Class { Name = "A1" } },
                    IsDeleted = false
                },
                new Grade
                {
                    Id = 2,
                    StudentId = studentId,
                    GradeScore = 85,
                    GradeAssignedDate = new DateTime(2023, 2, 1),
                    GradeType = "Final",
                    Course = new Course { Name = "Science" },
                    Student = new Student { Class = new Class { Name = "B1" } },
                    IsDeleted = false
                }
            }.AsQueryable().BuildMock();

            repositoryMock.Setup(r => r.AllAsReadOnly<Grade>()).Returns(grades);

            // Act
            var result = await adminStudentService.GetStudentGradesAsync(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().Name, Is.EqualTo("Science"));
            Assert.That(result.Last().Name, Is.EqualTo("Math"));
        }

        [Test]
        public async Task GetStudentGradesAsync_ShouldReturnEmpty_WhenNoGradesExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Grade>())
                .Returns(new List<Grade>().AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentGradesAsync(studentId);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task EditGradeAsync_ShouldUpdateGrade_WhenGradeExists()
        {
            // Arrange
            var gradeId = 1;
            var model = new StudentGradeFormViewModel
            {
                GradeScore = 95.0,
                GradeType = "Final",
                CourseId = 1
            };

            var grade = new Grade
            {
                Id = gradeId,
                GradeScore = 90.0,
                GradeType = "Midterm",
                CourseId = 1,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.All<Grade>())
                .Returns(new List<Grade> { grade }.AsQueryable().BuildMock());

            repositoryMock.Setup(r => r.UpdateStudentsPerformanceAllAsync()).Returns(Task.CompletedTask);
            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await adminStudentService.EditGradeAsync(gradeId, model);

            // Assert
            Assert.That(grade.GradeScore, Is.EqualTo(95.0));
            Assert.That(grade.GradeType, Is.EqualTo("Final"));
            Assert.That(grade.CourseId, Is.EqualTo(1));
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditGradeAsync_ShouldThrowArgumentException_WhenGradeDoesNotExist()
        {
            // Arrange
            var gradeId = 1;
            var model = new StudentGradeFormViewModel
            {
                GradeScore = 95.0,
                GradeType = "Final",
                CourseId = 1
            };

            repositoryMock.Setup(r => r.All<Grade>())
                .Returns(new List<Grade>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.EditGradeAsync(gradeId, model));
            Assert.That(ex.Message, Is.EqualTo("Grade not found."));
        }

        [Test]
        public async Task GetGradeFormModelByIdAsync_ShouldReturnGradeForm_WhenGradeExists()
        {
            // Arrange
            var gradeId = 1;
            var grade = new Grade
            {
                Id = gradeId,
                GradeScore = 90.0,
                GradeType = "Midterm",
                CourseId = 1,
                StudentId = 1,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Grade>())
                .Returns(new List<Grade> { grade }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetGradeFormModelByIdAsync(gradeId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.GradeId, Is.EqualTo(gradeId));
            Assert.That(result.GradeScore, Is.EqualTo(90.0));
            Assert.That(result.GradeType, Is.EqualTo("Midterm"));
            Assert.That(result.CourseId, Is.EqualTo(1));
        }

        [Test]
        public async Task GetGradeFormModelByIdAsync_ShouldThrowArgumentException_WhenGradeDoesNotExist()
        {
            // Arrange
            var gradeId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Grade>())
                .Returns(new List<Grade>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.GetGradeFormModelByIdAsync(gradeId));
            Assert.That(ex.Message, Is.EqualTo("Grade not found."));
        }

        [Test]
        public async Task DeleteGradeAsync_ShouldMarkGradeAsDeleted_WhenGradeExists()
        {
            // Arrange
            var gradeId = 1;
            var grade = new Grade
            {
                Id = gradeId,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.All<Grade>())
                .Returns(new List<Grade> { grade }.AsQueryable().BuildMock());

            repositoryMock.Setup(r => r.UpdateStudentsPerformanceAllAsync()).Returns(Task.CompletedTask);
            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await adminStudentService.DeleteGradeAsync(gradeId);

            // Assert
            Assert.That(grade.IsDeleted, Is.True);
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteGradeAsync_ShouldThrowArgumentException_WhenGradeDoesNotExist()
        {
            // Arrange
            var gradeId = 1;

            repositoryMock.Setup(r => r.All<Grade>())
                .Returns(new List<Grade>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.DeleteGradeAsync(gradeId));
            Assert.That(ex.Message, Is.EqualTo("Grade not found."));
        }

        [Test]
        public async Task GetStudentRemarksAsync_ShouldReturnRemarks_WhenRemarksExist()
        {
            // Arrange
            var studentId = 1;
            var remarks = new List<Remark>
            {
                new Remark { Id = 1, StudentId = studentId, CourseId = 1, RemarkText = "Great performance", IsDeleted = false, Course = new Course { Name = "Math" } },
                new Remark { Id = 2, StudentId = studentId, CourseId = 2, RemarkText = "Needs improvement", IsDeleted = false, Course = new Course { Name = "Science" } }
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Remark>())
                .Returns(remarks.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentRemarksAsync(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().CourseName, Is.EqualTo("Math"));
            Assert.That(result.Last().CourseName, Is.EqualTo("Science"));
        }

        [Test]
        public async Task GetStudentRemarksAsync_ShouldReturnEmpty_WhenNoRemarksExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Remark>())
                .Returns(new List<Remark>().AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentRemarksAsync(studentId);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task EditRemarkAsync_ShouldUpdateRemark_WhenRemarkExists()
        {
            // Arrange
            var remarkId = 1;
            var model = new StudentRemarkFormViewModel
            {
                RemarkText = "Excellent performance",
                CourseId = 2
            };

            var remark = new Remark
            {
                Id = remarkId,
                RemarkText = "Needs improvement",
                CourseId = 1,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.All<Remark>())
                .Returns(new List<Remark> { remark }.AsQueryable().BuildMock());

            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await adminStudentService.EditRemarkAsync(remarkId, model);

            // Assert
            Assert.That(remark.RemarkText, Is.EqualTo("Excellent performance"));
            Assert.That(remark.CourseId, Is.EqualTo(2));
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditRemarkAsync_ShouldThrowArgumentException_WhenRemarkDoesNotExist()
        {
            // Arrange
            var remarkId = 1;
            var model = new StudentRemarkFormViewModel
            {
                RemarkText = "Excellent performance",
                CourseId = 2
            };

            repositoryMock.Setup(r => r.All<Remark>())
                .Returns(new List<Remark>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.EditRemarkAsync(remarkId, model));
            Assert.That(ex.Message, Is.EqualTo("Remark not found."));
        }
        [Test]
        public async Task GetRemarkFormModelByIdAsync_ShouldReturnRemarkForm_WhenRemarkExists()
        {
            // Arrange
            var remarkId = 1;
            var remark = new Remark
            {
                Id = remarkId,
                StudentId = 1,
                CourseId = 1,
                RemarkText = "Good job",
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Remark>())
                .Returns(new List<Remark> { remark }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetRemarkFormModelByIdAsync(remarkId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.RemarkText, Is.EqualTo("Good job"));
            Assert.That(result.CourseId, Is.EqualTo(1));
        }

        [Test]
        public async Task GetRemarkFormModelByIdAsync_ShouldThrowArgumentException_WhenRemarkDoesNotExist()
        {
            // Arrange
            var remarkId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Remark>())
                .Returns(new List<Remark>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.GetRemarkFormModelByIdAsync(remarkId));
            Assert.That(ex.Message, Is.EqualTo("Remark not found."));
        }

        [Test]
        public async Task GetStudentAbsencesAsync_ShouldReturnAbsences_WhenAbsencesExist()
        {
            // Arrange
            var studentId = 1;
            var absences = new List<Absence>
            {
                new Absence { Id = 1, StudentId = studentId, CourseId = 1, Date = new DateTime(2024, 12, 1), IsDeleted = false, Course = new Course { Name = "Math" } },
                new Absence { Id = 2, StudentId = studentId, CourseId = 2, Date = new DateTime(2024, 12, 2), IsDeleted = false, Course = new Course { Name = "Science" } }
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Absence>())
                .Returns(absences.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentAbsencesAsync(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().CourseName, Is.EqualTo("Math"));
            Assert.That(result.Last().CourseName, Is.EqualTo("Science"));
        }

        [Test]
        public async Task GetStudentAbsencesAsync_ShouldReturnEmpty_WhenNoAbsencesExist()
        {
            // Arrange
            var studentId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Absence>())
                .Returns(new List<Absence>().AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetStudentAbsencesAsync(studentId);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetAbsenceFormModelByIdAsync_ShouldReturnAbsenceForm_WhenAbsenceExists()
        {
            // Arrange
            var absenceId = 1;
            var absence = new Absence
            {
                Id = absenceId,
                StudentId = 1,
                CourseId = 1,
                Date = new DateTime(2024, 12, 1),
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.AllAsReadOnly<Absence>())
                .Returns(new List<Absence> { absence }.AsQueryable().BuildMock());

            // Act
            var result = await adminStudentService.GetAbsenceFormModelByIdAsync(absenceId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.AbsenceDate, Is.EqualTo(new DateTime(2024, 12, 1)));
            Assert.That(result.CourseId, Is.EqualTo(1));
        }

        [Test]
        public async Task GetAbsenceFormModelByIdAsync_ShouldThrowArgumentException_WhenAbsenceDoesNotExist()
        {
            // Arrange
            var absenceId = 1;

            repositoryMock.Setup(r => r.AllAsReadOnly<Absence>())
                .Returns(new List<Absence>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.GetAbsenceFormModelByIdAsync(absenceId));
            Assert.That(ex.Message, Is.EqualTo("Absence not found."));
        }

        [Test]
        public async Task EditAbsenceAsync_ShouldUpdateAbsence_WhenAbsenceExists()
        {
            // Arrange
            var absenceId = 1;
            var model = new StudentAbsenceFormViewModel
            {
                AbsenceDate = new DateTime(2024, 12, 2),
                CourseId = 2
            };

            var absence = new Absence
            {
                Id = absenceId,
                Date = new DateTime(2024, 12, 1),
                CourseId = 1,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.All<Absence>())
                .Returns(new List<Absence> { absence }.AsQueryable().BuildMock());

            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await adminStudentService.EditAbsenceAsync(absenceId, model);

            // Assert
            Assert.That(absence.Date, Is.EqualTo(new DateTime(2024, 12, 2)));
            Assert.That(absence.CourseId, Is.EqualTo(2));
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditAbsenceAsync_ShouldThrowArgumentException_WhenAbsenceDoesNotExist()
        {
            // Arrange
            var absenceId = 1;
            var model = new StudentAbsenceFormViewModel
            {
                AbsenceDate = new DateTime(2024, 12, 2),
                CourseId = 2
            };

            repositoryMock.Setup(r => r.All<Absence>())
                .Returns(new List<Absence>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.EditAbsenceAsync(absenceId, model));
            Assert.That(ex.Message, Is.EqualTo("Absence not found."));
        }

        [Test]
        public async Task DeleteAbsenceAsync_ShouldMarkAbsenceAsDeleted_WhenAbsenceExists()
        {
            // Arrange
            var absenceId = 1;
            var absence = new Absence
            {
                Id = absenceId,
                IsDeleted = false
            };

            repositoryMock.Setup(r => r.All<Absence>())
                .Returns(new List<Absence> { absence }.AsQueryable().BuildMock());

            repositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await adminStudentService.DeleteAbsenceAsync(absenceId);

            // Assert
            Assert.That(absence.IsDeleted, Is.True);
            repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteAbsenceAsync_ShouldThrowArgumentException_WhenAbsenceDoesNotExist()
        {
            // Arrange
            var absenceId = 1;

            repositoryMock.Setup(r => r.All<Absence>())
                .Returns(new List<Absence>().AsQueryable().BuildMock());

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(() => adminStudentService.DeleteAbsenceAsync(absenceId));
            Assert.That(ex.Message, Is.EqualTo("Absence not found."));
        }


    }
}
