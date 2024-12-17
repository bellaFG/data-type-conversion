//Challenge #2
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

//Challenge #2

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
Console.WriteLine("Result 1: " + result1);

decimal result2;
if (decimal.TryParse(value3.ToString(), out result2))
{
    decimal result2Calculation = value2 / result2;
    Console.WriteLine("Result 2: " + result2Calculation);
}
else
{
    Console.WriteLine("Failed to convert value3 to decimal");
}

float result3;
if (float.TryParse(value1.ToString(), out result3))
{
    float result3Calculation = value3 / result3;
    Console.WriteLine("Result 3: " + result3Calculation);
}
else
{
    Console.WriteLine("Failed to convert value1 to float");
}
