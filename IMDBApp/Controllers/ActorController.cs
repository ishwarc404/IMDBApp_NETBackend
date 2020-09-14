using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //important
using Microsoft.Extensions.Logging;
using System.Net;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration; //used for the configuration file
//using System.Net.Http;
using System.Web;


using Microsoft.AspNetCore.Http;

namespace IMDBApp.Controllers
{
    [ApiController] //enables HTTP routing and responses

    [Route("api/actor")] //how we are able to find the specific controller while making the call

    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        private readonly IConfiguration _configuration;
        private readonly IOptions<MySettings> _settings;
        public ActorController(IActorService actorService, IConfiguration configuration, IOptions<MySettings> settings)
        {
            _actorService = actorService;
            _configuration = configuration; //this is needed initially
            _settings = settings;

        }
        [HttpGet]

        public String Get()
        {

            return _settings.Value.DBConnectionString;

            //the following way is one way to using appsettings.json - program.cs comes into play
            //var databaseOptions = new DatabaseCredentials();
            // _configuration.GetSection(DatabaseCredentials.ConnectionKeys).Bind(databaseOptions);
            //basically get the section in configuration and bind it with that object

            // return databaseOptions.FirstName + " " + databaseOptions.LastName;
        }

        [HttpPost]
        public IActionResult MyFileUpload(IFormFile myFile)
        {

            var FileName = myFile.FileName;
            return Ok(FileName);


        }

    }




}
