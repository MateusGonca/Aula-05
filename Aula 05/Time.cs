using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05
{
    internal class Time
    {
        //Contrutores
        public Time()
        {
            Nome = "Atibaia FC";
            Pais = "Brasil";
            Estado = "São Paulo";
            Titulo = 0;
        }

        public Time(string n, string p, string e, int t)
        {
            Nome = n;
            Pais = p;
            Estado = e;
            Titulo = t;
        }

        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public int Titulo { get; set; }

    }
}
