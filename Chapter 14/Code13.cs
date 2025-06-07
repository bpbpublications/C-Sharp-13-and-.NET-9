using Grpc.Core;
using GrpcUserService; // Namespace generated from the .proto file

public class UserServiceImpl : UserService.UserServiceBase
{
    // Implement the GetUser method
    public override Task<UserReply> GetUser(UserRequest request, ServerCallContext context)
    {
        var response = new UserReply
        {
            Name = "“John Doe" ”, // Example data
            Age = 30
        };
        return Task.FromResult(response);
    }
}