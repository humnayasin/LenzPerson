using System.ComponentModel.DataAnnotations;

namespace LenzPerson.api.Models.DTO
{
    public class CreateCustomerRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone number should contain only numbers.")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Phone number should be between 10 and 15 digits.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions.")]
        public bool AgreeTerms { get; set; }
    }
}
