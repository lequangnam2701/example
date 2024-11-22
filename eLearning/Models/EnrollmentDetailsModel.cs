using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class EnrollmentDetailsModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string University { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string EnrollmentNumber { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string Center { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string Stream {  get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string Field { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public int MarksSecured { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string OutOf {  get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string ClassObtained { get; set; }
    }
}
