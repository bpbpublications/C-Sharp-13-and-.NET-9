string? myNullableString = GetString();
int length = myNullableString?.Length ?? 0;// If myNullableString is null, assign 0 to length

string GetString()
{
    return "Hello, World!";
}
