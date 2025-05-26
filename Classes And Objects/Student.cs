namespace Classes_And_Objects;

public class Student
{
    // get kan lese verdien navn, alle kan se navnet, men kan ikke sette navn
    // set kan endre verdien navn
    public string Navn { get; private set; }
    public int Alder { get; private set; }
    public string StudieProgram { get; private set; }
    public int StudentId { get; private set; }

    // lager liste for å gi karakterer
    public List<Karakter> Karakterer { get; private set; } 
    
    // du får tilgang til fags og blir tilknytta til objektet
    public List<Fag> Fags { get; private set; }

    public Student(string navn, int alder, int studentId)
    {
        // dette er en constructor
        Navn = navn;
        Alder = alder;
        StudentId = studentId;
        Karakterer = new List<Karakter>();
        Fags = new List<Fag>();
    }
    
    public void PrintInfo()
    {
       Console.WriteLine($"Elev: {Navn} Alder: {Alder} Studieprogram: {StudieProgram} Id: {StudentId}");
       Gjennomsnittskarakter();
    }
    

    public void AddKarakter(Karakter karakter)
    {
        Karakterer.Add(karakter);
    }
    

    public void AddFag(Fag fags)
    {
        Fags.Add(fags);
        
        
    }

    private void Gjennomsnittskarakter()
    {
        var sum = 0;
        // count samme som length
        for (int i = 0; i < Karakterer.Count; i++)
        {
         sum += Karakterer[i].KarakterVerdi;   
         
        }
        var gjennomsnitt = sum / Karakterer.Count;
        Console.WriteLine($"Gjennomsnitts karakteren er: " +gjennomsnitt);
    }

    public int Studiepoeng()
    {
        var sum = 0;
        for (int i = 0; i < Fags.Count; i++)
        {
            sum += Fags[i].AntallStudiePoeng;
        }

        return sum;
    }
}