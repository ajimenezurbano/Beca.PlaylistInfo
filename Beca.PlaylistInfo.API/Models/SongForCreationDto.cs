using System.ComponentModel.DataAnnotations;

namespace Beca.PlaylistInfo.API.Models
{
    public class SongForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
