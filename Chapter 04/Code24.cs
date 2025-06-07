public void GetDimensions(out int width, out int height)
{
    width = 1024;
    height = 768;
}

.. .
int width, height;
GetDimensions(out width, out height);
Console.WriteLine($"Width: {width}, Height: {height}"); // Outputs: Width: 1024, Height: 768
