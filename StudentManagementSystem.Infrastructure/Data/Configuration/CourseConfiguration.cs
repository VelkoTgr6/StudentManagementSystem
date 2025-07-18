﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        private Course[] initialClasses = new Course[]
           {
            new Course(){Id = 1, Name = "Biology", Description = "Best biology learning system in the world", TeacherId = 21, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 2, Name = "History", Description = "Best history learning system in the world", TeacherId = 22, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 3, Name = "Mathematics", Description = "Comprehensive mathematics curriculum for all levels", TeacherId = 23, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 4, Name = "Physics", Description = "Advanced physics concepts and practical applications", TeacherId = 24, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 5, Name = "Chemistry", Description = "Exploring the fundamentals of chemistry", TeacherId = 25, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 6, Name = "English Literature", Description = "In-depth analysis of classic and modern literature", TeacherId = 26, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 7, Name = "Computer Science", Description = "Programming, algorithms, and computing fundamentals", TeacherId = 27, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 8, Name = "Economics", Description = "Understanding economic systems, theories, and policies", TeacherId = 28, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 9, Name = "Geography", Description = "Exploring the earth's physical features and human geography", TeacherId = 29, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"},
            new Course(){Id = 10, Name = "Art History", Description = "The study of art movements, artists, and their works", TeacherId = 30, PublisherId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"}
           };

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(initialClasses);
        }
    }
}
