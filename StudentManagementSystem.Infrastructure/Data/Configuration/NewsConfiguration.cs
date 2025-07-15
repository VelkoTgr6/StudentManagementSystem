using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;
using System;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        private News[] initial = new News[]
        {
            new News(){ Id = 1, Title = "New School Year Begins", Content = "The new school year has officially begun. We are excited to welcome all students back to campus and look forward to a successful year ahead.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 1, 10, 0, 0, 0, DateTimeKind.Utc) },
            new News(){ Id = 2, Title = "Science Fair Announced", Content = "The annual science fair will be held next month. Students are encouraged to participate and showcase their projects.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 2, 15, 0, 0, 0, DateTimeKind.Utc) },
            new News(){ Id = 3, Title = "Sports Day Scheduled", Content = "Sports day is scheduled for the end of the semester. Students can participate in various sports activities.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 3, 20, 0, 0, 0, DateTimeKind.Utc) },
            new News(){ Id = 4, Title = "Art Exhibition", Content = "An art exhibition will be held in the school auditorium. Students' artworks will be displayed.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 4, 25, 0, 0, 0, DateTimeKind.Utc) },
            new News(){ Id = 5, Title = "Parent-Teacher Meeting", Content = "A parent-teacher meeting is scheduled for next week. Parents are encouraged to attend and discuss their child's progress.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 5, 30, 0, 0, 0, DateTimeKind.Utc) },
            new News(){ Id = 6, Title = "Holiday Celebration", Content = "The school will be celebrating the upcoming holidays with various events and activities. Students are invited to participate.", PublisherId = "51065229-23b9-402f-a54d-00bb813d6b1c", Date = new DateTime(2024, 6, 5, 0, 0, 0, DateTimeKind.Utc) }
        };

        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(initial);
        }
    }
}
