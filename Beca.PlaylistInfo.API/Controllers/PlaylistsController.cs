using AutoMapper;
using Beca.PlaylistInfo.API.Models;
using Beca.PlaylistInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Beca.PlaylistInfo.API.Controllers
{
    [ApiController]
    [Route("api/playlists")]
    public class PlaylistsController : ControllerBase
    {
        private readonly IPlaylistInfoRepository _playlistInfoRepository;
        private readonly IMapper _mapper;
        const int maxPlaylistsPageSize = 20;
        public PlaylistsController(IPlaylistInfoRepository playlistInfoRepository, IMapper mapper)
        {
            _playlistInfoRepository = playlistInfoRepository ?? throw new ArgumentNullException(nameof(playlistInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayListWithoutSongsDto>>> GetPlaylists(
            string? name, string? searchQuery, int pageNumber = 1, int pageSize = 10)
        {
            if(pageSize > maxPlaylistsPageSize)
            {
                pageSize = maxPlaylistsPageSize;
            }
            //return Ok(PlaylistDataStore.Current.Playlists);
            var (playlistEntities, paginationMetadata) = await _playlistInfoRepository.
                GetPlaylistsAsync(name, searchQuery, pageNumber ,pageSize);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));
            return Ok(_mapper.Map<IEnumerable<PlayListWithoutSongsDto>>(playlistEntities));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlaylist(int id, bool includeSongs )
        {
            // find city
            //var playlistToReturn = PlaylistDataStore.Current.Playlists
            //    .FirstOrDefault(p => p.Id == id);

            //if (playlistToReturn == null)
            //{
            //    return NotFound();
            //}

            //return Ok(playlistToReturn);

            var playlist = await _playlistInfoRepository.GetPlaylistAsync(id, includeSongs);
            if (playlist == null)
            {
                return NotFound();
            }

            if (includeSongs)
            {
                return Ok(_mapper.Map<PlaylistDto>(playlist));
            }

            return Ok(_mapper.Map<PlayListWithoutSongsDto>(playlist));
        }

    }
}
