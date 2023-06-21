using GeminApi.Domain.Helpers;
using GeminApi.Domain.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace GeminApi.Domain.Filters
{
    public class ExceptionManagerFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionManagerFilter> _logger;

        public ExceptionManagerFilter(ILogger<ExceptionManagerFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext filterContext)
        {
            HttpStatusCode status = HttpStatusCode.Conflict;
            String message = String.Empty;
            HttpStatusCode statusStaRes = HttpStatusCode.Conflict;

            if (filterContext.Exception.Message != null)
            {
                message = filterContext.Exception.Message;
            }
            switch (filterContext.Exception)
            {
                case BusinesException:
                    status = HttpStatusCode.Conflict;
                    break;
                case DataNotFoundException:
                    status = HttpStatusCode.NotFound;
                    break;
                case DataDuplicatedException:
                    status = HttpStatusCode.Conflict;
                    break;
                case IllegalArgumentException:
                    status = HttpStatusCode.BadRequest;
                    break;
                case GeneralRunTimeException:
                    status = HttpStatusCode.Conflict;
                    break;
                default:
                    message = "No se ha podido procesr su solicitud, por favor contacte al administrador";
                    status = HttpStatusCode.InternalServerError;
                    statusStaRes = HttpStatusCode.InternalServerError;
                    break;
            }

            _logger.LogError(message + " " + filterContext.Exception.StackTrace);

            filterContext.ExceptionHandled = true;

            HttpResponse response = filterContext.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            response.WriteAsync(JsonSerializer.Serialize(new StandardResponse<string>(statusStaRes, message)));
        }
    }
}
