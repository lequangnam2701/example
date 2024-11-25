using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class AddressModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string State { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string City { get; set; }
        [Required(ErrorMessage = "Missing Input")]
        public string Street { get; set; }

    }
}
