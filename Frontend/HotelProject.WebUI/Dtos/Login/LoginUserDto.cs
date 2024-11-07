using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Login
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}
