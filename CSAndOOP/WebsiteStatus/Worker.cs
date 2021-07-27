using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebsiteStatus
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("The service has been stopped...");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var randomNumber = new Random();
                var result = await client.GetAsync("https://www.iamtimcorey.com");

                if (result.IsSuccessStatusCode)
                {
                    _logger.LogInformation("The website is up. Status code {StatusCode}. And this moments secret number is {randomNumber}", result.StatusCode, randomNumber.Next(1, 100));
                }
                else
                {
                    _logger.LogError("The website is down. Status code {StatusCode}. And this moments secret number is {randomNumber}", result.StatusCode, randomNumber.Next(1, 100));
                }

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
