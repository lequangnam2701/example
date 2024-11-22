using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class FieldModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
