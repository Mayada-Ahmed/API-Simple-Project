using System.ComponentModel.DataAnnotations;

namespace API_Project.Dto
{
    public class UserCredentials
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }
    }
}
