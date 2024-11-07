using System.ComponentModel.DataAnnotations;
namespace HotelProject.BusinessLayer.Dtos.Room
{
    public class UpdateRoomDto
    {
        [Required(ErrorMessage = "Please enter the room number")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter the room image")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter price information")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter room title information")]
        [StringLength(100, ErrorMessage = "Please enter maximum 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of beds")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathrooms")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
    }
}
