using Newtonsoft.Json;


namespace prokeep.Controllers.Extensions
{

    public class ApiError
    {
        public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }


        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; private set; }


        public ApiError(int statusCode, string statusDescription)
        {
            StatusCode = statusCode;
            StatusDescription = statusDescription;
            Message = statusDescription;
        }



        public ApiError(int statusCode, string statusDescription, string message) : this(statusCode, statusDescription)
        {

            Message = message;
        }

    }
}