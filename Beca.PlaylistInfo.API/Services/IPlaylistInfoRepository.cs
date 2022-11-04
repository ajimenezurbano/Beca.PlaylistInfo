using Beca.PlaylistInfo.API.Entities;

namespace Beca.PlaylistInfo.API.Services
{
    public interface IPlaylistInfoRepository
    {
        Task<IEnumerable<Playlist>> GetPlaylistsAsync();
        Task<Playlist?> GetPlaylistAsync(int playlistId, bool includeSongs);
        Task<bool> PlaylistExistsAsync(int playlistId);
        Task<IEnumerable<Song>> GetSongsForPlaylistAsync(int playlistId);
        Task<Song?> GetSongForPlaylistAsync(int playlistId,
            int songId);
        Task AddSongForPlaylistAsync(int playlistId, Song song);
        void DeleteSong(Song song);
        Task<bool> SaveChangesAsync();
    }
}
