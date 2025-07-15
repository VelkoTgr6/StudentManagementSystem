using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class AbsenceConfiguration : IEntityTypeConfiguration<Absence>
    {
        private static readonly DateTime AbsenceDate = DateTime.SpecifyKind(new DateTime(2021, 10, 10), DateTimeKind.Utc);
        private Absence[] initialAbsences = new Absence[]
        {
            new Absence() { Id = 1, Date = AbsenceDate, CourseId = 1, StudentId = 1, IsDeleted = false },
            new Absence() { Id = 2, Date = AbsenceDate, CourseId = 1, StudentId = 1, IsDeleted = false },
            new Absence() { Id = 3, Date = AbsenceDate, CourseId = 1, StudentId = 2, IsDeleted = false },
            new Absence() { Id = 4, Date = AbsenceDate, CourseId = 2, StudentId = 2, IsDeleted = false },
            new Absence() { Id = 5, Date = AbsenceDate, CourseId = 2, StudentId = 3, IsDeleted = false },
            new Absence() { Id = 6, Date = AbsenceDate, CourseId = 2, StudentId = 3, IsDeleted = false },
            new Absence() { Id = 7, Date = AbsenceDate, CourseId = 3, StudentId = 4, IsDeleted = false },
            new Absence() { Id = 8, Date = AbsenceDate, CourseId = 3, StudentId = 4, IsDeleted = false },
            new Absence() { Id = 10, Date = AbsenceDate, CourseId = 4, StudentId = 5, IsDeleted = false },
            new Absence() { Id = 11, Date = AbsenceDate, CourseId = 4, StudentId = 5, IsDeleted = false },
            new Absence() { Id = 12, Date = AbsenceDate, CourseId = 4, StudentId = 6, IsDeleted = false },
            new Absence() { Id = 13, Date = AbsenceDate, CourseId = 5, StudentId = 6, IsDeleted = false },
            new Absence() { Id = 14, Date = AbsenceDate, CourseId = 5, StudentId = 7, IsDeleted = false },
            new Absence() { Id = 15, Date = AbsenceDate, CourseId = 5, StudentId = 7, IsDeleted = false },
            new Absence() { Id = 16, Date = AbsenceDate, CourseId = 1, StudentId = 8, IsDeleted = false },
            new Absence() { Id = 17, Date = AbsenceDate, CourseId = 1, StudentId = 8, IsDeleted = false },
            new Absence() { Id = 18, Date = AbsenceDate, CourseId = 1, StudentId = 9, IsDeleted = false },
            new Absence() { Id = 20, Date = AbsenceDate, CourseId = 2, StudentId = 9, IsDeleted = false },
            new Absence() { Id = 21, Date = AbsenceDate, CourseId = 2, StudentId = 10, IsDeleted = false },
            new Absence() { Id = 22, Date = AbsenceDate, CourseId = 2, StudentId = 10, IsDeleted = false },
            new Absence() { Id = 23, Date = AbsenceDate, CourseId = 3, StudentId = 11, IsDeleted = false },
            new Absence() { Id = 24, Date = AbsenceDate, CourseId = 3, StudentId = 11, IsDeleted = false },
            new Absence() { Id = 25, Date = AbsenceDate, CourseId = 4, StudentId = 12, IsDeleted = false },
            new Absence() { Id = 26, Date = AbsenceDate, CourseId = 4, StudentId = 12, IsDeleted = false },
            new Absence() { Id = 27, Date = AbsenceDate, CourseId = 4, StudentId = 13, IsDeleted = false },
            new Absence() { Id = 28, Date = AbsenceDate, CourseId = 5, StudentId = 13, IsDeleted = false },
            new Absence() { Id = 29, Date = AbsenceDate, CourseId = 5, StudentId = 14, IsDeleted = false },
            new Absence() { Id = 30, Date = AbsenceDate, CourseId = 5, StudentId = 14, IsDeleted = false },
            new Absence() { Id = 31, Date = AbsenceDate, CourseId = 4, StudentId = 15, IsDeleted = false },
            new Absence() { Id = 32, Date = AbsenceDate, CourseId = 4, StudentId = 15, IsDeleted = false },
            new Absence() { Id = 33, Date = AbsenceDate, CourseId = 4, StudentId = 16, IsDeleted = false },
            new Absence() { Id = 34, Date = AbsenceDate, CourseId = 5, StudentId = 16, IsDeleted = false },
            new Absence() { Id = 35, Date = AbsenceDate, CourseId = 5, StudentId = 17, IsDeleted = false },
            new Absence() { Id = 36, Date = AbsenceDate, CourseId = 5, StudentId = 17, IsDeleted = false },
            new Absence() { Id = 37, Date = AbsenceDate, CourseId = 1, StudentId = 18, IsDeleted = false },
            new Absence() { Id = 38, Date = AbsenceDate, CourseId = 1, StudentId = 18, IsDeleted = false },
            new Absence() { Id = 39, Date = AbsenceDate, CourseId = 1, StudentId = 19, IsDeleted = false },
            new Absence() { Id = 40, Date = AbsenceDate, CourseId = 2, StudentId = 19, IsDeleted = false },
            new Absence() { Id = 41, Date = AbsenceDate, CourseId = 2, StudentId = 20, IsDeleted = false },
            new Absence() { Id = 42, Date = AbsenceDate, CourseId = 2, StudentId = 20, IsDeleted = false }
        };
        public void Configure(EntityTypeBuilder<Absence> builder)
        {
            builder.HasData(initialAbsences);
        }
    }
}
