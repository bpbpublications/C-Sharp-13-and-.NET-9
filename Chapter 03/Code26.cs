int? calc1 = 0;
int calc2 = 0;
DoSomething();
Console.WriteLine($"Calc 1:");
Validate(typeof(int? ), calc1);
Console.WriteLine($"Calc 2:");
Validate(typeof(int), calc2);
Console.ReadKey();
void Validate(Type type, int? value)
{
    if (IsNullable(type))
    {
        Console.WriteLine($"value type is null!");
    }

    if (!value.HasValue)
    {
        Console.WriteLine($"value is null!");
    }
    else
    {
        Console.WriteLine($"value is not null: {value}");
    }
}

void DoSomething()
{
    calc1 = null;
    calc2 = 10;
}

bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;