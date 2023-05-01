using GigaConverter;

class program
{
    public static void Main(string[] args)
    {
        Datasize test = new();
        
        Console.WriteLine("Define userInput");
        double userInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("userDecisionInput");
        int userDecisionInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("userSolutionOutput");
        int userSolutionOutput= Convert.ToInt32(Console.ReadLine());
        
        test.DataCalculationMethod(userInput, userDecisionInput, userSolutionOutput);
    }
}