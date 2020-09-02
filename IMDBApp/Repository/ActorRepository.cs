using System;
using System.Collections.Generic;
using System.Net;
//linq

namespace IMDBApp
{
    public class ActorRepository : IActorRepository
    {

        
        Actor _testActor = new Actor();
        public ActorRepository()
        {
            _testActor.Name = "Ishwar";
            _testActor.Sex = "M";
            _testActor.DOB = "16-09-1998";
            _testActor.Bio = "What a guy!";
            string[] testMovies = { "1", "2" };
            _testActor.Movies = testMovies;
        }
        public Actor Query()
        {
            return _testActor;
        }

        public void Insert(Actor mockActor)
        {
        }

    }
}
