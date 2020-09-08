using System;
using System.Net;
using System.Collections.Generic;

namespace IMDBApp
{
    public interface IActorService
    {
        Actor Get();
        void Add(Actor actor);
    }


}