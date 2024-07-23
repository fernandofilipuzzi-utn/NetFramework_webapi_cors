using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace Prueba.Cors.App_Start
{
    public class DomainFilterHandler : DelegatingHandler
    {
        private readonly string[] _allowedDomains;

        public DomainFilterHandler(params string[] allowedDomains)
        {
            _allowedDomains = allowedDomains;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Verifica el encabezado 'Origin' para solicitudes desde navegadores
            var origin = request.Headers.GetValues("Origin").FirstOrDefault();

            if (origin == null || !_allowedDomains.Any(d => origin.Equals(d, System.StringComparison.OrdinalIgnoreCase)))
            {
                return new HttpResponseMessage(HttpStatusCode.Forbidden);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}