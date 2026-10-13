public class PaymentServiceOptions
{
    public const string SectionName = "PaymentService";

    public string ApiUrl { get; set; } = string.Empty;
    public int TimeoutSeconds { get; set; }
    public int MaxRetryAttempts { get; set; }
    public bool EnableLogging { get; set; }
}

public class PaymentRequest
{
    public decimal Amount { get; set; }
}