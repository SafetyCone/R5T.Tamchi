using System;

using Microsoft.Extensions.Hosting;

using R5T.Dacia;
using R5T.Tromso.Host;
using R5T.Tromso.Startup;


namespace R5T.Tamchi
{
    public class Program02
    {
        public static void SubMain(string[] args)
        {
            var configurationServiceProvider = ServiceProviderHelper.GetEmptyServiceProvider();

            var host = Host.New().UseStartup<Startup02, IHost>(configurationServiceProvider);

            host.Run();
        }
    }
}
