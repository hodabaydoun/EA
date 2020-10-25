using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Models
{
   public class AppResponse : BaseHttpResponse
{
    public AppResponse(HttpStatusCode statusCode, string message) : base(statusCode, "succeeded", message)
    {

    }

    public AppResponse(dynamic results = null) : base(HttpStatusCode.Accepted, "succeeded", "")
    {
        this.Results = results;
    }
}


public class AppResponse<T> : BaseHttpResponse<T> where T : class
{

    public AppResponse(T results) : base(HttpStatusCode.Accepted, "succeeded", "")
    {
        this.Results = results;
    }
}
}
