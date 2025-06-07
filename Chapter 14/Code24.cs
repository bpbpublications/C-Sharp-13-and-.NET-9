using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

public class SafeController : ControllerBase
{
    [HttpGet("safeendpoint")]
    public IActionResult SafeEndpoint(string userInput)
    {
        // Validate the input
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return BadRequest("Invalid input");
        }

        // Encode the input before including it in the output
        var encodedInput = HtmlEncoder.Default.Encode(userInput);
        return Ok($"Safe output: {encodedInput}");
    }
}