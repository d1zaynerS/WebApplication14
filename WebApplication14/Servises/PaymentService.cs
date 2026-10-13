using Microsoft.Extensions.Options;

public class PaymentService
{
    private readonly IOptionsMonitor<PaymentServiceOptions> _optionsMonitor;
    private readonly ILogger<PaymentService> _logger;

    public PaymentService(IOptionsMonitor<PaymentServiceOptions> optionsMonitor, ILogger<PaymentService> logger)
    {
        _optionsMonitor = optionsMonitor;
        _logger = logger;

        _optionsMonitor.OnChange(newOptions =>
        {
            _logger.LogInformation("Payment settings have been updated! New Timeout: {T}", newOptions.TimeoutSeconds);
        });
    }

    public void ProcessPayment()
    {
        var settings = _optionsMonitor.CurrentValue;
        _logger.LogInformation("We are sending a request to {Url} with a timeout of {T} seconds.", settings.ApiUrl, settings.TimeoutSeconds);
    }
}