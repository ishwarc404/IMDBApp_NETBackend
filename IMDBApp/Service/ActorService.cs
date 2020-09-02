using System;
using System.Collections.Generic;
using System.Net;

namespace IMDBApp
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public Actor Get()
        {
            return _actorRepository.Query(); //calls a method in repo

        }

        public void Add(Actor newActor)
        {
            _actorRepository.Insert(newActor); //calls a method in repo
        }

    }
}
