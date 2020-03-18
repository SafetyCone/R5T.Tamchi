using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace R5T.Tamchi
{
    class Program01 : IHostedService
    {
        public static void SubMain(string[] args)
        {
            var hostBuilder = new HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Program01>()
                    ;
                });

            var host = hostBuilder.Build();

            //host.

            host.Run();
        }


        private IApplicationLifetime ApplicationLifetime { get; }

        private Task Task { get; set; }


        public Program01(IApplicationLifetime applicationLifetime)
        {
            this.ApplicationLifetime = applicationLifetime;
        }

        private async Task Work()
        {
            await Task.Delay(2000);

            Console.WriteLine("Hello world!");

            await Task.Delay(2000);

            Console.WriteLine("Done");

            this.ApplicationLifetime.StopApplication();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            this.Task = Task.Run(this.Work);

            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await this.Task;
        }
    }
}
