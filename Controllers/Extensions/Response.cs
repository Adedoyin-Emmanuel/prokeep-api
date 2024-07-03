using System.Net;
using Newtonsoft.Json;



namespace prokeep.Controllers.Extensions;



public class Respond
{

    public int StatusCode { get; private set; }

    public string StatusDescription { get; private set; }


    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]

    public string Message { get; private set; }

    public object? Result { get; private set; }


    public Respond(int statusCode, string statusDescription)
    {
        StatusCode = statusCode;
        StatusDescription = statusDescription;
    }



    public Respond(string message, int statusCode = 200) : this(statusCode, HttpStatusCode.OK.ToString())
    {

        Message = message;
    }


    public Respond(string message, object? result) : this(message)
    {

        Result = result;
    }

}