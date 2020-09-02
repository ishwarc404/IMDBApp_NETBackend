using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public interface IMovieService
    {
        Movie Get();
        void Add(Movie movie);
    }
}