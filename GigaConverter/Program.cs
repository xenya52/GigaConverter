using GigaConverter;

class program
{
    public static void Main(string[] args)
    {
        Time test = new();
        Console.WriteLine("Define UserNumberInput");
        test.UserNumberInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserDesicionInput");
        test.UserDesicionInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("UserDesicionOutput");
        test.UserDesicionOutput = Convert.ToInt32(Console.ReadLine());
        
        //LengthCalculationmethodtest
        if (test.UserDesicionInput < test.UserDesicionOutput)
        {
            test.PositiveTimeCalculationMethod();
        }
        /* ISSUES ... else if (test.UserDesicionInput > test.UserDesicionOutput)
        {
            test.NegativeTimeCalculationMethod();
        }*/
        else
        {
            Console.WriteLine("Error: Something went wrong");
        }
    }
}