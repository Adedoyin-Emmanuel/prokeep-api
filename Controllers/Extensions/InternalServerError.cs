using System.Net;



namespace prokeep.Controllers.Extensions;


public class InternalServerError : ApiError
{

    public InternalServerError() : base(500, HttpStatusCode.InternalServerError.ToString())
    {

    }


    public InternalServerError(string error) : base(500, HttpStatusCode.InternalServerError.ToString(), error)
    {

    }
}