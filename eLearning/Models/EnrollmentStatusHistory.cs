using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class EnrollmentStatusHistory
    {
        [Key]
        public int Id { get; set; }
        public int EnrollmentFormId { get; set; }
        public int StatusId { get; set; }
        public DateTime ChangedDate { get; set; }
        public EnrollmentFormModel EnrollmentForm { get; set; }
        public StatusModel Status { get; set; }
    }
}
