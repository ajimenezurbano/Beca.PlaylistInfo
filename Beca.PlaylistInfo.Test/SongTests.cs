using Beca.PlaylistInfo.API.Entities;

namespace Beca.PlaylistInfo.Test
{
    public class SongTests
    {
        [Fact]
        public void SongConstructor_IsNew()
        {
           
            //Arrange
            //nothing to see here

            //Act
            Song song = new Song("Yellow");

            //Assert
            Assert.True(song.IsNew);
        }

        
    }
}