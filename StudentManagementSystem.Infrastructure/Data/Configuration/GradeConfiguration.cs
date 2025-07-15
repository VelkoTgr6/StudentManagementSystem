using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;
using System;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        private static readonly DateTime AssignedDate = DateTime.SpecifyKind(new DateTime(2021, 10, 10), DateTimeKind.Utc);
        private Grade[] initial = new Grade[]
        {
            // Student 1
            new Grade() { Id = 1, StudentId = 1, CourseId = 1, GradeScore = 6, GradeType = "Final", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 2, StudentId = 1, CourseId = 2, GradeScore = 5, GradeType = "Midterm", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 3, StudentId = 1, CourseId = 3, GradeScore = 4, GradeType = "Homework", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 4, StudentId = 1, CourseId = 4, GradeScore = 3, GradeType = "Quiz", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 5, StudentId = 1, CourseId = 5, GradeScore = 2, GradeType = "Project", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 6, StudentId = 1, CourseId = 6, GradeScore = 6, GradeType = "Second Term Assessment", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 7, StudentId = 1, CourseId = 7, GradeScore = 5, GradeType = "First Term Assessment", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 8, StudentId = 1, CourseId = 8, GradeScore = 4, GradeType = "Homework", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 9, StudentId = 1, CourseId = 9, GradeScore = 3, GradeType = "Quiz", GradeAssignedDate = AssignedDate, IsDeleted = false },

            // Student 2
            new Grade() { Id = 10, StudentId = 2, CourseId = 1, GradeScore = 2, GradeType = "Project", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 11, StudentId = 2, CourseId = 2, GradeScore = 3, GradeType = "Final", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 12, StudentId = 2, CourseId = 3, GradeScore = 4, GradeType = "Midterm", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 13, StudentId = 2, CourseId = 4, GradeScore = 5, GradeType = "Homework", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 14, StudentId = 2, CourseId = 5, GradeScore = 6, GradeType = "Quiz", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 15, StudentId = 2, CourseId = 6, GradeScore = 2, GradeType = "Project", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 16, StudentId = 2, CourseId = 7, GradeScore = 3, GradeType = "Second Term Assessment", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 17, StudentId = 2, CourseId = 8, GradeScore = 4, GradeType = "First Term Assessment", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 18, StudentId = 2, CourseId = 9, GradeScore = 5, GradeType = "Homework", GradeAssignedDate = AssignedDate, IsDeleted = false },
            new Grade() { Id = 19, StudentId = 2, CourseId = 10, GradeScore = 6, GradeType = "Quiz", GradeAssignedDate = AssignedDate, IsDeleted = false },

            // Students 3-20
            // Each student gets 9 grades, with CourseId and GradeScore cycling deterministically
            // Ids: 20-213
            // StudentId: 3-20
            // CourseId: (i % 10) + 1
            // GradeScore: (i % 5) + 2 // 2 to 6 inclusive
            // GradeType: cycle through 9 types
        };
        public GradeConfiguration()
        {
            string[] gradeTypes = new string[] { "Final", "Midterm", "Homework", "Quiz", "Project", "Second Term Assessment", "First Term Assessment", "Homework", "Quiz" };
            int id = 20;
            for (int student = 3; student <= 20; student++)
            {
                for (int j = 0; j < 9; j++)
                {
                    initial = initial.Append(new Grade
                    {
                        Id = id,
                        StudentId = student,
                        CourseId = (j % 10) + 1,
                        GradeScore = ((j % 5) + 2), // 2 to 6 inclusive
                        GradeType = gradeTypes[j],
                        GradeAssignedDate = AssignedDate,
                        IsDeleted = false
                    }).ToArray();
                    id++;
                }
            }
        }
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasData(initial);
        }
    }
}

