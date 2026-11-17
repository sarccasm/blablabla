namespace OrderSystem.Services;

public sealed class TimeService : ITimeService
{
    public DateTimeOffset GetCurrentTime() => DateTimeOffset.UtcNow;
}
