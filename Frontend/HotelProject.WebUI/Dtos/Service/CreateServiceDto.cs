using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Enter Service Icon Link")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter Service Title")]
        [StringLength(100, ErrorMessage = "Service title can be maximum 100 characters")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
