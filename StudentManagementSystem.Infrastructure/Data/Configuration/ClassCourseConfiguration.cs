﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class ClassCourseConfiguration : IEntityTypeConfiguration<ClassCourse>
    {
        private ClassCourse[] initial = new ClassCourse[]
        {
            new ClassCourse() { ClassId = 1, CourseId = 1 },
            new ClassCourse() { ClassId = 1, CourseId = 2 },
            new ClassCourse() { ClassId = 1, CourseId = 3 },
            new ClassCourse() { ClassId = 1, CourseId = 4 },
            new ClassCourse() { ClassId = 1, CourseId = 5 },
            new ClassCourse() {ClassId = 1, CourseId = 6 },
            new ClassCourse() { ClassId = 1, CourseId = 7 },
            new ClassCourse() { ClassId = 1, CourseId = 8 },
            new ClassCourse() { ClassId = 1, CourseId = 9 },
            new ClassCourse() { ClassId = 1, CourseId = 10 },
            new ClassCourse() { ClassId = 2, CourseId = 1 },
            new ClassCourse() { ClassId = 2, CourseId = 2 },
            new ClassCourse() { ClassId = 2, CourseId = 3 },
            new ClassCourse() { ClassId = 2, CourseId = 4 },
            new ClassCourse() { ClassId = 2, CourseId = 5 },
            new ClassCourse() { ClassId = 2, CourseId = 6 },
            new ClassCourse() { ClassId = 2, CourseId = 7 },
            new ClassCourse() { ClassId = 2, CourseId = 8 },
            new ClassCourse() { ClassId = 2, CourseId = 9 },
            new ClassCourse() { ClassId = 2, CourseId = 10 },
            new ClassCourse() { ClassId = 3, CourseId = 1 },
            new ClassCourse() { ClassId = 3, CourseId = 2 },
            new ClassCourse() { ClassId = 3, CourseId = 3 },
            new ClassCourse() { ClassId = 3, CourseId = 4 },
            new ClassCourse() { ClassId = 3, CourseId = 5 },
            new ClassCourse() { ClassId = 3, CourseId = 6 },
            new ClassCourse() { ClassId = 3, CourseId = 7 },
            new ClassCourse() { ClassId = 3, CourseId = 8 },
            new ClassCourse() { ClassId = 3, CourseId = 9 },
            new ClassCourse() { ClassId = 3, CourseId = 10 },
            new ClassCourse() { ClassId = 4, CourseId = 1 },
            new ClassCourse() { ClassId = 4, CourseId = 2 },
            new ClassCourse() { ClassId = 4, CourseId = 3 },
            new ClassCourse() { ClassId = 4, CourseId = 4 },
            new ClassCourse() { ClassId = 4, CourseId = 5 },
            new ClassCourse() { ClassId = 4, CourseId = 6 },
            new ClassCourse() { ClassId = 4, CourseId = 7 },
            new ClassCourse() { ClassId = 4, CourseId = 8 },
            new ClassCourse() { ClassId = 4, CourseId = 9 },
            new ClassCourse() { ClassId = 4, CourseId = 10 },
            new ClassCourse() { ClassId = 5, CourseId = 1 },
            new ClassCourse() { ClassId = 5, CourseId = 2 },
            new ClassCourse() { ClassId = 5, CourseId = 3 },
            new ClassCourse() { ClassId = 5, CourseId = 4 },
            new ClassCourse() { ClassId = 5, CourseId = 5 },
            new ClassCourse() { ClassId = 5, CourseId = 6 },
            new ClassCourse() { ClassId = 5, CourseId = 7 },
            new ClassCourse() { ClassId = 5, CourseId = 8 },
            new ClassCourse() { ClassId = 5, CourseId = 9 },
            new ClassCourse() { ClassId = 5, CourseId = 10 },
            new ClassCourse() { ClassId = 6, CourseId = 1 },
            new ClassCourse() { ClassId = 6, CourseId = 2 },
            new ClassCourse() { ClassId = 6, CourseId = 3 },
            new ClassCourse() { ClassId = 6, CourseId = 4 },
            new ClassCourse() { ClassId = 6, CourseId = 5 },
            new ClassCourse() { ClassId = 6, CourseId = 6 },
            new ClassCourse() { ClassId = 6, CourseId = 7 },
            new ClassCourse() { ClassId = 6, CourseId = 8 },
            new ClassCourse() { ClassId = 6, CourseId = 9 },
            new ClassCourse() { ClassId = 6, CourseId = 10 },
            new ClassCourse() { ClassId = 7, CourseId = 1 },
            new ClassCourse() { ClassId = 7, CourseId = 2 },
            new ClassCourse() { ClassId = 7, CourseId = 3 },
            new ClassCourse() { ClassId = 7, CourseId = 4 },
            new ClassCourse() { ClassId = 7, CourseId = 5 },
            new ClassCourse() { ClassId = 7, CourseId = 6 },
            new ClassCourse() { ClassId = 7, CourseId = 7 },
            new ClassCourse() { ClassId = 7, CourseId = 8 },
            new ClassCourse() { ClassId = 7, CourseId = 9 },
            new ClassCourse() { ClassId = 7, CourseId = 10 },
            new ClassCourse() { ClassId = 8, CourseId = 1 },
            new ClassCourse() { ClassId = 8, CourseId = 2 },
            new ClassCourse() { ClassId = 8, CourseId = 3 },
            new ClassCourse() { ClassId = 8, CourseId = 4 },
            new ClassCourse() { ClassId = 8, CourseId = 5 },
            new ClassCourse() { ClassId = 8, CourseId = 6 },
            new ClassCourse() { ClassId = 8, CourseId = 7 },
            new ClassCourse() { ClassId = 8, CourseId = 8 },
            new ClassCourse() { ClassId = 8, CourseId = 9 },
            new ClassCourse() { ClassId = 8, CourseId = 10 },
            new ClassCourse() { ClassId = 9, CourseId = 1 },
            new ClassCourse() { ClassId = 9, CourseId = 2 },
            new ClassCourse() { ClassId = 9, CourseId = 3 },
            new ClassCourse() { ClassId = 9, CourseId = 4 },
            new ClassCourse() { ClassId = 9, CourseId = 5 },
            new ClassCourse() { ClassId = 9, CourseId = 6 },
            new ClassCourse() { ClassId = 9, CourseId = 7 },
            new ClassCourse() { ClassId = 9, CourseId = 8 },
            new ClassCourse() { ClassId = 9, CourseId = 9 },
            new ClassCourse() { ClassId = 9, CourseId = 10 },
            new ClassCourse() { ClassId = 10, CourseId = 1 },
            new ClassCourse() { ClassId = 10, CourseId = 2 },
            new ClassCourse() { ClassId = 10, CourseId = 3 },
            new ClassCourse() { ClassId = 10, CourseId = 4 },
            new ClassCourse() { ClassId = 10, CourseId = 5 },
            new ClassCourse() { ClassId = 10, CourseId = 6 },
            new ClassCourse() { ClassId = 10, CourseId = 7 },
            new ClassCourse() { ClassId = 10, CourseId = 8 },
            new ClassCourse() { ClassId = 10, CourseId = 9 },
            new ClassCourse() { ClassId = 10, CourseId = 10 },
        };
        public void Configure(EntityTypeBuilder<ClassCourse> builder)
        {
            builder.HasData(initial);
        }
    }
}
