namespace Beca.PlaylistInfo.API.Models
{
    public class PlayListWithoutSongsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
