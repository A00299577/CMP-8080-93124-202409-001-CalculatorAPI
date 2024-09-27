using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<decimal> Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = a + b;

            return Ok("Sum: "+result);
        }

        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = a - b;

            if (result < 0) {
                return BadRequest("Result is Negative. "+result);
            }
            return Ok("Difference: "+result);
        }

        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = a * b;

            return Ok("Product: "+result);
        }

        [HttpGet("divide")]
        public ActionResult<decimal> Divide([FromQuery] decimal a, [FromQuery] decimal b)
        {
           
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }

            decimal result = a / b;
            
            return Ok("Quotient: "+result);
        }

        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo([FromQuery] decimal a, [FromQuery] decimal b)
        {

            if (b == 0)
            {
                return BadRequest("Modulo by zero is not allowed.");
            }

            decimal result = a % b;
            
            return Ok("Remainder: "+result);
        }

    }
}
