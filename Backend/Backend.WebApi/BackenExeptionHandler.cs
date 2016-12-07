using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace Backend.WebApi
{
    public class BackenExeptionHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            if (context.Exception is NotFoundException)
            {
                context.Result = new StatusCodeResult(System.Net.HttpStatusCode.NotFound, context.Request);
            }

            return Task.FromResult("hej"); //vises ikke det er en hjælper til at læse en task uden resultat
        }
    }
}