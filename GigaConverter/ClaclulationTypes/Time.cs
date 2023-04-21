namespace GigaConverter;

public class Time : InputAndSolution
{
    // Zeit = 0, Jahr; 12, Monat; 52, Woche; 364, Tag; 8760, Stunde; 525600, Minute; 60, Sekunden;
    
    private int[] PositiveTimeChainFromYears = new int[7]
    {
        12, //Jahr
        30, //Monat
        7,  //Woche
        24, //Tag
        60, //Stunde
        60, //Minute
        60, //Sekunden
    };

    public void PositiveTimeCalculationMethod()   // UserDesicion = 0, J; 1, M; 2, W;
                                                  // 3, T; 4, Std; 5, Min; 6, Sek; 
    {
        double UserInputFromYears;
        switch (UserDesicionInput)
        {
            case 0: UserInputFromYears = UserNumberInput; break;
            case 1: UserInputFromYears = UserNumberInput / 12; break;
            case 2: UserInputFromYears = UserNumberInput / 52; break;
            case 3: UserInputFromYears = UserNumberInput / 364; break;
            case 4: UserInputFromYears = UserNumberInput / 8736; break;
            case 5: UserInputFromYears = UserNumberInput / 524160; break;
            case 6: UserInputFromYears = UserNumberInput / 31449600; break;

        }
        for (int i = UserDesicionInput; i < UserDesicionOutput; i++)
        {
            UserInputFromYears = UserNumberInput * PositiveTimeChainFromYears[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution+" positive");
    }
/* DOES NOT WORK RIGHT!!!!    public void NegativeTimeCalculationMethod()
    {
        for (int i =UserDesicionInput; i > UserDesicionOutput; i--)
        {
            UserNumberInput = UserNumberInput / TimeChain[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution + " negative");
    } */
}