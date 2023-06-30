using System;

enum DniTygodnia
{
    Poniedziałek = 1,
    Wtorek = 2,
    Środa = 3,
    Czwartek = 4,
    Piątek = 5,
    Sobota = 6,
    Niedziela = 7
}

enum EtapyPrania
{
    Rozpoczęcie = 1,
    Piorę = 2,
    Płuczę = 3,
    Wirowanie = 4,
    Zakończenie = 5
}

enum Posiłki
{
    Śniadanie = 1,
    DrugieŚniadanie = 2,
    Obiad = 3,
    Podwieczorek = 4,
    Kolacja = 5
}

enum BierekSzachowych
{
    Król = 1,
    Hetman = 2,
    Wieża = 3,
    Goniec = 4,
    Skoczek = 5,
    Pionek = 6
}

class Program
{
    static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Sobota;
        Console.WriteLine($"Dzień tygodnia: {dzien}");

        EtapyPrania etap = EtapyPrania.Płuczę;
        Console.WriteLine($"Etap prania: {etap}");

        Posiłki posilek = Posiłki.Obiad;
        Console.WriteLine($"Posiłek: {posilek}");

        BierekSzachowych bierka = BierekSzachowych.Hetman;
        Console.WriteLine($"Bierka szachowa: {bierka}");
    }
}
