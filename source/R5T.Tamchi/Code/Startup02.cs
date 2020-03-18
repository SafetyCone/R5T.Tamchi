using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Richmond;


namespace R5T.Tamchi
{
    public class Startup02 : StartupBase
    {
        public Startup02(ILogger<Startup02> logger)
            : base(logger)
        {
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            services
                .AddHostedService<Program01>()
                ;
        }
    }
}
