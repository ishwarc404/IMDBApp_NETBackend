using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public class MovieRepository : IMovieRepository

    {
        Movie _testMovie = new Movie();

        public MovieRepository()
        {
            _testMovie.Name = "Spiderman";
            _testMovie.Plot = "Dude gets bit by spider, and becomes a super hero";
            _testMovie.YearOfRelease = "16-09-1998";
            _testMovie.Poster = "https://marvelcinematicuniverse.fandom.com/wiki/Spider-Man";
            string[] testActors = { "1", "2" };
            _testMovie.Actors = testActors;
        }
        public Movie Query()
        {
            return _testMovie;
        }

        public void Insert(Movie newMovie)
        {
        }


    }
}
