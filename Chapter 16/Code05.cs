public class MyCoreLibrary
{
    private MyStandardLibrary _standardLibrary;
    public MyCoreLibrary(MyStandardLibrary standardLibrary)
    {
        _standardLibrary = standardLibrary;
    }

    public string GetCombinedMessage()
    {
        return $"{_standardLibrary.GetMessage()} {_standardLibrary.GetGreeting()}";
    }
}