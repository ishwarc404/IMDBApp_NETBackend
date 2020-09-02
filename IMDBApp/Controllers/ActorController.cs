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

    [Route("api/actor")] //how we are able to find the specific controller while making the call
    
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }
        [HttpGet]
        public Actor Get()
        {
            return _actorService.Get();
        }

        [HttpPost]
        public void Post(Actor newActor)
        {
            _actorService.Add(newActor);
        }


    }
}
