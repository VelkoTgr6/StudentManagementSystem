using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;

namespace StudentManagementSystem.Infrastructure.Data.Models
{
    public class News
    {
        [Key]
        [Comment("News Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("News Title")]
        [MaxLength(NewsTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("News Content")]
        [MaxLength(NewsContentMaxLength)]
        public string Content { get; set; } = null!;

        [Required]
        [Comment("News Date")]
        public DateTime Date { get; set; }

        [Comment("Publisher Identifier")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Comment("Shows if news is Deleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
