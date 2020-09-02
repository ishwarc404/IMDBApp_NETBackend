using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //important
using Microsoft.Extensions.Logging;
using System.Net;

namespace IMDBApp.Controllers
{
    [ApiController] //enables HTTP routing and responses

    [Route("api/movie")] //how we are able to find the specific controller while making the call
    
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        public Movie Get()
        {
            return _movieService.Get();
        }

        [HttpPost]
        public void Post(Movie newMovie)
        {
            _movieService.Add(newMovie);
        }


    }
}
