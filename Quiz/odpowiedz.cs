using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class odpowiedz
    {
        public int ID { get; set;}
        public string kategoria { get; set; }
        public bool Czyprawidlowa { get; set; } = new List<odpowiedz>();
    }
}
