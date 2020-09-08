using Microsoft.Extensions.Configuration; //used for the configuration file
namespace IMDBApp
{
    public class MySettings
    {
        public const string ConnectionKeys = "ConnectionKeys";
        public string DBConnectionString { get; set; }
    }
}