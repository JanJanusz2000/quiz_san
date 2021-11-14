using System;

namespace Quiz
{
 
    class Program
    {
        static void Main(string[] args)
        {
            
            gra gra = new gra()
            powitanie();
            Pytanie p1= gra wylosujpytanie();
            if (odpowiedz =="1" )
            {
                //hurra
                hurra(p1.Kategoria);
            }
            else
            {
                //pech
                pech();
            }
         
        }
        static void powitanie()
        {
            Console.WriteLine("Witaj w Quize .Życze Powodzenia");
            Console.WriteLine("Nacisnij enter");
            Console.ReadLine();
            string odpowiedz=PokazPytanieGraczowi(p1);
        }

        static string PokazPytanieGraczowi(Pytanie pytanie) 
        {
            Console.Clear();
            Console.WriteLine();
           // Console.WriteLine("Pytanie za " + pytanie.Kategoria + ".");
            Console.WriteLine($"Pytanie za  {pytanie.Kategoria}  .");
            Console.WriteLine(pytanie.tresc);
            Console.WriteLine();
            //wyswietlic

            Console.WriteLine();
            Console.WriteLine("Prosze nacisnąc 1 2 3 lub 4");
            foreach (odpowiedz odp in pytanie.odpowiedzi)
            {
                Console.WriteLine($"{odp.id} {odp.tresc}");

            }
        }
    }
    static void Pech()
    {
        Console.WriteLine("Niestety to jest zła odpowiedź")
        Console.WriteLine("Koniec gry");
    }
    static void hurra()
    {
        Console.WriteLine("wygrałeś");
        Console.WriteLine("Pora na kolejne cześć");

    }
}
