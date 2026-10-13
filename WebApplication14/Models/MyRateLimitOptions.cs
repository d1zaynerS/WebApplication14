public class MyRateLimitOptions
{
    public string PolicyName { get; set; } = string.Empty;
    public int PermitLimit { get; set; }
    public int WindowSeconds { get; set; }
    public int QueueLimit { get; set; }
}