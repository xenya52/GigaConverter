namespace GigaConverter;

public class InputAndSolution
{
    //UserInput
    public double UserNumberInput { get; set; }
    
    //Decisions
    public int UserDesicionInput { get; set; }
    public int UserDesicionOutput { get; set; }   //Längen =  Km, 1000; M, 10; Dm, 10; Cm, 10; Mm 10; Mk, 1000; Nm, 1000;
                                            // 0 = KM; 1 = M; 2 = Dc; 3 = Cm; 4 = Mm; 5 = Mk; 6 = Nm;
                                            // Gewichte = T, 1000; KG, 1000; G, 1000; Mg, 1000;
                                            // 0 = T; 1 = KG; 2 = G; 3 = Mg; 4 = Mkg
    //Solution
    public double solution { get; set; }
    
    //Counters
    public int MulitplyCounter { get; set; }
    public int DivideCounter { get; set; }
}