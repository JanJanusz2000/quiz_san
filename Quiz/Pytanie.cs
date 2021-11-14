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
        public List<odpowiedz> odpowiedzi  { get; set; }
    }
}
