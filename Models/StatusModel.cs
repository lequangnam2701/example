using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class StatusModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
