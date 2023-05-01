namespace GigaConverter;

public class Datasize
{
    
    public int[] DataChainByte = new int[6]
        
        /*Important Note!!!! Da ich in einer chain rechne, brauche ich einen ausgangspunkt
         der punkt an dem ich immer und überalll jeden wert umrechnen kann, wo ich ERST positive multipliziere und dannach
         das zwischenergebnis auf die gewünschte stelle dividiere, um für ein präzieseres ergebnis zu sorgen, vorzugsweise
         verwende ich jetzt IMMER die aus der sicht der chain kleinste einheit damit ich auch umrechnen kann, zb.
         von meile zu km, von byte zu bit... blablabla*/ 
        
        { 
            1000, //[0] Byte
            1000, //[1] Kilobyte
            1000, //[2] Megabyte
            1000, //[3] Gigabyte
            1000, //[4] Terabyte
            1000, //[5] Petabyte
        };

    public void DataCalculationMethod(double userInput, int userDesicionInput, int userSolutionOutput)
    {
        double solution = 0;
        
        //Calculate to the [0] array
        for (int i = userDesicionInput; i > 0; i--)
        {
            userInput = userInput * DataChainByte[i];
        }

        for (int i = 0; i < userSolutionOutput; i++)
        {
            userInput = userInput / DataChainByte[i];
        }

        solution = userInput; 
        Console.WriteLine("Solution is " + solution + " i made a array with all calcuate possibilitys and then,");
        Console.WriteLine("i calculated the Decisioninput, backwards into the smallest division.");
        Console.WriteLine("After that i calculated forwards with the UserDecisionOutput, into the right type");
    }
}