
// namespace betyr at den bor her, men using bruker elementet, men ikke er her
namespace Classes_And_Objects;

public abstract class Program
{
    public static void Main()
    {
        Console.WriteLine("Studentadministrasjonssystem");
        Fag fag1 = new Fag ( 30, "programmering", 30 );
        Fag fag2 = new Fag ( 20, "datamaskin", 20 );
        Fag fag3 = new Fag ( 10, "naturfag", 10 );
        Fag subject2 = new Fag (20, "apputvikler", 20);

        // stundent1 og 2 er 2 instanser som betyr 2 objekter
        Student student1 = new Student (  "Sohaila", 34,30 );
        Student student2 = new Student ( "Johan", 20, 26 );
        
        // Trenger jeg disse eller ikke?
        // student1.AddFag(fag1);
        // student1.AddFag(fag2);
        // student1.AddFag(fag3);
        // student1.AddFag(subject2);
        
        // student2.AddFag(fag1);
        // student2.AddFag(fag2);
        // student2.AddFag(fag3);
        // student2.AddFag(subject2);
        
        
        
        // for hvert fag skriv ut fagnavn
        // foreach = “gjør noe med hver enkelt”
        // // Det er som å si: “klapp hver kylling på hodet”
        // da kan du bruke foreach
        foreach (var fag in student1.Fags)
        {
            Console.WriteLine(fag.FagNavn);
        }
        
        foreach (var bleie in student2.Fags)
        {
            Console.WriteLine(bleie.FagNavn);
            
        }
        
        Karakter karakter1 = new Karakter (student1, fag1, 3);
        Karakter karakater2 = new Karakter (student2, fag1,4);
        student1.AddKarakter(karakter1);
        student2.AddKarakter(karakater2);
        
        
        student1.AddKarakter(karakter1);

        student1.AddFag(fag1);
        student1.AddFag(fag2);
        student1.AddFag(fag3);
        

        student1.PrintInfo();
        fag1.PrintInfo();
        fag2.PrintInfo();
        fag3.PrintInfo();
        subject2.PrintInfo();
        Console.WriteLine($"Her er en karakter: "+student1.Karakterer[0].KarakterVerdi);
        Console.WriteLine($"Totalt studiepoeng: "+student1.Studiepoeng()); 
        
        student2.PrintInfo();
        // Console.Write($"Her kommer fag: "+student1.Fags[0].FagNavn);
    }
}


// var student = new Student("Sohaila", 34, "programmering", 25);
//
// Console.WriteLine($"Elev: {Student.Navn} Alder er: {Student.Alder}");
// student.PrintInfo();
//
// public class student
// {
//     public string Name;
//     public int Age;
//     public string Program;
//     public int StudentID;
// }
// var grade = new Grade();
// var subject = new Subject();