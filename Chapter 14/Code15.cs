using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcUserService; // Namespace generated from the .proto file

// Assuming the server is running on localhost:5001
using var channel = GrpcChannel.ForAddress("“https://localhost:5001" ”);
var client = new UserService.UserServiceClient(channel);
var userRequest = new UserRequest
{
    UserId = 1
};
var reply = await client.GetUserAsync(userRequest);
Console.WriteLine($"”Name: {reply.Name}, Age: {reply.Age}" ”);