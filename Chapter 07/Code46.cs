object someValue = GetSomeValueFromDatabase();

object GetSomeValueFromDatabase()
{
    throw new NotImplementedException();
}

if (DBNull.Value.Equals(someValue))
{
    Console.WriteLine("The value is DB null.");
}
else
{
    Console.WriteLine($"The value is: {someValue}");
}