using Beca.PlaylistInfo.API.Models;

namespace Beca.PlaylistInfo.API
{
    public class PlaylistDataStore
    {
        public List<PlaylistDto> Playlists { get; set; }
        public static PlaylistDataStore Current { get; } = new PlaylistDataStore();

        public PlaylistDataStore()
        {
            Playlists = new List<PlaylistDto>()
            {
                new PlaylistDto()
                {
                    Id = 1,
                    Name = "Bachata Remix",
                    Description = "La bachata que más nos gusta.",
                    Songs = new List<SongDto>()
                    {
                        new SongDto() {
                            Id = 1,
                            Name = "La Bachata - Manuel Turizo",
                            Description = "Canción buenísima de nuestro amigo Manuel Turizo que está llenando conciertos." },
                        new SongDto() {
                            Id = 2,
                            Name = "Propuesta Indecente - Romeo Santos",
                            Description = "Clasicazo de canción, nunca puede faltar cuando hablamos de bachata." },
                    }

                },

                new PlaylistDto()
                {
                    Id = 2,
                    Name = "Reggaeton Remix",
                    Description = "El reggaeton que más nos gusta.",
                    Songs = new List<SongDto>()
                    {
                        new SongDto() {
                            Id = 3,
                            Name = "La Gasolina",
                            Description = "Si necesitas descripción para semejante temazo seguramente seas menor de edad." },
                        new SongDto() {
                            Id = 4,
                            Name = "Normal - Ferxxo",
                            Description = "Canción de Feid de su álbum Cumpleaños Feliz." },
                    }

                },

                new PlaylistDto()
                {
                    Id = 3,
                    Name = "Coldplay Remix",
                    Description = "Tus canciones de pop más escuchadas.",
                    Songs = new List<SongDto>()
                    {
                        new SongDto() {
                            Id = 5,
                            Name = "The Scientist",
                            Description = "Himno de Coldplay, no necesita más descripición." },
                        new SongDto() {
                            Id = 6,
                            Name = "Adventure Of A Lifetime",
                            Description = "Otra de sus más famosas canciones, bárbaro." },
                    }

                }
            };
        }
    }
}
