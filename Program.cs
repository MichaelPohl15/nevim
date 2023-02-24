string baseUnit;
string reqUnit;
double baseValue;
double reqValue;

Console.WriteLine("Insert temperature value");
baseValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insert your base unit c/k/f");
baseUnit = Console.ReadLine();
Console.WriteLine("Insert your required unit c/k/f");
reqUnit = Console.ReadLine();

switch (baseUnit)
{
    case "c":
        switch (reqUnit)
        {
            case "c":
                Console.WriteLine(baseValue + " C");
                break;
            case "k":
                reqValue = baseValue + 273.15;
                Console.WriteLine(reqValue + " K");
                break;
            case "f":
                reqValue = (baseValue * (9.0/5.0)) + 32.0;
                Console.WriteLine(reqValue + " F");
                break;
        }
        break;
    case "k":
        switch (reqUnit)
        {
            case "c":
                reqValue = baseValue - 273.15;
                Console.WriteLine(reqValue + " C");
                break;
            case "k":
                Console.WriteLine(baseValue + " K");
                break;
            case "f":
                // (0K − 273.15) × 9/5 + 32
                reqValue = (baseValue - 273.15)*(9.0/5.0)+32.0;
                Console.WriteLine(reqValue + " F");
                break;
        }
        break;
    case "f":
        switch (reqUnit)
        {
            case "c":
                reqValue = (baseValue - 32.0) * (5.0/9.0);
                Console.WriteLine(reqValue + " C");
                break;
            case "k":
                reqValue = (baseValue - 32) * (5.0/9.0) + 273.15;
                Console.WriteLine(reqValue + " K");
                break;
            case "f":
                Console.WriteLine(baseValue + " F");
                break;
        }
        break;
}