namespace Beca.PlaylistInfo.API.Models
{
    public class PlaylistDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfSongs
        {
            get
            {
                return Songs.Count;
            }
        }

        public ICollection<SongDto> Songs { get; set; } = new List<SongDto>();
    }
}
