using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public interface IActorRepository
    {
        Actor Query();
        void Insert(Actor actor);
    }


}