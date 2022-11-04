using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beca.PlaylistInfo.API.Entities
{
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; } = String.Empty;

        [ForeignKey("PlayListId")]
        public Playlist? Playlist { get; set; }
        public int PlayListId { get; set; }

        public Song(string name)
        {
            Name = name;
        }
    }
}
