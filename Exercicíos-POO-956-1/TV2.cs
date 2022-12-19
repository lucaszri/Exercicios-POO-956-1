using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicíos_POO_956_1
{
    //exercicio4
    internal class TV2
    {
        public int Canal { get; set; }
        public int Volume { get; set; }
        public bool Ligada { get; set; }
    //construtor
    public TV2(int canal, int volume, bool ligada) 
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }
    }
}
