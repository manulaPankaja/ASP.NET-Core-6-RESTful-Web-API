using System.Net;

namespace StudentApplication.DTOs.Responces
{
    public class BaseResponse
    {
        public int status_code {  get; set; } //to return the status code of the  response
        public object data { get; set; } // to return data associated with the response

        public void CreateResponse(HttpStatusCode statusCode, object data)
        {
            status_code = (int)statusCode;
            this.data = data;
        }

    }
}
