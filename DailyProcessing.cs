using System.Timers;

public class DailyProcessor
{
    private static Timer timer;

    public static void Start()
    {
        timer = new Timer(86400000); // 24 hours
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        // Add your processing logic here
        Console.WriteLine("Processing daily data...");
    }
}
