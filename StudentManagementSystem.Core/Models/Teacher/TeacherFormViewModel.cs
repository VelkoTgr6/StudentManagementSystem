﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static StudentManagementSystem.Infrastructure.Constants.ModelConstants;
using static StudentManagementSystem.Core.Constants.ErrorMessageConstants;
using StudentManagementSystem.Core.Models.Course;

namespace StudentManagementSystem.Core.Models.Teacher
{
    public class TeacherFormViewModel
    {
        /// <summary>
        /// Teacher titles
        /// </summary>
        [StringLength(TeacherTitlesMaxLength)]
        public string? Titles { get; set; }

        /// <summary>
        /// Teacher first name
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherNameMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Teacher Last name
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherNameMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [MaxLength(TeacherNameMaxLength)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// teacher contact details
        /// </summary>
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TeacherContactMaxLength,
            MinimumLength = TeacherContactMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [MaxLength(TeacherContactMaxLength)]
        public string ContactDetails { get; set; } = null!;
    }
}
