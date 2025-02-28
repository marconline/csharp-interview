using System.Threading.Tasks;

public interface ILogger
{
    Task<LogResult> LogAsync(string message);
}
