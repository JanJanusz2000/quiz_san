using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class gra
    {
        public void Utworzbazepytan()
        {
            //tworzymy baze pytań
        }
        public Pytanie wylosujpytanie()
        {
            Pytanie p = new Pytanie();
            p.id = 1;
            p.Kategoria = 500;
            p.tresc = "Jak miał na imie Einstein?"
          
            odpowiedz o1 = new odpowiedz();
            o1.ID = 1;
            o1.tresc = "Albert";
            o1.Czyprawidlowa = true;
            p.odpowiedzi1.Add(o1
            
            odpowiedz o2 = new odpowiedz();
            o2.ID = 2;
            o2.tresc = "Albert";
            p.odpowiedzi1.Add(o2)

                        odpowiedz o3 = new odpowiedz();
            o3.ID = 3;
            o3.tresc = "Albert";
            p.odpowiedzi1.Add(o3)
                            odpowiedz o4 = new odpowiedz();
            o4.ID = 4;
            o4.tresc = "Albert";
            p.odpowiedzi1.Add(o4)
            return p;
        }
    }
}
