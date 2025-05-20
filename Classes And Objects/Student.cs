namespace Classes_And_Objects;

public class Student
{
    // get kan lese verdien navn, alle kan se navnet, men kan ikke sette navn
    // set kan endre verdien navn
    public string Navn { get; private set; }
    public int Alder { get; private set; }
    public string StudeProgram { get; private set; }
    public int StudentId { get; private set; }

    // lager liste for å gi karakterer
    public List<Karakter> Karakterer { get; private set; } = new List<Karakter>();
    public List<Fag> Fags { get; private set; } = new List<Fag>();

    public Student(string navn, int alder, List<Fag> fag, int studentId)
    {
        // dette er en constructor
        Navn = navn;
        Alder = alder;
        Fags = fag;
        StudentId = studentId;
    }
    
    public void PrintInfo()
    {
       Console.WriteLine($"Elev: {Navn} Alder: {Alder} Studieprogram: {StudeProgram} Id: {StudentId}");
    }

    public void AddKarakter(Karakter karakter)
    {
        Karakterer.Add(karakter);
    }

    public void AddFag(Fag fags)
    {
        Fags.Add(fags);
    }
   
}