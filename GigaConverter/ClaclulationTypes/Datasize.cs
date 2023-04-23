namespace GigaConverter;

public class Datasize : InputAndSolution
{
    private int[] PositiveDataChainByte = new int[6] // 1000, Petabyte; 1000, Terabyte; 1000, Gigabyte; 1000, Megabyte;
                                               // 1000, Kilobyte; 0(8) Byte;
    /*Important Note!!!! Da ich in einer chain rechne, brauche ich einen ausgangspunkt
     der punkt an dem ich immer und überalll jeden wert umrechnen kann, wo ich ERST positive multipliziere und dannach
     das zwischenergebnis auf die gewünschte stelle dividiere, um für ein präzieseres ergebnis zu sorgen, vorzugsweise
     verwende ich jetzt IMMER die aus der sicht der chain kleinste einheit damit ich auch umrechnen kann, zb.
     von meile zu km, von byte zu bit... blablabla*/ 
        {
        1000, //Petabyte
        1000, //Terabyte
        1000, //Gigabyte
        1000, //Megabyte
        1000, //Kilobyte
        0, //(8 auf bit) Byte
    };
    public void PositiveDataCalculationMethod()   // UserDesicion =
    {
        for (int i = UserDesicionInput; i < UserDesicionOutput; i++)
        {
            UserNumberInput = UserNumberInput * PositiveDataChainByte[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution+" positive");
    }
    public void NegativeDataCalculationMethod()   // UserDesicion =
    {
        for (int i =UserDesicionInput; i > UserDesicionOutput; i--)
        {
            UserNumberInput = UserNumberInput / PositiveDataChainByte[i];
        }
        solution = UserNumberInput;
        Console.WriteLine(solution + " negative");
    }
}