using MockQueryable;
using Moq;
using StudentManagementSystem.Core.Models.Teacher;
using StudentManagementSystem.Core.Services;
using StudentManagementSystem.Infrastructure.Data.Common;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace Tests
{
    [TestFixture]
    public class TeacherServiceTests
    {
        private TeacherService teacherService;
        private Mock<IRepository> mockRepository;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            teacherService = new TeacherService(mockRepository.Object);
        }

        [Test]
        public async Task AddGradeToStudent_ShouldReturnGradeId_WhenValidDataIsProvided()
        {
            
            var studentId = 1;
            var courseId = 1;
            var gradeScore = 85;
            var model = new GradeFormModel
            {
                CourseId = courseId,
                GradeScore = gradeScore,
                GradeType = "Midterm"
            };

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Grades = new List<Grade>()
            };

            var course = new Course
            {
                Id = courseId,
                IsDeleted = false
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.All<Course>())
                .Returns(new[] { course }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.UpdateStudentsPerformanceAllAsync()).Returns(Task.CompletedTask);
            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1).Callback(() =>
            {
                // Simulate the database assigning an ID to the Grade object
                var grade = student.Grades.FirstOrDefault();
                if (grade != null)
                {
                    grade.Id = 1;
                }
            });
           
            var result = await teacherService.AddGradeToStudent(model, studentId);

            
            Assert.That(result, Is.GreaterThan(0));  // Expecting a valid Grade ID to be returned
        }

        [Test]
        public void AddGradeToStudent_ShouldThrowArgumentNullException_WhenStudentIsNotFound()
        {
            
            var studentId = 1;
            var model = new GradeFormModel
            {
                CourseId = 1,
                GradeScore = 85,
                GradeType = "Midterm"
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(Enumerable.Empty<Student>().AsQueryable().BuildMock());  // No student found

            Assert.That(() => teacherService.AddGradeToStudent(model, studentId),
                Throws.ArgumentNullException.With.Message.Contains("Student not found"));
        }

        [Test]
        public void AddGradeToStudent_ShouldThrowArgumentNullException_WhenCourseIsNotFound()
        {
            
            var studentId = 1;
            var model = new GradeFormModel
            {
                CourseId = 1,
                GradeScore = 85,
                GradeType = "Midterm"
            };

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Grades = new List<Grade>()
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.All<Course>())
                .Returns(Enumerable.Empty<Course>().AsQueryable().BuildMock());  // No course found

            
            Assert.That(() => teacherService.AddGradeToStudent(model, studentId),
                Throws.ArgumentNullException.With.Message.Contains("Course not found"));
        }
        [Test]
        public async Task AddRemarkToStudentAsync_ShouldReturnRemarkId_WhenValidDataIsProvided()
        {
            
            var studentId = 1;
            var model = new RemarkFormViewModel
            {
                CourseId = 1,
                TeacherId = 1,
                RemarkText = "Good performance"
            };

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Remarks = new List<Remark>()
            };

            var course = new Course
            {
                Id = model.CourseId,
                IsDeleted = false
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.All<Course>())
                .Returns(new[] { course }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1).Callback(() =>
            {
                // Simulate the database assigning an ID to the Grade object
                var remark = student.Remarks.FirstOrDefault();
                if (remark != null)
                {
                    remark.Id = 1; // Assign a valid ID
                }
            });

           
            var result = await teacherService.AddRemarkToStudentAsync(model, studentId);

            
            Assert.That(result, Is.GreaterThan(0)); // Expecting a valid Remark ID to be returned
        }
        [Test]
        public void AddRemarkToStudentAsync_ShouldThrowArgumentNullException_WhenStudentNotFound()
        {
            
            var studentId = 1;
            var model = new RemarkFormViewModel
            {
                CourseId = 1,
                TeacherId = 1,
                RemarkText = "Good performance"
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(Enumerable.Empty<Student>().AsQueryable().BuildMock());  // No student found

            
            Assert.That(() => teacherService.AddRemarkToStudentAsync(model, studentId),
                Throws.ArgumentNullException.With.Message.Contains("Student not found"));
        }
        [Test]
        public void AddRemarkToStudentAsync_ShouldThrowArgumentNullException_WhenCourseNotFound()
        {
            
            var studentId = 1;
            var model = new RemarkFormViewModel
            {
                CourseId = 1,
                TeacherId = 1,
                RemarkText = "Good performance"
            };

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Remarks = new List<Remark>()
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.All<Course>())
                .Returns(Enumerable.Empty<Course>().AsQueryable().BuildMock());  // No course found

            
            Assert.That(() => teacherService.AddRemarkToStudentAsync(model, studentId),
                Throws.ArgumentNullException.With.Message.Contains("Course not found"));
        }
        [Test]
        public async Task GetTeacherEntityIdByUserIdAsync_ShouldReturnTeacherId_WhenTeacherExists()
        {
            
            var userId = "teacher1";
            var teacher = new Teacher
            {
                Id = 1,
                UserId = userId,
                IsDeleted = false
            };

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>())
                .Returns(new[] { teacher }.AsQueryable().BuildMock());

           
            var result = await teacherService.GetTeacherEntityIdByUserIdAsync(userId);

            
            Assert.That(result, Is.EqualTo(1)); // Expecting the teacher's ID
        }

        [Test]
        public void GetTeacherEntityIdByUserIdAsync_ShouldThrowArgumentNullException_WhenTeacherNotFound()
        {
            
            var userId = "nonexistentTeacher";

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>())
                .Returns(Enumerable.Empty<Teacher>().AsQueryable().BuildMock());  // No teacher found

            
            Assert.That(() => teacherService.GetTeacherEntityIdByUserIdAsync(userId),
                Throws.ArgumentNullException.With.Message.Contains("Teacher not found"));
        }

        [Test]
        public async Task RemarkOfStudentExists_ShouldReturnTrue_WhenRemarkExists()
        {
            
            var studentId = 1;
            var remarkText = "Good performance";
            var courseId = 1;

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Remarks = new List<Remark>
            {
                new Remark
                {
                    RemarkText = remarkText,
                    CourseId = courseId
                }
            }
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

           
            var result = await teacherService.RemarkOfStudentExists(studentId, remarkText, courseId);

            
            Assert.That(result, Is.True); // Expecting remark to exist
        }

        [Test]
        public async Task RemarkOfStudentExists_ShouldReturnFalse_WhenRemarkDoesNotExist()
        {
            
            var studentId = 1;
            var remarkText = "Excellent work";
            var courseId = 1;

            var student = new Student
            {
                Id = studentId,
                IsDeleted = false,
                Remarks = new List<Remark>()
            };

            mockRepository.Setup(r => r.All<Student>())
                .Returns(new[] { student }.AsQueryable().BuildMock());

           
            var result = await teacherService.RemarkOfStudentExists(studentId, remarkText, courseId);

            
            Assert.That(result, Is.False); // Expecting no matching remark
        }

        [Test]
        public void RemarkOfStudentExists_ShouldThrowArgumentNullException_WhenStudentNotFound()
        {
            
            var studentId = 1;
            var remarkText = "Good performance";
            var courseId = 1;

            mockRepository.Setup(r => r.All<Student>())
                .Returns(Enumerable.Empty<Student>().AsQueryable().BuildMock());  // No student found

            
            Assert.That(() => teacherService.RemarkOfStudentExists(studentId, remarkText, courseId),
                Throws.ArgumentNullException.With.Message.Contains("Student not found"));
        }

        [Test]
        public async Task GetCourseNameById_ShouldReturnCourseName_WhenCourseExists()
        {
            
            var courseId = 1;
            var courseName = "Mathematics";

            var course = new Course
            {
                Id = courseId,
                IsDeleted = false,
                Name = courseName
            };

            mockRepository.Setup(r => r.AllAsReadOnly<Course>())
                .Returns(new[] { course }.AsQueryable().BuildMock());

           
            var result = await teacherService.GetCourseNameById(courseId);

            
            Assert.That(result, Is.EqualTo(courseName)); // Expecting the course name
        }

        [Test]
        public void GetCourseNameById_ShouldThrowArgumentNullException_WhenCourseNotFound()
        {
            
            var courseId = 1;

            mockRepository.Setup(r => r.AllAsReadOnly<Course>())
                .Returns(Enumerable.Empty<Course>().AsQueryable().BuildMock());  // No course found

            
            Assert.That(() => teacherService.GetCourseNameById(courseId),
                Throws.ArgumentNullException.With.Message.Contains("Course not found"));
        }

        [Test]
        public async Task GetGradeByIdAsync_ShouldReturnGradeFormModel_WhenGradeExists()
        {
            
            var gradeId = 1;
            var grades = new List<Grade>()
            {
                new Grade
                {
                    Id = gradeId,
                    StudentId = 100,
                    CourseId = 200,
                    GradeScore = 90,
                    GradeType = "A",
                    IsDeleted = false
                }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Grade>()).Returns(grades);

           
            var result = await teacherService.GetGradeByIdAsync(gradeId);

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.GradeId, Is.EqualTo(gradeId));
            Assert.That(result.StudentId, Is.EqualTo(100));
            Assert.That(result.CourseId, Is.EqualTo(200));
            Assert.That(result.GradeScore, Is.EqualTo(90));
            Assert.That(result.CustomGradeType, Is.EqualTo("A"));
            Assert.That(result.SelectedCourseId, Is.EqualTo(200));
            Assert.That(result.SelectedGrade, Is.EqualTo("90"));
            Assert.That(result.SelectedGradeType, Is.EqualTo("A"));
        }

        [Test]
        public void GetGradeByIdAsync_ShouldThrowArgumentNullException_WhenGradeNotFound()
        {
            
            var gradeId = 1;

            mockRepository.Setup(r => r.AllAsReadOnly<Grade>())
                .Returns(Enumerable.Empty<Grade>().AsQueryable().BuildMock());  // No grade found

            
            Assert.That(() => teacherService.GetGradeByIdAsync(gradeId),
                Throws.ArgumentNullException.With.Message.Contains("Grade not found"));
        }

        [Test]
        public async Task EditGradeAsync_ShouldReturnGradeId_WhenGradeIsUpdated()
        {
            
            var gradeId = 1;
            var gradeModel = new GradeFormModel
            {
                GradeScore = 90,
                GradeType = "B",
                CourseId = 1,
                CustomGradeType = "Custom"
            };

            var grade = new Grade
            {
                Id = gradeId,
                GradeScore = 85,
                GradeType = "A",
                CourseId = 1,
                IsDeleted = false
            };

            mockRepository.Setup(r => r.All<Grade>())
                .Returns(new[] { grade }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

           
            var result = await teacherService.EditGradeAsync(gradeId, gradeModel);

            
            Assert.That(result, Is.EqualTo(gradeId)); // Expecting the grade ID
            Assert.That(grade.GradeScore, Is.EqualTo(90)); // Grade score should be updated
            Assert.That(grade.GradeType, Is.EqualTo("B (Custom)")); // Grade type should be updated
        }

        [Test]
        public void EditGradeAsync_ShouldThrowArgumentNullException_WhenGradeNotFound()
        {
            
            var gradeId = 1;
            var gradeModel = new GradeFormModel
            {
                GradeScore = 90,
                GradeType = "B",
                CourseId = 1
            };

            mockRepository.Setup(r => r.All<Grade>())
                .Returns(Enumerable.Empty<Grade>().AsQueryable().BuildMock());  // No grade found

            
            Assert.That(() => teacherService.EditGradeAsync(gradeId, gradeModel),
                Throws.ArgumentNullException.With.Message.Contains("Grade not found"));
        }

        [Test]
        public async Task DeleteGradeAsync_ShouldMarkGradeAsDeleted_WhenGradeExists()
        {
            
            var gradeId = 1;

            var grade = new Grade
            {
                Id = gradeId,
                IsDeleted = false,
                GradeScore = 85,
                GradeType = "A",
                CourseId = 1,
                StudentId = 1
            };

            mockRepository.Setup(r => r.All<Grade>())
                .Returns(new[] { grade }.AsQueryable().BuildMock());

            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

           
            await teacherService.DeleteGradeAsync(gradeId);

            
            Assert.That(grade.IsDeleted, Is.True); // Grade should be marked as deleted
        }

        [Test]
        public void DeleteGradeAsync_ShouldThrowArgumentNullException_WhenGradeNotFound()
        {
            
            var gradeId = 1;

            mockRepository.Setup(r => r.All<Grade>())
                .Returns(Enumerable.Empty<Grade>().AsQueryable().BuildMock());  // No grade found

            
            Assert.That(() => teacherService.DeleteGradeAsync(gradeId),
                Throws.ArgumentNullException.With.Message.Contains("Grade not found"));
        }

        [Test]
        public async Task GetAbsenceByIdAsync_ShouldReturnAbsenceFormViewModel_WhenAbsenceExists()
        {
            
            var absenceId = 1;
            var absences = new List<Absence>
        {
            new Absence
            {
                Id = absenceId,
                StudentId = 100,
                CourseId = 200,
                Date = new DateTime(2024, 12, 15),
                IsDeleted = false
            }
        }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.All<Absence>()).Returns(absences);

           
            var result = await teacherService.GetAbsenceByIdAsync(absenceId);

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(absenceId));
            Assert.That(result.StudentId, Is.EqualTo(100));
            Assert.That(result.CourseId, Is.EqualTo(200));
            Assert.That(result.AbsenceDate, Is.EqualTo(new DateTime(2024, 12, 15).Date));
        }


        [Test]
        public void GetAbsenceByIdAsync_ShouldThrowArgumentNullException_WhenAbsenceNotFound()
        {
            
            var absenceId = 1;

            mockRepository.Setup(r => r.All<Absence>())
                .Returns(Enumerable.Empty<Absence>().AsQueryable().BuildMock());  // No absence found

            
            Assert.That(() => teacherService.GetAbsenceByIdAsync(absenceId),
                Throws.ArgumentNullException.With.Message.Contains("Absence not found"));
        }

        [Test]
        public async Task EditAbsenceAsync_ShouldEditAbsence()
        {
            
            var absenceId = 1;
            var model = new AbsenceFormViewModel
            {
                AbsenceDate = DateTime.UtcNow,
                CourseId = 1
            };
            var absence = new Absence { Id = absenceId, IsDeleted = false };

            mockRepository.Setup(r => r.All<Absence>())
                .Returns(new List<Absence> { absence }.AsQueryable().BuildMock());

           
            var result = await teacherService.EditAbsenceAsync(absenceId, model);

            
            Assert.That(result, Is.EqualTo(absenceId));
            Assert.That(absence.Date, Is.EqualTo(model.AbsenceDate));
            Assert.That(absence.CourseId, Is.EqualTo(model.CourseId));
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteAbsenceAsync_ShouldDeleteAbsence()
        {
            
            var absenceId = 1;
            var absence = new Absence { Id = absenceId, IsDeleted = false };

            mockRepository.Setup(r => r.All<Absence>())
                .Returns(new List<Absence> { absence }.AsQueryable().BuildMock());

           
            await teacherService.DeleteAbsenceAsync(absenceId);

            
            Assert.True(absence.IsDeleted);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetRemarkByIdAsync_ShouldReturnRemark()
        {
            
            var remarkId = 1;
            var remark = new Remark { Id = remarkId, IsDeleted = false };

            mockRepository.Setup(r => r.All<Remark>())
                .Returns(new List<Remark> { remark }.AsQueryable().BuildMock());

           
            var result = await teacherService.GetRemarkByIdAsync(remarkId);

            
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(remarkId));
        }

        [Test]
        public async Task EditRemarkAsync_ShouldEditRemark()
        {
            
            var remarkId = 1;
            var model = new RemarkFormViewModel
            {
                RemarkText = "Updated Remark",
                CourseId = 1
            };
            var remark = new Remark { Id = remarkId, IsDeleted = false };

            mockRepository.Setup(r => r.All<Remark>())
                .Returns(new List<Remark> { remark }.AsQueryable().BuildMock());

           
            var result = await teacherService.EditRemarkASync(remarkId, model);

            
            Assert.That(result, Is.EqualTo(remarkId));
            Assert.That(remark.RemarkText, Is.EqualTo(model.RemarkText));
            Assert.That(remark.CourseId, Is.EqualTo(model.CourseId));
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteRemarkAsync_ShouldDeleteRemark()
        {
            
            var remarkId = 1;
            var remark = new Remark { Id = remarkId, IsDeleted = false };

            mockRepository.Setup(r => r.All<Remark>())
                .Returns(new List<Remark> { remark }.AsQueryable().BuildMock());

           
            await teacherService.DeleteRemarkAsync(remarkId);

            
            Assert.True(remark.IsDeleted);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task AddNewsToTeacherAsync_ShouldAddNews()
        {
            
            var model = new TeacherNewsFormViewModel
            {
                Title = "New News",
                Content = "Content",
                TeacherId = "teacher1"
            };

            mockRepository.Setup(r => r.AddAsync(It.IsAny<News>())).Returns(Task.CompletedTask);
            mockRepository.Setup(r => r.SaveChangesAsync()).Returns(Task.FromResult(1));

           
            var result = await teacherService.AddNewsToTeacherAsync(model);

            
            mockRepository.Verify(r => r.AddAsync(It.IsAny<News>()), Times.Once);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task EditNewsAsync_ShouldEditNews()
        {
            
            var newsId = 1;
            var model = new TeacherNewsFormViewModel
            {
                Title = "Updated News",
                Content = "Updated Content",
                TeacherId = "teacher1"
            };

            var news = new News { Id = newsId, Title = "Old News", Content = "Old Content", PublisherId = "teacher1", IsDeleted = false };

            mockRepository.Setup(r => r.All<News>()).Returns(new List<News> { news }.AsQueryable().BuildMock());
            mockRepository.Setup(r => r.SaveChangesAsync()).Returns(Task.FromResult(1));

           
            var result = await teacherService.EditNewsAsync(newsId, model);

            
            Assert.That(result, Is.EqualTo(newsId));
            Assert.That(news.Title, Is.EqualTo("Updated News"));
            Assert.That(news.Content, Is.EqualTo("Updated Content"));
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task DeleteNewsAsync_ShouldDeleteNews()
        {
            
            var newsId = 1;
            var news = new News { Id = newsId, Title = "News", Content = "Content", PublisherId = "teacher1", IsDeleted = false };

            mockRepository.Setup(r => r.All<News>()).Returns(new List<News> { news }.AsQueryable().BuildMock());
            mockRepository.Setup(r => r.SaveChangesAsync()).Returns(Task.FromResult(1));

           
            await teacherService.DeleteNewsAsync(newsId);

            
            Assert.IsTrue(news.IsDeleted);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetNewsByIdAsync_ShouldReturnNews()
        {
            
            var newsId = 1;
            var news = new News { Id = newsId, Title = "News", Content = "Content", PublisherId = "teacher1", IsDeleted = false };

            mockRepository.Setup(r => r.AllAsReadOnly<News>()).Returns(new List<News> { news }.AsQueryable().BuildMock());

           
            var result = await teacherService.GetNewsByIdAsync(newsId);

            
            Assert.That(result.Id, Is.EqualTo(newsId));
            Assert.That(result.Title, Is.EqualTo("News"));
            Assert.That(result.Content, Is.EqualTo("Content"));
        }
        [Test]
        public async Task GetStudentsByMainClassTeacherAsync_ShouldReturnStudents_WhenStudentsExist()
        {
            
            var userId = "testUserId";
            var teacherId = 1;
            var students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", MiddleName = "A", LastName = "Doe", Class = new Class { Name = "Class 1", TeacherId = teacherId } },
                new Student { Id = 2, FirstName = "Jane", MiddleName = "B", LastName = "Smith", Class = new Class { Name = "Class 1", TeacherId = teacherId } }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.All<Student>()).Returns(students);
            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(new List<Teacher> { new Teacher { Id = teacherId, UserId = userId } }.AsQueryable().BuildMock());

           
            var result = await teacherService.GetStudentsByMainClassTeacherAsync(userId);

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.First().Name, Is.EqualTo("Jane B Smith"));
        }

        [Test]
        public void GetStudentsByMainClassTeacherAsync_ShouldThrowException_WhenNoStudentsFound()
        {
            
            var userId = "testUserId";
            var teacherId = 1;
            var students = new List<Student>().AsQueryable().BuildMock();

            mockRepository.Setup(r => r.All<Student>()).Returns(students);
            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(new List<Teacher> { new Teacher { Id = teacherId, UserId = userId } }.AsQueryable().BuildMock());

            
            Assert.ThrowsAsync<ArgumentNullException>(async () => await teacherService.GetStudentsByMainClassTeacherAsync(userId));
        }

        [Test]
        public async Task GetMainTeacherStudentDetailsAsync_ShouldReturnStudentDetails_WhenStudentExists()
        {
            
            var studentId = 1;
            var student = new List<Student>
            {
                new Student
                {
                    Id = studentId,
                    FirstName = "John",
                    MiddleName = "A",
                    LastName = "Doe",
                    Class = new Class { Name = "Class 1" },
                    Grades = new List<Grade> { new Grade { Id = 1, GradeScore = 90, Course = new Course { Name = "Math" } } },
                    Аbsences = new List<Absence> { new Absence { Id = 1, Date = DateTime.Now, Course = new Course { Name = "Math" } } },
                    Remarks = new List<Remark> { new Remark { Id = 1, RemarkText = "Good", Course = new Course { Name = "Math" } } }
                }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(student);

           
            var result = await teacherService.GetMainTeacherStudentDetailsAsync(studentId);

            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.StudentName, Is.EqualTo("John A Doe"));
            Assert.That(result.Grades.Count, Is.EqualTo(1));
            Assert.That(result.Absences.Count, Is.EqualTo(1));
            Assert.That(result.Remarks.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetMainTeacherStudentDetailsAsync_ShouldThrowException_WhenStudentNotFound()
        {
            
            var studentId = 1;
            var students = new List<Student>().AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);

            
            Assert.ThrowsAsync<ArgumentNullException>(async () => await teacherService.GetMainTeacherStudentDetailsAsync(studentId));
        }

        [Test]
        public async Task AddGradeToStudent_ShouldAddGrade()
        {
            
            var studentId = 1;
            var model = new GradeFormModel { CourseId = 1, GradeScore = 95, GradeType = "Exam" };
            var students = new List<Student>
            {
                new Student { Id = studentId, IsDeleted = false, Grades = new List<Grade>() }
            }.AsQueryable().BuildMock();
            var courses = new List<Course>
            {
                new Course { Id = 1, IsDeleted = false }
            }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.All<Student>()).Returns(students);
            mockRepository.Setup(r => r.All<Course>()).Returns(courses);
            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1).Callback(() =>
            {
                // Simulate the database assigning an ID to the Grade object
                var student = students.FirstOrDefault();
                var grade = student?.Grades.FirstOrDefault();
                if (grade != null)
                {
                    grade.Id = 1; // Assign a valid ID
                }
            });

           
            var result = await teacherService.AddGradeToStudent(model, studentId);

            
            Assert.That(result, Is.GreaterThan(0));
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task GetAllClassesByTeacher_ShouldReturnTeacherClassesViewModel()
        {
            
            var userId = "teacher1";

            var teacher = new Teacher
            {
                Id = 1,
                UserId = userId,
                Titles = "Dr.",
                FirstName = "John",
                LastName = "Doe",
                Courses = new List<Course>
            {
                new Course { Id = 1, IsDeleted = false },
                new Course { Id = 2, IsDeleted = false }
            }
            };

            var classCourses = new List<ClassCourse>
        {
            new ClassCourse { ClassId = 1, CourseId = 1, Class = new Class { Id = 1, Name = "12 A", IsDeleted = false } },
            new ClassCourse { ClassId = 2, CourseId = 2, Class = new Class { Id = 2, Name = "11 B", IsDeleted = false } }
        };

            var teachersMock = new List<Teacher> { teacher }.AsQueryable().BuildMock();
            var classCoursesMock = classCourses.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(teachersMock);
            mockRepository.Setup(r => r.AllAsReadOnly<ClassCourse>()).Returns(classCoursesMock);

           
            var result = await teacherService.GetAllClassesByTeacher(userId);

            
            Assert.That(result.TeacherName, Is.EqualTo("Dr. John Doe"));
            Assert.That(result.Classes.Count, Is.EqualTo(2));
            Assert.That(result.Classes[0].ClassName, Is.EqualTo("11 B"));
            Assert.That(result.Classes[1].ClassName, Is.EqualTo("12 A"));
            Assert.That(result.ClassSearchTerm, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetAllClassesByTeacher_ShouldThrowArgumentNullException_WhenTeacherNotFound()
        {
            
            var userId = "invalidTeacher";
            var teachersMock = new List<Teacher>().AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(teachersMock);

            
            Assert.That(async () => await teacherService.GetAllClassesByTeacher(userId),
                Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public async Task GetStudentDetailsAsync_ShouldReturnStudentDetails()
        {
            
            var studentId = 1;
            var teacherId = "teacher1";
            var teacher = new Teacher { Id = 1, UserId = teacherId };
            var students = new List<Student>
            {
                new Student
                {
                    Id = studentId,
                    IsDeleted = false,
                    FirstName = "John",
                    MiddleName = "A",
                    LastName = "Doe",
                    Class = new Class { Name = "Class 1" },
                    Grades = new List<Grade> { new Grade { Course = new Course { IsDeleted = false, TeacherId = 1 }, IsDeleted = false } },
                    Аbsences = new List<Absence> { new Absence { Course = new Course { IsDeleted = false, TeacherId = 1 }, IsDeleted = false } },
                    Remarks = new List<Remark> { new Remark { Course = new Course { IsDeleted = false, TeacherId = 1 }, IsDeleted = false } }
                }
            }.AsQueryable().BuildMock();
            var teachers = new List<Teacher> { teacher }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);
            mockRepository.Setup(r => r.AllAsReadOnly<Teacher>()).Returns(teachers);

           
            var result = await teacherService.GetStudentDetailsAsync(studentId, teacherId);

            
            Assert.That(result.StudentName, Is.EqualTo("John A Doe"));
            Assert.That(result.ClassName, Is.EqualTo("Class 1"));
        }

        [Test]
        public async Task AddGradeNewsToStudentAsync_ShouldAddNewsAndReturnNewsId()
        {
            
            var teacherId = "teacher123";
            var studentId = 1;
            var courseId = 2;
            var grade = "A";

            var courses = new List<Course> { new Course { Id = courseId, Name = "Math", IsDeleted = false } }.AsQueryable().BuildMock();
            var students = new List<Student> { new Student { Id = studentId, FirstName = "John", MiddleName = "A.", LastName = "Doe", IsDeleted = false } }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Course>()).Returns(courses);
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);
            mockRepository.Setup(r => r.AddAsync(It.IsAny<News>())).Callback<News>(n => n.Id = 1).Returns(Task.CompletedTask);
            mockRepository.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

           
            var newsId = await teacherService.AddGradeNewsToStudentAsync(teacherId, studentId, courseId, grade);

            
            mockRepository.Verify(r => r.AddAsync(It.Is<News>(n =>
                n.Title == "New Grade!" &&
                n.Content == "John A. Doe you got new grade (A) for Math course." &&
                n.PublisherId == teacherId
            )), Times.Once);

            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
            Assert.That(newsId, Is.GreaterThan(0));
        }

        [Test]
        public async Task AddRemarkNewsToStudentAsync_ShouldAddNewsAndReturnNewsId()
        {
            
            var teacherId = "teacher123";
            var studentId = 1;
            var courseId = 2;

            var courses = new List<Course> { new Course { Id = courseId, Name = "Science", IsDeleted = false } }.AsQueryable().BuildMock();
            var students = new List<Student> { new Student { Id = studentId, FirstName = "Jane", MiddleName = "B.", LastName = "Smith", IsDeleted = false } }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Course>()).Returns(courses);
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);
            mockRepository.Setup(r => r.AddAsync(It.IsAny<News>())).Callback<News>(n => n.Id = 1).Returns(Task.CompletedTask);

           
            var newsId = await teacherService.AddRemarkNewsToStudentAsync(teacherId, studentId, courseId);

            
            mockRepository.Verify(r => r.AddAsync(It.Is<News>(n =>
                n.Title == "New Remark!" &&
                n.Content == "Jane B. Smith you got remark for Science course." &&
                n.PublisherId == teacherId
            )), Times.Once);

            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
            Assert.That(newsId, Is.GreaterThan(0));
        }

        [Test]
        public async Task AddAbsenceNewsToStudentAsync_ShouldAddNewsAndReturnNewsId()
        {
            
            var teacherId = "teacher123";
            var studentId = 1;
            var courseId = 3;

            var courses = new List<Course> { new Course { Id = courseId, Name = "History", IsDeleted = false } }.AsQueryable().BuildMock();
            var students = new List<Student> { new Student { Id = studentId, FirstName = "Emily", MiddleName = "C.", LastName = "Johnson", IsDeleted = false } }.AsQueryable().BuildMock();

            mockRepository.Setup(r => r.AllAsReadOnly<Course>()).Returns(courses);
            mockRepository.Setup(r => r.AllAsReadOnly<Student>()).Returns(students);
            mockRepository.Setup(r => r.AddAsync(It.IsAny<News>())).Callback<News>(n => n.Id = 1).Returns(Task.CompletedTask);

           
            var newsId = await teacherService.AddAbsenceNewsToStudentAsync(teacherId, studentId, courseId);

            
            mockRepository.Verify(r => r.AddAsync(It.Is<News>(n =>
                n.Title == "New Absence!" &&
                n.Content == "Emily C. Johnson you got absence for History course." &&
                n.PublisherId == teacherId
            )), Times.Once);

            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
            Assert.That(newsId, Is.GreaterThan(0));
        }
    }
}



