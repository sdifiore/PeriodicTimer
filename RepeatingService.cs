namespace PeriodicTimer
{
    public class RepeatingService : BackgroundService
    {
        private ILogger<RepeatingService> _logger;

        public RepeatingService(ILogger<RepeatingService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await DoWorkAsync();
                await Task.Delay(1000, stoppingToken);
            };
        }

        private static async Task DoWorkAsync()
        {
            Console.WriteLine(DateTime.Now.ToString("O"));
        }
    }
}
