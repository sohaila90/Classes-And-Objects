﻿using Classes_And_Objects;
// Hvorfor vil den endre fra using til namespace?
public abstract class Program
{
    public static void Main()
    {
        // stundent1 og 2 er 2 instanser som betyr 2 objekter
        List<Fag> hallo = null;
        Student student1 = new Student (  "Sohaila", 34, hallo,30 );
        Student student2 = new Student ( "Johan", 20, hallo, 26 );
        student1.PrintInfo();
        student2.PrintInfo();
        
    
        Fag fag1 = new Fag ( 30, "programmering", 30 );
        Fag subject2 = new Fag (20, "apputvikler", 20);
        fag1.PrintInfo();
        subject2.PrintInfo();
        hallo = new List<Fag>();
        hallo.Add(fag1);
        
        Karakter karakter1 = new Karakter (student1, fag1, 3);
        Karakter karakater2 = new Karakter (student2, fag1,4);
        karakter1.PrintInfo();
        karakater2.PrintInfo();
        
        student1.AddKarakter(karakter1);
        Console.WriteLine($"Her er en karakter: "+student1.Karakterer[0].KarakterVerdi);
        student1.AddFag(fag1);
        Console.Write($"Her kommer fag: "+student1.Fags[0].FagNavn);
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