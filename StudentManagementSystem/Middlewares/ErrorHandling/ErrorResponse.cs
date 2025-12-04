namespace StudentManagementSystem.Middlewares.ErrorHandling
{
    public class ErrorResponse
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public string ErrorType { get; set; } = string.Empty;
    }
}
