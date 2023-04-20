using GigaConverter;

class program
{
    public static void Main(string[] args)
    {
        Length test = new();
        Console.WriteLine("Define UserNumberInput");
        test.UserNumberInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserDesicionInput");
        test.UserDesicionInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("UserDesicionOutput");
        test.UserDesicionOutput = Convert.ToInt32(Console.ReadLine());
        
        //LengthCalculationmethodtest
        if (test.UserDesicionInput < test.UserDesicionOutput)
        {
            test.PositiveLengthCalculationMethod();
        }
        else if (test.UserDesicionInput > test.UserDesicionOutput)
        {
            test.NegativeLengthCalculationMethod();
        }
        else
        {
            Console.WriteLine("Error: Something went wrong");
        }
    }
}