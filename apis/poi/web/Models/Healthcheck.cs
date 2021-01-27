using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        // public string buildId = Environment.GetEnvironmentVariable("Build.BuildId", Environment.Process);
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy; Build Id: " //+ buildId;
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
