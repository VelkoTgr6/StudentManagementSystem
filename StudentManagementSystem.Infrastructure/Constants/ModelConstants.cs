namespace StudentManagementSystem.Infrastructure.Constants
{
    /// <summary>
    /// Constant used for model Validation
    /// </summary>
    public static class ModelConstants
    {
        /// <summary>
        /// Teacher Name Minimal Length
        /// </summary>
        public const int TeacherNameMinLength = 2;
        /// <summary>
        /// Teacher Name Maximum Length
        /// </summary>
        public const int TeacherNameMaxLength = 100;

        /// <summary>
        /// Teacher Titles Maximum Length
        /// </summary>
        public const int TeacherTitlesMaxLength = 50;

        /// <summary>
        /// Teacher Contact Details Minimal Length
        /// </summary>
        public const int TeacherContactMinLength = 2;
        /// <summary>
        /// Teacher Contact Details Maximum Length
        /// </summary>
        public const int TeacherContactMaxLength = 200;

        /// <summary>
        /// Course Name Minimum Length
        /// </summary>
        public const int CourseNameMinLength = 3;
        /// <summary>
        /// Course Name Maximum Length
        /// </summary>
        public const int CourseNameMaxLength = 50;

        /// <summary>
        /// Course Description Minimum Length
        /// </summary>
        public const int CourseDescriptionMinLength = 2;
        /// <summary>
        /// Course Description Minimum Length
        /// </summary>
        public const int CourseDescriptionMaxLength = 200;

        /// <summary>
        /// Student Personal Id Minimum and Maximum Length
        /// </summary>
        public const int StudentPersonalIdMinMaxLength = 10;

        /// <summary>
        /// Student Remarks Maximum Length
        /// </summary>
        public const int StudentRemarksMaxLength = 200;

        /// <summary>
        /// Student Name Minimum Length
        /// </summary>
        public const int StudentNameMinLength = 2;
        /// <summary>
        /// Student Name Maximum Length
        /// </summary>
        public const int StudentNameMaxLength = 100;

        /// <summary>
        /// Student Email Minimum Length
        /// </summary>
        public const int EmailMinValue = 10;
        /// <summary>
        /// Student Email Maximum Length
        /// </summary>
        public const int EmailMaxValue = 50;

        /// <summary>
        /// Student Contact Details Minimum Length
        /// </summary>
        public const int StudentContactMinLength = 2;
        /// <summary>
        /// Student Contact Details Maximum Length
        /// </summary>
        public const int StudentContactMaxLength = 200;


        /// <summary>
        /// Profile Picture Minimum Length
        /// </summary>
        public const int ProfilePictureMinLength = 20;
        /// <summary>
        /// Profile Picture Maximum Length
        /// </summary>
        public const int ProfilePictureMaxLength = 255;

        /// <summary>
        /// Remark Text Minimum and Maximum Length
        /// </summary>
        public const int RemarkTextMinLength = 2;
        public const int RemarkTextMaxLength = 500;

        /// <summary>
        /// Date Format 
        /// </summary>
        public const string DateFormat = "MM/dd/yyyy";

        /// <summary>
        /// Regular Expression for Date Format
        /// </summary>
        public const string RegexDateFormat = @"^(0[1-9]|1[0-2])\/(0[1-9]|[12][0-9]|3[01])\/\d{4}$";

    }
}
