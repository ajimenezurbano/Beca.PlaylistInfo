using AutoMapper;

namespace Beca.PlaylistInfo.API.Profiles
{
    public class PlaylistProfile : Profile
    {
        public PlaylistProfile()
        {
            CreateMap<Entities.Playlist, Models.PlayListWithoutSongsDto>();
            CreateMap<Entities.Playlist, Models.PlaylistDto>();
        }
    }
}
