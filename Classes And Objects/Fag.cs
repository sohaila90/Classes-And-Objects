namespace Classes_And_Objects;

public class Fag
{
    public int FagKode {get; private set;}
    public string FagNavn { get; private set; }
    public int AntallStudiePoeng { get; private set; }

    public  Fag(int fagKode, string fagNavn, int antallStudiePoeng)
    {
        FagKode = fagKode;
        FagNavn = fagNavn;
        AntallStudiePoeng = antallStudiePoeng;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Fagkode: {FagKode} , FagNavn: {FagNavn} , AntallStudiePoeng: {AntallStudiePoeng}");
    }
}