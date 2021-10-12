using System;

namespace Api.Errors
{
    public class ApiResponse
    {        
        public int StatusCode {get; set;}
        public string Message {get; set;}

        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageBasedOnStatusCode(StatusCode);
        }

        private string GetDefaultMessageBasedOnStatusCode(int statusCode)
        {
            return statusCode switch {
                400 => "Bad Request",
                401 => "You are not authorized",
                _ => null
            };
        }
    }
}