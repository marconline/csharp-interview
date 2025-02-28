public interface ILogger
{
    Task<LogResult> LogAsync(string message);
}
