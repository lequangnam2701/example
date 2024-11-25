using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eLearning.Models
{
    public class EnrollmentFormModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Missing Input"), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public int Gender { get; set; }
        public int FieldId {  get; set; }
        public int EnrollmentDetailsId { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EnrollmentCode { get; set; }
        public FieldModel Field { get; set; }
        public EnrollmentDetailsModel EnrollmentDetails { get; set; }
        public AddressModel Address { get; set; }
    }
}
