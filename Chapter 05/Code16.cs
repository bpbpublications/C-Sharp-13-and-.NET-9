public class MyClass
{
    private int myField; // Private field
    public int MyField // Public property
    {
        get
        {
            return myField;
        }

        set
        {
            myField = value;
        } // You could add checks here before setting the value
    }