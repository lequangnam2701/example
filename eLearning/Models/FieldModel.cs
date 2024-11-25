using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class FieldModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
