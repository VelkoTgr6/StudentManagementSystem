namespace StudentManagementSystem.Core.Constants
{
    public static class ErrorMessageConstants
    {
        public const string RequiredMessage = "The {0} field is required.";
        public const string InvalidLengthMessage = "The {0} must be between {2} and {1} characters long.";

        public const string InvalidRoleMessage = "Role does not exist.";

        public const string InvalidPersonalIdLengthMessage = "The {0} must be {1} characters long.";

        public const string InvalidEmailMessage = "Email does not exist.";
        public const string EmailAlreadyInUseMessage = "Email is already is used.";

        public const string InvalidClassName = "Invalid Class Name , ex.( 1 A , 12 B )";
    }
}
