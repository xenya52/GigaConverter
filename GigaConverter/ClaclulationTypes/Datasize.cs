namespace GigaConverter;

public class Datasize : InputAndSolution
{
    
    private int[] DataChainByte = new int[6] // 1000, Petabyte; 1000, Terabyte; 1000, Gigabyte; 1000, Megabyte;
                                               // 1000, Kilobyte; 0(8) Byte;
    /*Important Note!!!! Da ich in einer chain rechne, brauche ich einen ausgangspunkt
     der punkt an dem ich immer und überalll jeden wert umrechnen kann, wo ich ERST positive multipliziere und dannach
     das zwischenergebnis auf die gewünschte stelle dividiere, um für ein präzieseres ergebnis zu sorgen, vorzugsweise
     verwende ich jetzt IMMER die aus der sicht der chain kleinste einheit damit ich auch umrechnen kann, zb.
     von meile zu km, von byte zu bit... blablabla*/ 
        { 
            1,
        1000,
        1000,
        1000,
        1000,
        1000,
    };
    
    public void DataCalculationMethod()   // UserDesicion =
    {
        //Calculate to the [0] array
        for (int i = UserDesicionInput; i > DataChainByte[0]; i--)
        {
            UserNumberInput = UserNumberInput * DataChainByte[i];
        }

        for (int i = 0; i < UserDesicionOutput; i++)
        {
            UserNumberInput = UserNumberInput / DataChainByte[i];
        }

        solution = UserNumberInput;
        Console.WriteLine("Solution is " + solution + " i made a array with all calcuate possibilitys and then,");
        Console.WriteLine("i calculated the Decisioninput, backwards into the smallest division.");
        Console.WriteLine("After that i calculated forwards with the UserDecisionOutput, into the right type");
    }
}