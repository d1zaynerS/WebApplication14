using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CheckoutController : ControllerBase
{
    private readonly PaymentService _paymentService;

    public CheckoutController(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost("pay")]
    public IActionResult MakePayment([FromBody] PaymentRequest request)
    {
        _paymentService.ProcessPayment();
        return Ok(new { Message = $"The payment for {request.Amount} has been processed" });
    }
}