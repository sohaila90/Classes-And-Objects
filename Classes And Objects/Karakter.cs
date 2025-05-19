namespace Classes_And_Objects;

public class Karakter
{
    // get for å lese verdien
    // set for å endre, men kun innenfor klassen
    
    public Student Student { get; private set; }
    public  Fag Fag { get; private set; }
    public int KarakterVerdi {get; private set;}

    // parameterene som er variabler snakker sammen med de nede
    // for eks Student = student; kobler seg med string student
    public Karakter( Student student, Fag fag, int karakterVerdi)
    {
        // constructor
        Student = student;
        Fag = fag;
        KarakterVerdi = karakterVerdi;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student: {Student.Navn}, Fag: {Fag.FagNavn}, KarakterVerdi: {KarakterVerdi}");
    }
}