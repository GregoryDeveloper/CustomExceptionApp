using System;
using System.Net;

namespace CustomExceptionApp.Exceptions
{
    public class CustomException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, HttpStatusCode statusCode) : base(message) 
        {
            StatusCode = statusCode;
        }
    }
}
