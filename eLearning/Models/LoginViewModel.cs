using System.ComponentModel.DataAnnotations;

namespace eLearning.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lam ơn nhập UserName")]
        public string UserName { get; set; }

        [DataType(DataType.Password), Required(ErrorMessage = "Lam ơn nhập Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
