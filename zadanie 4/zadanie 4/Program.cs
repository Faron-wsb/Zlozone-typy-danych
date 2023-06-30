using System;

public enum Plec
{
    Kobieta,
    Mezczyzna
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}

class Program
{
    static void Main()
    {
        Student[] grupa = new Student[5];

        for (int i = 0; i < grupa.Length; i++)
        {
            Console.WriteLine("Wprowadź informacje dla studenta {0}:", i + 1);
            WypelnijStudenta(ref grupa[i]);
        }

        Console.WriteLine("\nDane studentów:");
        for (int i = 0; i < grupa.Length; i++)
        {
            WyswietlStudenta(grupa[i]);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine("\nŚrednia ocen w grupie: {0}", srednia);
    }

    static void WypelnijStudenta(ref Student student)
    {
        Console.Write("Nazwisko: ");
        student.Nazwisko = Console.ReadLine();

        Console.Write("Nr albumu: ");
        student.NrAlbumu = int.Parse(Console.ReadLine());

        Console.Write("Ocena: ");
        student.Ocena = OgraniczOcene(double.Parse(Console.ReadLine()));

        Console.Write("Płeć (0 - Kobieta, 1 - Mężczyzna): ");
        student.Plec = (Plec)int.Parse(Console.ReadLine());
    }

    static double OgraniczOcene(double ocena)
    {
        if (ocena < 2.0)
            return 2.0;
        else if (ocena > 5.0)
            return 5.0;
        else
            return ocena;
    }

    static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0;
        for (int i = 0; i < grupa.Length; i++)
        {
            sumaOcen += grupa[i].Ocena;
        }

        return sumaOcen / grupa.Length;
    }

    static void WyswietlStudenta(Student student)
    {
        Console.WriteLine("Nazwisko: {0}, Nr albumu: {1}, Ocena: {2}, Płeć: {3}",
            student.Nazwisko, student.NrAlbumu, student.Ocena, student.Plec);
    }
}
