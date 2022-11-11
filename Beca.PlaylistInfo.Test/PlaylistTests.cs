using Beca.PlaylistInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.PlaylistInfo.Test
{
    public class PlaylistTests
    {
        [Fact]
        public void PlaylistGetter_CheckingChar()
        {
            //Arrange
            var playlist = new Playlist("Bachata Remix");

            //Act
            playlist.Name = "Coldplay Remix";

            //Assert
            Assert.Matches("Cold(p|a|i)lay Remix", playlist.Name);
        }

        [Fact]
        public void GetId_PlaylistIDCheck()
        {
            //Arrange
            var playlist = new Playlist("Bachata Remix");

            //Act and Assert
            Assert.InRange(playlist.Id, 0, 10);
            
        }

        

        
    }
}
