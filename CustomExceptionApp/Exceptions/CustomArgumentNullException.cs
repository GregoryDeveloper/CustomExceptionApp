using System;

namespace CustomExceptionApp.Exceptions
{
    public class CustomArgumentNullException : ArgumentNullException
    {
        public CustomArgumentNullException(string paramName, string message) : base(paramName, message) { }
    }
}
