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
    public class PlaylistControllerTests : IDisposable
    {
        public void Dispose() { }

        private PlaylistsController _controller;
        private HttpContext _httpContext;
        public PlaylistControllerTests()
        {
            var MockRepository = new Mock<IPlaylistInfoRepository>();
            var mapperConf = new MapperConfiguration(c => c.AddProfile<PlaylistProfile>());
            var Mapper = new Mapper(mapperConf);

            _httpContext = new DefaultHttpContext();
            
            _controller = new PlaylistsController(MockRepository.Object, Mapper);
            _controller.ControllerContext = new ControllerContext()
            {
                HttpContext = _httpContext
            };
        }

        [Fact]
        public async Task GetSeriesTest()
        {
            //Arrange
            var series = await _controller.GetPlaylists(null, null);

            //Assert
            Assert.True(series != null);
        }

        [Fact]
        public async Task GetSerieTest()
        {
            var serie = await _controller.GetPlaylist(1, false);
            Assert.True(serie != null);
        }

        [Fact]
        public async Task GetErrorSerieDoesntExistTest()
        {
            IActionResult result = await _controller.GetPlaylist(100, false);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
