namespace GigaConverter;

public class Mess : InputAndSolution
{
        // Masse = 1000, Tonne; 1000, Kilogramm;  1000, Gramm; 1000, Milligramm; 1000, Mikrogramm;
        private int[] MessChain = new int[5]
        {
            1000, //Tonne
            1000, //Kilogramm
            1000, //Gramm
            1000, //Milligramm
            1000, //Mikrogramm
        };
        public void PositiveMessCalculationMethod()   // UserDesicion = 0, T; 1, Kg; 2, G; 3, Mg; 4, Mkg;
        {
            for (int i = UserDesicionInput; i < UserDesicionOutput; i++)
            {
                UserNumberInput = UserNumberInput * MessChain[i];
            }
            solution = UserNumberInput;
            Console.WriteLine(solution+" positive");
        }
        public void NegativeMessCalculationMethod()   // UserDesicion = 0, T; 1, Kg; 2, G; 3, Mg; 4, Mkg;
        {
            for (int i =UserDesicionInput; i > UserDesicionOutput; i--)
            {
                UserNumberInput = UserNumberInput / MessChain[i];
            }
            solution = UserNumberInput;
            Console.WriteLine(solution + " negative");
        }
}