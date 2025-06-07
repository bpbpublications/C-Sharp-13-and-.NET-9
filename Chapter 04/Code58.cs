public static int Factorial(int number, int result = 1)
{
    if (number == 1)
        return result;
    else
        return Factorial(number - 1, number * result);
}