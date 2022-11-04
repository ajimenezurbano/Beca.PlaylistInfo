using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beca.PlaylistInfo.API.DbContexts
{
    public class PlaylistInfoContext : DbContext
    {
        public DbSet<Playlist> Playlists { get; set; } = null!;
        public DbSet<Song> Songs { get; set; } = null!;

        public PlaylistInfoContext(DbContextOptions<PlaylistInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlist>()
                .HasData(
                new Playlist("Bachata Remix")
                {
                    Id = 1,
                    Description = "La bachata que más nos gusta."
                },
                new Playlist("Reggaeton Remix")
                {
                    Id = 2,
                    Description = "El reggaeton que más nos gusta."
                },
                new Playlist("Coldplay Remix")
                {
                    Id = 3,
                    Description = "Tus canciones de pop más escuchadas."
                });

            modelBuilder.Entity<Song>()
             .HasData(
               new Song("La Bachata - Manuel Turizo")
               {
                   Id = 1,
                   PlayListId = 1,
                   Description = "Canción buenísima de nuestro amigo Manuel Turizo que está llenando conciertos."
               },
               new Song("Propuesta Indecente - Romeo Santos")
               {
                   Id = 2,
                   PlayListId = 1,
                   Description = "Clasicazo de canción, nunca puede faltar cuando hablamos de bachata."
               },
                 new Song("La Gasolina")
                 {
                     Id = 3,
                     PlayListId = 2,
                     Description = "Si necesitas descripción para semejante temazo seguramente seas menor de edad."
                 },
               new Song("Normal - Ferxxo")
               {
                   Id = 4,
                   PlayListId = 2,
                   Description = "Canción de Feid de su álbum Cumpleaños Feliz."
               },
               new Song("The Scientist")
               {
                   Id = 5,
                   PlayListId = 3,
                   Description = "Himno de Coldplay, no necesita más descripición."
               },
               new Song("Adventure Of A Lifetime")
               {
                   Id = 6,
                   PlayListId = 3,
                   Description = "Otra de sus más famosas canciones, bárbaro."
               }
               );
            base.OnModelCreating(modelBuilder);
        }
    }
}
