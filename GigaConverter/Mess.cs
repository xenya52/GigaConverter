namespace GigaConverter;

public class Mess : InputAndSolution
{
    public void TCalculationMethod()
    {
        switch (UserDesicion)
        {
            case 0: solution = UserNumberInput; break;
            case 1: solution = UserNumberInput * 1000; break;
            case 2: solution = UserNumberInput * 1000000; break;
            case 3: solution = UserNumberInput * 1000000000; break;
            case 4: solution = UserNumberInput * 1000000000000; break;
        }
        UserNumberInput = solution;

    }
    public void KgCalculationMethod()
    {
        switch (UserDesicion)
        {
            case 1: solution = UserNumberInput / 1000; break;
            case 0: solution = UserNumberInput; break;
            case 2: solution = UserNumberInput * 1000; break;
            case 3: solution = UserNumberInput * 1000000; break;
            case 4: solution = UserNumberInput * 1000000000; break;
        }
        UserNumberInput = solution;

    }
    public void GCalculationMethod()
    {
        switch (UserDesicion)
        {
            case 0: solution = UserNumberInput / 1000000; break;
            case 1: solution = UserNumberInput / 1000; break;
            case 2: solution = UserNumberInput; break;
            case 3: solution = UserNumberInput * 1000; break;
            case 4: solution = UserNumberInput * 1000000; break;
        }
        UserNumberInput = solution;

    }
    public void MgCalculationMethod()
    {
        switch (UserDesicion)
        {
            case 0: solution = UserNumberInput / 1000000000; break;
            case 1: solution = UserNumberInput / 1000000; break;
            case 2: solution = UserNumberInput / 1000; break;
            case 3: solution = UserNumberInput; break;
            case 4: solution = UserNumberInput * 1000; break;
        }
        UserNumberInput = solution;

    }
    public void MkgCalculationMethod()
    {
        switch (UserDesicion)
        {
            case 0: solution = UserNumberInput / 1000000000000; break;
            case 1: solution = UserNumberInput / 1000000000; break;
            case 2: solution = UserNumberInput / 1000000; break;
            case 3: solution = UserNumberInput / 1000; break;
            case 4: solution = UserNumberInput; break;

        }
        UserNumberInput = solution;

    }
}