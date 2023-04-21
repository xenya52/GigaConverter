namespace GigaConverter;

public class InputAndSolution
{
    //UserInput
    public double UserNumberInput { get; set; }
    
    //Decisions
    public int UserDesicionInput { get; set; }
    public int UserDesicionOutput { get; set; }     //Längen =  Km, 1000; M, 10; Dm, 10; Cm, 10; Mm 10; Mk, 1000; Nm, 1000;
                                                    //          0 = KM; 1 = M; 2 = Dc; 3 = Cm; 4 = Mm; 5 = Mk; 6 = Nm;
                                                    // Gewichte = T, 1000; KG, 1000; G, 1000; Mg, 1000;
                                                    //            0 = T; 1 = KG; 2 = G; 3 = Mg; 4 = Mkg
                                                    // Zeit = 10, Jahrhundert; 10, Jahrzehnt; 12, Jahr; 4,345, Monat; 7, Woche; 24, Tag; 60, Stunde; 60, Minute;
                                                    //        60, Sekunden; 60, Milisekunden; 60, Mikrosekunden; 60, Nanosekunden;
                                                    //         0, Jh; 1, Jz; 2, J; 3, M; 4, W;
                                                    //         5, T; 6, Std; 7, Min; 8, Sek; 9, Mili; 10, Mikro; 11, Nano;
    //Solution
    public double solution { get; set; }
}