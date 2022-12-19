using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicíos_POO_956_1
{
    //Exercicio 3
    internal class TV
    {
        public int canal;
        public int volume;
        public bool ligada = true;

        public bool LigaTV()
        {
            if (ligada == false)
            {
                ligada = true;
            }
            Console.WriteLine("Você ligou a TV");
            return ligada;
        }

        public bool DesligaTV()
        {
            if (ligada == true)
            {
                ligada = false;
            }
            Console.WriteLine("Você desligou a TV");
            return ligada;
        }

        public int mudaCanal()
        {
            if (ligada == true)
            {
                Console.WriteLine("Escolha o canal:");
                canal = Convert.ToInt32(Console.ReadLine());
            } else
            {
                Console.WriteLine("Você precisa ligar a tv para mudar de canal");
            }
            Console.WriteLine($"Agora você está no canal {canal}");
            return canal;
        }

        public int diminuiVolume ()
        {
            volume--;
            Console.WriteLine($"Você diminuiu o volume, agora ele é: { volume }");
            
            return volume;
        }

        public int aumentarVolume()
        {
            volume++;
            Console.WriteLine($"Você aumentou o volume, agora ele é: {volume}");

            return volume;
        }
    }
}

   
