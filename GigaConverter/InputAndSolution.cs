namespace GigaConverter;

public class InputAndSolution
{
    //UserInput
    public double UserNumberInput { get; set; }
    
    //Decision
    public int UserDesicion { get; set; }   // 0 = KM; 1 = M; 2 = Dc; 3 = Cm; 4 = Mm; 5 = Mk; 6 = Nm;
                                            // 0 = T; 1 = KG; 2 = G; 3 = Mg; 4 = Mkg
    //Solution
    public double solution { get; set; }
}