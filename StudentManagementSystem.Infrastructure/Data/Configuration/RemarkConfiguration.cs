using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class RemarkConfiguration : IEntityTypeConfiguration<Remark>
    {
        private Remark[] initial = GenerateInitialRemarks();

        public void Configure(EntityTypeBuilder<Remark> builder)
        {
            builder.HasData(initial);
        }

        private static Remark[] GenerateInitialRemarks()
        {
            List<Remark> remarks = new List<Remark>();
            Random random = new Random();

            for (int studentId = 1; studentId <= 20; studentId++)
            {
                for (int i = 0; i < 3; i++)
                {
                    remarks.Add(new Remark
                    {
                        Id = studentId * 3 + i,
                        CourseId = random.Next(1, 11),
                        TeacherId = random.Next(21, 31),
                        Date = RandomDateGenerator.GenerateRandomDateIn2024(),
                        RemarkText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        StudentId = studentId
                    });
                }
            }

            return remarks.ToArray();
        }
    }

    public static class RandomDateGenerator
    {
        public static DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
        {
            Random random = new Random();
            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }

        public static DateTime GenerateRandomDateIn2024()
        {
            DateTime startDate = new DateTime(2024, 1, 2);
            DateTime endDate = new DateTime(2024, 12, 24);
            return GenerateRandomDate(startDate, endDate);
        }
    }
}
