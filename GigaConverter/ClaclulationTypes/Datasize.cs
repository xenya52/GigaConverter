namespace GigaConverter;

public class Datasize : InputAndSolution
{
    private double[] DataChain = new double[5] //1.126, Pebibyte; 909.5, Petabyte; 1.1, Tebibyte; 931.3, Terabyte; 1.074 ,Gibibyte
    {
        1.126,
        909.5,
        1.1,
        931.3,
        1.074,
    };
    public void PositiveDataCalculationMethod()   // UserDesicion =
    {
        for (int i = UserDesicionInput; i < UserDesicionOutput; i++)
        {
            UserNumberInput = UserNumberInput * DataChain[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution+" positive");
    }
    public void NegativeDataCalculationMethod()   // UserDesicion =
    {
        for (int i =UserDesicionInput; i > UserDesicionOutput; i--)
        {
            UserNumberInput = UserNumberInput / DataChain[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution + " negative");
    }
}