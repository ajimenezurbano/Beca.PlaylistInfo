using AutoMapper;
using Beca.PlaylistInfo.API.Controllers;
using Beca.PlaylistInfo.API.Entities;
using Beca.PlaylistInfo.API.Profiles;
using Beca.PlaylistInfo.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.PlaylistInfo.Test
{
    public class SongControllerTests
    {
        private SongsController _controller;
        private HttpContext _httpContext;

        public SongControllerTests()
        {
            var MockRepository = new Mock<IPlaylistInfoRepository>();

            var mapperConf = new MapperConfiguration(c => c.AddProfile<SongProfile>());
            var mapper = new Mapper(mapperConf);

            _httpContext = new DefaultHttpContext();

            _controller = new SongsController(MockRepository.Object, mapper);

            _controller.ControllerContext = new ControllerContext()
            {
                HttpContext = _httpContext,
            };
        }

        [Fact]
        public async void GetSongsTest()
        {
            //Arrange
            int playlistId = 1;

            //Act
            var result = await _controller.GetSongs(playlistId);

            //Assert
            Assert.NotNull(result);
        }


        [Fact]
        public async void GetCapituloTest()
        {
            //Arrange
            int playlistId = 1;
            int songId = 1;

            //Act
            var result = await _controller.GetSong(playlistId, songId);

            //Assert
            Assert.NotNull(result);
        }
    }
}
