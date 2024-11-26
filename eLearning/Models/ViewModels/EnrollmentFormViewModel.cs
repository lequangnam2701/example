using System.ComponentModel.DataAnnotations;

namespace eLearning.Models.ViewModels
{
    public class EnrollmentFormViewModel
    {
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Missing input")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Missing input")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Missing input")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Missing input")]
        public int Gender { get; set; }
        [Required(ErrorMessage = "Missing input")]
        public int FieldId { get; set; }
        public AddressModel Address { get; set; }
        public EnrollmentDetailsModel EnrollmentDetails { get; set; }
    }
}
