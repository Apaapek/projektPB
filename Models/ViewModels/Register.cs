using System.ComponentModel.DataAnnotations;

namespace Miniblog.Models.ViewModels
{
    public class Register
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
