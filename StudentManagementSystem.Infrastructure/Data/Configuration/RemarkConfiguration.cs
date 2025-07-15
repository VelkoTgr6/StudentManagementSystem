using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;

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
            int id = 1;
            int[] courseIds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] teacherIds = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            DateTime[] dates =
            {
                new DateTime(2024, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                new DateTime(2024, 2, 15, 0, 0, 0, DateTimeKind.Utc),
                new DateTime(2024, 3, 20, 0, 0, 0, DateTimeKind.Utc)
            };
            for (int studentId = 1; studentId <= 20; studentId++)
            {
                for (int i = 0; i < 3; i++)
                {
                    remarks.Add(new Remark
                    {
                        Id = id++,
                        CourseId = courseIds[(studentId + i) % courseIds.Length],
                        TeacherId = teacherIds[(studentId + i) % teacherIds.Length],
                        Date = dates[i % dates.Length],
                        RemarkText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        StudentId = studentId,
                        IsDeleted = false
                    });
                }
            }
            return remarks.ToArray();
        }
    }
}
