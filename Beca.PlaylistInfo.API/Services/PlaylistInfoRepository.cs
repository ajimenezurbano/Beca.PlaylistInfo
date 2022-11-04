using Beca.PlaylistInfo.API.DbContexts;
using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beca.PlaylistInfo.API.Services
{
    public class PlaylistInfoRepository : IPlaylistInfoRepository
    {

        private readonly PlaylistInfoContext _context;
        public PlaylistInfoRepository(PlaylistInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Playlist?> GetPlaylistAsync(int playlistId, bool includeSongs)
        {
            if (includeSongs)
            {
                return await _context.Playlists.Include(p => p.Songs)
                    .Where(p => p.Id == playlistId).FirstOrDefaultAsync();
            }

            return await _context.Playlists
                  .Where(p => p.Id == playlistId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Playlist>> GetPlaylistsAsync()
        {
            return await _context.Playlists.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<IEnumerable<Song>> GetSongsForPlaylistAsync(int playlistId)
        {
            return await _context.Songs
                .Where(p => p.PlayListId == playlistId).ToListAsync();
        }

        public async Task<Song?> GetSongForPlaylistAsync(int playlistId, int songId)
        {
            return await _context.Songs
                .Where(p => p.PlayListId == playlistId && p.Id == songId)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> PlaylistExistsAsync(int playlistId)
        {
            return await _context.Playlists.AnyAsync(c => c.Id == playlistId);
        }

        public async Task AddSongForPlaylistAsync(int playlistId, Song song)
        {
            var playlist = await GetPlaylistAsync(playlistId, false);
            if(playlist != null)
            {
                playlist.Songs.Add(song);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public void DeleteSong(Song song)
        {
            _context.Songs.Remove(song);
        }
    }
}
