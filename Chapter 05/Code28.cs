DisplayValue(10); // prints "The integer value is: 10"
DisplayValue(3.14f); // prints "The float value is: 3.14"
static void DisplayValue(int num)
{
    Console.WriteLine("The integer value is: " + num);
}

static void DisplayValue(float num)
{
    Console.WriteLine("The float value is: " + num);
}