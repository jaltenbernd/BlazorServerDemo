using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Models
{
    public class FormExampleModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = null!;

        public bool Type1 { get; set; }

        public bool Type2 { get; set; }

        public bool Options => Type1 || Type2;
    }
}
