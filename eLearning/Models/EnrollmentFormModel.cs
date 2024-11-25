using System.ComponentModel.DataAnnotations;

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
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string MotherName { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public int Gender { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string ResidentialAddress { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string PermanentAddress { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public int FieldId {  get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public int EnrollmentDetailId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public FieldModel Feild { get; set; }
        public EnrollmentDetailsModel FeildDetails { get; set; }
    }
}
