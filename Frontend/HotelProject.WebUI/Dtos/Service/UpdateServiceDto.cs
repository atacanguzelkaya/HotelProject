using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Enter Service Icon Link")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter Service Title")]
        [StringLength(100, ErrorMessage = "Service title can be maximum 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Service Description")]
        [StringLength(500, ErrorMessage = "Service description can be maximum 500 characters")]
        public string Description { get; set; }
    }
}
