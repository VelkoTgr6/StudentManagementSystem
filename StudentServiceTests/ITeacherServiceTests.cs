using Moq;
using StudentManagementSystem.Core.Contracts;
using StudentManagementSystem.Core.Models.Teacher;

namespace Tests
{
    [TestFixture]
    public class ITeacherServiceTests
    {
        private Mock<ITeacherService> _teacherServiceMock;

        [SetUp]
        public void SetUp()
        {
            // Create a mock instance of ITeacherService
            _teacherServiceMock = new Mock<ITeacherService>();
        }

        // Example Test 1: Testing GetStudentsByTeacherAndClassAsync method
        [Test]
        public async Task GetStudentsByTeacherAndClassAsync_ShouldReturnStudents_WhenClassAndTeacherExist()
        {
            // Arrange
            var classId = 101;
            var teacherId = "teacher1";
            var expectedStudents = new List<StudentsViewModel>
            {
                new StudentsViewModel { Id = 1, Name = "John Doe",ClassName = "12 A" },
                new StudentsViewModel { Id = 2, Name = "Jane Smith",ClassName = "12 B" }
            };
            _teacherServiceMock.Setup(service => service.GetStudentsByTeacherAndClassAsync(classId, teacherId))
                               .ReturnsAsync(expectedStudents);

            // Act
            var result = await _teacherServiceMock.Object.GetStudentsByTeacherAndClassAsync(classId, teacherId);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedStudents.Count));
            Assert.That(result.ElementAt(0).ClassName, Is.EqualTo(expectedStudents.ElementAt(0).ClassName));
        }

        // Example Test 2: Testing AddGradeToStudent method
        [Test]
        public async Task AddGradeToStudent_ShouldReturnGradeId_WhenGradeIsAdded()
        {
            // Arrange
            var model = new GradeFormModel
            {
                GradeScore = 4.50,
                GradeId = 123,
                GradeType = "Test",
                CustomGradeType = "Test",
                SelectedGrade = "4.50",
                SelectedGradeType = "Test",
                Courses = new List<TeacherCourseServiceModel>(),
                SelectedCourseId = 10,
                StudentId = 1,
                CourseId = 10
            };
            var studentId = 1;
            var expectedGradeId = 123;
            _teacherServiceMock.Setup(service => service.AddGradeToStudent(model, studentId))
                               .ReturnsAsync(expectedGradeId);

            // Act
            var result = await _teacherServiceMock.Object.AddGradeToStudent(model, studentId);

            // Assert
            Assert.AreEqual(expectedGradeId, result);
        }

        // Example Test 3: Testing GetTeacherCourses method
        [Test]
        public async Task GetTeacherCourses_ShouldReturnCourseList_WhenTeacherHasCourses()
        {
            // Arrange
            var teacherId = "teacher1";
            var expectedCourses = new List<TeacherCourseServiceModel>
            {
                new TeacherCourseServiceModel { Id = 101, Name = "Math" },
                new TeacherCourseServiceModel { Id = 102, Name = "Science" }
            };
            _teacherServiceMock.Setup(service => service.GetTeacherCourses(teacherId))
                               .ReturnsAsync(expectedCourses);

            // Act
            var result = await _teacherServiceMock.Object.GetTeacherCourses(teacherId);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCourses.Count));
            Assert.That(result.ElementAt(0).Name, Is.EqualTo(expectedCourses.ElementAt(0).Name));
        }

        // Example Test 4: Testing GetStudentDetailsAsync method
        [Test]
        public async Task GetStudentDetailsAsync_ShouldReturnStudentDetails_WhenStudentExists()
        {
            // Arrange
            var studentId = 1;
            var teacherId = "teacher1";
            var expectedDetails = new TeacherStudentDetailsViewModel
            {
                StudentId = studentId,
                StudentName = "John Doe",
                ClassName = "12 A",
                Grades = new List<GradeServiceViewModel>(),
                Absences = new List<AbsenceServiceViewModel>(),
                Remarks = new List<RemarkServiceViewModel>(),
                ClassId = 101,
                CustomGradeType = "Test"
            };
            _teacherServiceMock.Setup(service => service.GetStudentDetailsAsync(studentId, teacherId))
                               .ReturnsAsync(expectedDetails);

            // Act
            var result = await _teacherServiceMock.Object.GetStudentDetailsAsync(studentId, teacherId);

            // Assert
            Assert.That(result.StudentId, Is.EqualTo(expectedDetails.StudentId));
            Assert.That(result.ClassId, Is.EqualTo(expectedDetails.ClassId));
            Assert.That(result.ClassName, Is.EqualTo(expectedDetails.ClassName));
            Assert.That(result.Grades, Is.EqualTo(expectedDetails.Grades));
            Assert.That(result.StudentName, Is.EqualTo(expectedDetails.StudentName));
            Assert.That(result.Absences, Is.EqualTo(expectedDetails.Absences));
            Assert.That(result.Remarks, Is.EqualTo(expectedDetails.Remarks));
            Assert.That(result.CustomGradeType, Is.EqualTo(expectedDetails.CustomGradeType));
        }

        // Example Test 5: Testing AddAbsenceToStudentAsync method
        [Test]
        public async Task AddAbsenceToStudentAsync_ShouldReturnAbsenceId_WhenAbsenceIsAdded()
        {
            // Arrange
            var model = new AbsenceFormViewModel
            {
                AbsenceDate = DateTime.Now,
                CourseName = "Math",
                CourseId = 10,
                StudentName = "John Doe",
                Id = 456,
                Courses = new List<TeacherCourseServiceModel>()
            };
            var studentId = 1;
            var expectedAbsenceId = 456;
            _teacherServiceMock.Setup(service => service.AddAbsenceToStudentAsync(model, studentId))
                               .ReturnsAsync(expectedAbsenceId);

            // Act
            var result = await _teacherServiceMock.Object.AddAbsenceToStudentAsync(model, studentId);

            // Assert
            Assert.That(result, Is.EqualTo(expectedAbsenceId));
        }

        // Example Test 6: Testing DeleteGradeAsync method
        [Test]
        public async Task DeleteGradeAsync_ShouldExecuteSuccessfully_WhenGradeIsDeleted()
        {
            // Arrange
            var gradeId = 123;
            _teacherServiceMock.Setup(service => service.DeleteGradeAsync(gradeId))
                               .Returns(Task.CompletedTask);

            // Act
            await _teacherServiceMock.Object.DeleteGradeAsync(gradeId);

            // Assert
            _teacherServiceMock.Verify(service => service.DeleteGradeAsync(gradeId), Times.Once);
        }

        // Example Test 7: Testing RemarkOfStudentExists method
        [Test]
        public async Task RemarkOfStudentExists_ShouldReturnTrue_WhenRemarkExistsForStudent()
        {
            // Arrange
            var studentId = 1;
            var remarkText = "Good performance";
            var courseId = 10;
            _teacherServiceMock.Setup(service => service.RemarkOfStudentExists(studentId, remarkText, courseId))
                               .ReturnsAsync(true);

            // Act
            var result = await _teacherServiceMock.Object.RemarkOfStudentExists(studentId, remarkText, courseId);

            // Assert
            Assert.IsTrue(result);
        }

        // Example Test 8: Testing AddRemarkToStudentAsync method
        [Test]
        public async Task AddRemarkToStudentAsync_ShouldReturnRemarkId_WhenRemarkIsAdded()
        {
            // Arrange
            var model = new RemarkFormViewModel { RemarkText = "Excellent" };
            var studentId = 1;
            var expectedRemarkId = 789;
            _teacherServiceMock.Setup(service => service.AddRemarkToStudentAsync(model, studentId))
                               .ReturnsAsync(expectedRemarkId);

            // Act
            var result = await _teacherServiceMock.Object.AddRemarkToStudentAsync(model, studentId);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRemarkId));
        }

        // Example Test 9: Testing GetNewsByIdAsync method
        [Test]
        public async Task GetNewsByIdAsync_ShouldReturnNews_WhenNewsExists()
        {
            // Arrange
            var newsId = 1;
            var expectedNews = new TeacherNewsFormViewModel
            {
                Id = newsId,
                Title = "School Event",
                Content = "School event is scheduled for next week",
                TeacherId = "teacher1"
            };
            _teacherServiceMock.Setup(service => service.GetNewsByIdAsync(newsId))
                               .ReturnsAsync(expectedNews);

            // Act
            var result = await _teacherServiceMock.Object.GetNewsByIdAsync(newsId);

            // Assert
            Assert.That(result.Id, Is.EqualTo(expectedNews.Id));
        }

        [Test]
        public async Task GetAbsenceByIdAsync_ShouldReturnAbsence_WhenAbsenceExists()
        {
            // Arrange
            var absenceId = 1;
            var expectedAbsence = new AbsenceFormViewModel 
            {
                Id = absenceId,
                AbsenceDate = DateTime.Now,
                CourseId = 10,
                StudentId = 1,
                StudentName = "John Doe",
                CourseName = "Math",
                Courses = new List<TeacherCourseServiceModel>()
            };
            _teacherServiceMock.Setup(service => service.GetAbsenceByIdAsync(absenceId))
                               .ReturnsAsync(expectedAbsence);

            // Act
            var result = await _teacherServiceMock.Object.GetAbsenceByIdAsync(absenceId);

            // Assert
            Assert.That(result.Id, Is.EqualTo(expectedAbsence.Id));
            Assert.That(result.StudentId, Is.EqualTo(expectedAbsence.StudentId));
            Assert.That(result.StudentName, Is.EqualTo(expectedAbsence.StudentName));
            Assert.That(result.CourseId, Is.EqualTo(expectedAbsence.CourseId));
            Assert.That(result.CourseName, Is.EqualTo(expectedAbsence.CourseName));
            Assert.That(result.AbsenceDate, Is.EqualTo(expectedAbsence.AbsenceDate));
            Assert.That(result.Courses, Is.EqualTo(expectedAbsence.Courses));
        }

        // Test for EditAbsenceAsync
        [Test]
        public async Task EditAbsenceAsync_ShouldReturnAbsenceId_WhenAbsenceIsEdited()
        {
            // Arrange
            var absenceId = 1;
            var updatedModel = new AbsenceFormViewModel
            {
                Id = absenceId,
                AbsenceDate = DateTime.Now,
                CourseId = 10,
                StudentId = 1,
                StudentName = "John Doe",
                CourseName = "Math",
                Courses = new List<TeacherCourseServiceModel>()
            };
            var expectedAbsenceId = absenceId;
            _teacherServiceMock.Setup(service => service.EditAbsenceAsync(absenceId, updatedModel))
                               .ReturnsAsync(expectedAbsenceId);

            // Act
            var result = await _teacherServiceMock.Object.EditAbsenceAsync(absenceId, updatedModel);

            // Assert
            Assert.That(result, Is.EqualTo(expectedAbsenceId));
        }

        // Test for DeleteAbsenceAsync
        [Test]
        public async Task DeleteAbsenceAsync_ShouldExecuteSuccessfully_WhenAbsenceIsDeleted()
        {
            // Arrange
            var absenceId = 1;
            _teacherServiceMock.Setup(service => service.DeleteAbsenceAsync(absenceId))
                               .Returns(Task.CompletedTask);

            // Act
            await _teacherServiceMock.Object.DeleteAbsenceAsync(absenceId);

            // Assert
            _teacherServiceMock.Verify(service => service.DeleteAbsenceAsync(absenceId), Times.Once);
        }

        // Test for GetRemarkByIdAsync
        [Test]
        public async Task GetRemarkByIdAsync_ShouldReturnRemark_WhenRemarkExists()
        {
            // Arrange
            var remarkId = 1;
            var expectedRemark = new RemarkFormViewModel 
            {
                Id = remarkId,
                RemarkText = "Great improvement!",
                CourseId = 10,
                CourseName = "Math",
                StudentId = 1,
                TeacherId = 23,
                Courses = new List<TeacherCourseServiceModel>()
            };
            _teacherServiceMock.Setup(service => service.GetRemarkByIdAsync(remarkId))
                               .ReturnsAsync(expectedRemark);

            // Act
            var result = await _teacherServiceMock.Object.GetRemarkByIdAsync(remarkId);

            // Assert
            Assert.That(result.Id, Is.EqualTo(expectedRemark.Id));
            Assert.That(result.RemarkText, Is.EqualTo(expectedRemark.RemarkText));
            Assert.That(result.CourseId, Is.EqualTo(expectedRemark.CourseId));
            Assert.That(result.CourseName, Is.EqualTo(expectedRemark.CourseName));
            Assert.That(result.StudentId, Is.EqualTo(expectedRemark.StudentId));
            Assert.That(result.TeacherId, Is.EqualTo(expectedRemark.TeacherId));
            Assert.That(result.Courses, Is.EqualTo(expectedRemark.Courses));
        }

        // Test for EditRemarkAsync
        [Test]
        public async Task EditRemarkASync_ShouldReturnRemarkId_WhenRemarkIsEdited()
        {
            // Arrange
            var remarkId = 1;
            var updatedModel = new RemarkFormViewModel
            {
                Id = remarkId,
                RemarkText = "Great improvement!",
                CourseId = 10,
                CourseName = "Math",
                StudentId = 1,
                TeacherId = 23,
                Courses = new List<TeacherCourseServiceModel>()
            };
            var expectedRemarkId = remarkId;
            _teacherServiceMock.Setup(service => service.EditRemarkASync(remarkId, updatedModel))
                               .ReturnsAsync(expectedRemarkId);

            // Act
            var result = await _teacherServiceMock.Object.EditRemarkASync(remarkId, updatedModel);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRemarkId));
        }

        // Test for DeleteRemarkAsync
        [Test]
        public async Task DeleteRemarkAsync_ShouldExecuteSuccessfully_WhenRemarkIsDeleted()
        {
            // Arrange
            var remarkId = 1;
            _teacherServiceMock.Setup(service => service.DeleteRemarkAsync(remarkId))
                               .Returns(Task.CompletedTask);

            // Act
            await _teacherServiceMock.Object.DeleteRemarkAsync(remarkId);

            // Assert
            _teacherServiceMock.Verify(service => service.DeleteRemarkAsync(remarkId), Times.Once);
        }

        // Test for GetAllNewsByTeacherIdAsync
        [Test]
        public async Task GetAllNewsByTeacherIdAsync_ShouldReturnNewsList_WhenTeacherHasNews()
        {
            // Arrange
            var teacherId = "teacher1";
            var expectedNews = new List<TeacherNewsServiceModel>
        {
            new TeacherNewsServiceModel 
            { 
                Id = 1,
                Title = "New Math Curriculum",
                CreatedOn = DateTime.Now,
                TeacherId = teacherId
            },
            new TeacherNewsServiceModel 
            { 
                Id = 2,
                Title = "Parent-Teacher Meeting Scheduled" ,
                CreatedOn = DateTime.Now,
                TeacherId = teacherId
            }
        };
            _teacherServiceMock.Setup(service => service.GetAllNewsByTeacherIdAsync(teacherId))
                               .ReturnsAsync(expectedNews);

            // Act
            var result = await _teacherServiceMock.Object.GetAllNewsByTeacherIdAsync(teacherId);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedNews.Count));
            Assert.That(result.ElementAt(0).Title, Is.EqualTo(expectedNews.ElementAt(0).Title));
            Assert.That(result.ElementAt(1).Title, Is.EqualTo(expectedNews.ElementAt(1).Title));
            Assert.That(result.ElementAt(0).CreatedOn, Is.EqualTo(expectedNews.ElementAt(0).CreatedOn));
            Assert.That(result.ElementAt(1).CreatedOn, Is.EqualTo(expectedNews.ElementAt(1).CreatedOn));
            Assert.That(result.ElementAt(0).TeacherId, Is.EqualTo(expectedNews.ElementAt(0).TeacherId));
            Assert.That(result.ElementAt(1).TeacherId, Is.EqualTo(expectedNews.ElementAt(1).TeacherId));
            Assert.That(result.ElementAt(0).Id, Is.EqualTo(expectedNews.ElementAt(0).Id));
            Assert.That(result.ElementAt(1).Id, Is.EqualTo(expectedNews.ElementAt(1).Id));
        }

        // Test for AddNewsToTeacherAsync
        [Test]
        public async Task AddNewsToTeacherAsync_ShouldReturnNewsId_WhenNewsIsAdded()
        {
            // Arrange
            var newsModel = new TeacherNewsFormViewModel 
            { 
                Title = "Holiday Announcement",
                Content = "School will remain closed for the next week",
                Id =12,
                TeacherId="21"
            };
            var expectedNewsId = 101;
            _teacherServiceMock.Setup(service => service.AddNewsToTeacherAsync(newsModel))
                               .ReturnsAsync(expectedNewsId);

            // Act
            var result = await _teacherServiceMock.Object.AddNewsToTeacherAsync(newsModel);

            // Assert
            Assert.That(result, Is.EqualTo(expectedNewsId));
        }

        // Test for EditNewsAsync
        [Test]
        public async Task EditNewsAsync_ShouldReturnNewsId_WhenNewsIsEdited()
        {
            // Arrange
            var newsId = 1;
            var updatedModel = new TeacherNewsFormViewModel
            {
                Title = "Holiday Announcement",
                Content = "School will remain closed for the next week",
                Id = 1,
                TeacherId = "21"
            };
            var expectedNewsId = newsId;
            _teacherServiceMock.Setup(service => service.EditNewsAsync(newsId, updatedModel))
                               .ReturnsAsync(expectedNewsId);

            // Act
            var result = await _teacherServiceMock.Object.EditNewsAsync(newsId, updatedModel);

            // Assert
            Assert.That(result, Is.EqualTo(expectedNewsId));
        }

        // Test for DeleteNewsAsync
        [Test]
        public async Task DeleteNewsAsync_ShouldExecuteSuccessfully_WhenNewsIsDeleted()
        {
            // Arrange
            var newsId = 1;
            _teacherServiceMock.Setup(service => service.DeleteNewsAsync(newsId))
                               .Returns(Task.CompletedTask);

            // Act
            await _teacherServiceMock.Object.DeleteNewsAsync(newsId);

            // Assert
            _teacherServiceMock.Verify(service => service.DeleteNewsAsync(newsId), Times.Once);
        }
        [Test]
        public async Task AddGradeNewsToStudentAsync_ShouldReturnNewsId_WhenGradeNewsIsAdded()
        {
            // Arrange
            var teacherId = "teacher1";
            var studentId = 101;
            var courseId = 5;
            var grade = "A+";
            var expectedNewsId = 1001;

            _teacherServiceMock.Setup(service => service.AddGradeNewsToStudentAsync(teacherId, studentId, courseId, grade))
                               .ReturnsAsync(expectedNewsId);

            // Act
            var result = await _teacherServiceMock.Object.AddGradeNewsToStudentAsync(teacherId, studentId, courseId, grade);

            // Assert
            Assert.AreEqual(expectedNewsId, result);
            _teacherServiceMock.Verify(service => service.AddGradeNewsToStudentAsync(teacherId, studentId, courseId, grade), Times.Once);
        }

        // Test for AddRemarkNewsToStudentAsync
        [Test]
        public async Task AddRemarkNewsToStudentAsync_ShouldReturnNewsId_WhenRemarkNewsIsAdded()
        {
            // Arrange
            var teacherId = "teacher2";
            var studentId = 102;
            var courseId = 10;
            var expectedNewsId = 2002;

            _teacherServiceMock.Setup(service => service.AddRemarkNewsToStudentAsync(teacherId, studentId, courseId))
                               .ReturnsAsync(expectedNewsId);

            // Act
            var result = await _teacherServiceMock.Object.AddRemarkNewsToStudentAsync(teacherId, studentId, courseId);

            // Assert
            Assert.AreEqual(expectedNewsId, result);
            _teacherServiceMock.Verify(service => service.AddRemarkNewsToStudentAsync(teacherId, studentId, courseId), Times.Once);
        }

        // Test for AddAbsenceNewsToStudentAsync
        [Test]
        public async Task AddAbsenceNewsToStudentAsync_ShouldReturnNewsId_WhenAbsenceNewsIsAdded()
        {
            // Arrange
            var teacherId = "teacher3";
            var studentId = 103;
            var courseId = 15;
            var expectedNewsId = 3003;

            _teacherServiceMock.Setup(service => service.AddAbsenceNewsToStudentAsync(teacherId, studentId, courseId))
                               .ReturnsAsync(expectedNewsId);

            // Act
            var result = await _teacherServiceMock.Object.AddAbsenceNewsToStudentAsync(teacherId, studentId, courseId);

            // Assert
            Assert.AreEqual(expectedNewsId, result);
            _teacherServiceMock.Verify(service => service.AddAbsenceNewsToStudentAsync(teacherId, studentId, courseId), Times.Once);
        }
    }
}
