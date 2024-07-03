using System.Net;


namespace prokeep.Controllers.Extensions;


public class NotFoundError : ApiError
{

    public NotFoundError() : base(404, HttpStatusCode.NotFound.ToString())
    {

    }

    public NotFoundError(string error) : base(404, HttpStatusCode.NotFound.ToString(), error)
    {

    }
}