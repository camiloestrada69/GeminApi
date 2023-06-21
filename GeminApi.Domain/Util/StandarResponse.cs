using System.Net;

namespace GeminApi.Domain.Util
{
    public class StandardResponse<T>
    {
        public int status { get; set; }
        public string message { get; set; }
        public T body { get; set; }
        public StandardResponse() { }

        public StandardResponse(HttpStatusCode status, T body)
        {
            this.status = ((int)status);
            this.body = body;
        }

        public StandardResponse(HttpStatusCode status, String message, T body)
        {
            this.status = ((int)status);
            this.message = message;
            this.body = body;
        }

        public StandardResponse(HttpStatusCode status)
        {
            this.status = ((int)status);
        }

        public StandardResponse(String message, HttpStatusCode status)
        {
            this.status = ((int)status);
            this.message = message;
        }

        public StandardResponse(HttpStatusCode status, String message)
        {
            this.status = ((int)status);
            this.message = message;
        }

    }
}
