using System;
using System.Net;

namespace IMDBApp
{
    public class Movie
    {
        public string Name { get; set; }
        public string Plot { get; set; }
        public string YearOfRelease { get; set; }
        public string Poster { get; set; }
        public string[] Actors { get; set; }
    }
}
