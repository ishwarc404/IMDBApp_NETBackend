using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //important
using Microsoft.Extensions.Logging;
using System.Net;
using Microsoft.Extensions.Configuration; //used for the configuration file

namespace IMDBApp.Controllers
{
    [ApiController] //enables HTTP routing and responses

    [Route("api/actor")] //how we are able to find the specific controller while making the call

    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        private readonly IConfiguration _configuration;
        public ActorController(IActorService actorService, IConfiguration configuration)
        {
            _actorService = actorService;
            _configuration = configuration; //this is needed initially
        }
        [HttpGet]
        public Actor Get()
        {
            return _actorService.Get();

            //using the config keyshere
            // var keyA = _configuration["CustomKeys:KeyA"];
            // var keyB = _configuration["CustomKeys:KeyB"];
            // return new string[] { keyA, keyB };
        }

        [HttpPost]
        public void Post(Actor newActor)
        {
            _actorService.Add(newActor);
        }


    }
}
