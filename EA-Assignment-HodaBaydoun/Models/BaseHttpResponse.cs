using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Models
{
public abstract class BaseHttpResponse
{

    public string Message { get; set; }
    public string Status { get; set; }
    public int StatusCode { get; set; }
    public Dictionary<string, dynamic> Results { get; set; }


    public BaseHttpResponse()
    {

    }
    public BaseHttpResponse(HttpStatusCode statusCode, string status, string message)
    {
        this.Message = message;
        this.Status = status;
        this.StatusCode = (int)statusCode;
    }

    public BaseHttpResponse(HttpStatusCode statusCode, string status, string message, dynamic results) : this(statusCode, status, message)
    {
        this.Results = results;
    }

}

public abstract class BaseHttpResponse<T> : BaseHttpResponse where T : class
{
    public new T Results;
    public BaseHttpResponse(HttpStatusCode statusCode, string status, string message) : base(statusCode, status, message)
    {

    }
}
}
