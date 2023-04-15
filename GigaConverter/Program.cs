using GigaConverter;

class program
{
    public static void Main(string[] args)
    {
        Length test = new();
        Console.WriteLine("Define UserNumberInput");
        test.UserNumberInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Define KilometerUserInput");
        test.UserDesicion = Convert.ToInt32(Console.ReadLine());
        test.KmCalculationMethod();
        Console.WriteLine("Solution = " + test.UserNumberInput);
        Console.ReadLine();

    }
}