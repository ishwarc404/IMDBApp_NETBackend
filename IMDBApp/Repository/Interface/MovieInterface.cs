using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public interface IMovieRepository
    {
        Movie Query();
        void Insert(Movie movie);
    }
}