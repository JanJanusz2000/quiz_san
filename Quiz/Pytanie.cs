using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Pytanie
    {
        public int id { get; set; }
        public int Kategoria { get; set; }
        public string tresc { get; set; }
        public string odp1 { get; set; }
        public string odp2 { get; set; }
        public string odp3 { get; set; }
        public string odp4 { get; set; }

        public int Dodaj(int x, int y)
        {
            return x+y;
        }
    }
}
