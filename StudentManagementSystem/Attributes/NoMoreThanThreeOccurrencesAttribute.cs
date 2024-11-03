using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Attributes
{
    public class NoMoreThanThreeOccurrencesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                var digitGroups = stringValue.GroupBy(c => c);
                foreach (var group in digitGroups)
                {
                    if (group.Count() > 3)
                    {
                        return new ValidationResult(ErrorMessage ?? $"The field {validationContext.DisplayName} contains a digit that appears more than 3 times.");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
