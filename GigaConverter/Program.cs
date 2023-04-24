using GigaConverter;

class program
{
    public static void Main(string[] args)
    {
        Datasize test = new();
        Console.WriteLine("Define UserNumberInput");
        test.UserNumberInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserDesicionInput");
        test.UserDesicionInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("UserDesicionOutput");
        test.UserDesicionOutput = Convert.ToInt32(Console.ReadLine());
        
        /*  !!!NOTE!!!
            Try to make a Positive...Chain and a Negative... it could be the cause for the Negativ chain issues,
            because, you only write down the calculation method from large, to small that will force you too multiply
            aniway try it out and eventualy see something what you can universal use... Date 22.04.2023
         */
        
        /*Time!!!
        if (test.UserDesicionInput < test.UserDesicionOutput)
        {
            test.PositiveTimeCalculationMethod();
        }
        /* ISSUES ... else if (test.UserDesicionInput > test.UserDesicionOutput)
        {
            test.NegativeTimeCalculationMethod();
        }*/
        //Data test
        test.DataCalculationMethod();
    }
}