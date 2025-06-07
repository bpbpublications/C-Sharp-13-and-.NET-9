public void ChangeValue(ref int value)
{
    value = 10;
}

.. .
int number = 5;
ChangeValue(ref number);
Console.WriteLine(number); // Outputs: 10
