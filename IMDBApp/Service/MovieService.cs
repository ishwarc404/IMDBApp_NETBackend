using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public Movie Get()
        {
            return _movieRepository.Query(); //calls a method in repo

        }

        public void Add(Movie newMovie)
        {
            _movieRepository.Insert(newMovie); //calls a method in repo

        }


    }
}
