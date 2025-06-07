using System.Web.Http;

public class AuthenticationController : ApiController
{
    public IHttpActionResult Authenticate(UserModel userModel)
    {
        if (CheckUser(userModel))
        {
            var token = GenerateToken(userModel);
            return Ok(token);
        }

        return Unauthorized();
    }

    private bool CheckUser(UserModel userModel)
    {
        // Implement user validation logic here
        return true; // Simplified for example purposes
    }

    private string GenerateToken(UserModel userModel)
    {
        // Implement token generation logic here
        return "generated-token"; // Simplified for example purposes
    }
}