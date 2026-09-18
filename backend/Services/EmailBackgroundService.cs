namespace backend.Services
{
    public class EmailBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Background service is running...");

                await Task.Delay(
                    TimeSpan.FromSeconds(5),
                    stoppingToken
                );
            }
        }
    }
}
