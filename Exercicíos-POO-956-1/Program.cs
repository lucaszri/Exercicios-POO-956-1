namespace Exercicíos_POO_956_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            Caneta caneta1 = new Caneta();
            Caneta caneta2 = new Caneta();

            caneta1.marca = "bic";
            caneta1.cor = "azul";
            caneta1.modelo = "esferográfica";

            caneta2.marca = "bic";
            caneta2.cor = "preta";
            caneta2.modelo = "esferográfica";

            //exercicio 2
            Pessoa pessoa = new Pessoa();

            pessoa.primeiroNome = "Lucas";
            pessoa.email = "lucas@email.com";
            pessoa.nomeCompleto = "Lucas de Souza";

            //exercicio 3
            TV tv = new TV();

            tv.canal = 5;
            tv.volume = 30;
            tv.ligada = false;

            tv.LigaTV();

            tv.mudaCanal();

            tv.diminuiVolume();
            tv.aumentarVolume();
            tv.aumentarVolume();
            tv.aumentarVolume();

            //exercicio 4

            TV2 tv2 = new TV2(6, 20, true);

            Console.WriteLine($"O canal é: {tv2.Canal}, o volume: {tv2.Volume}, e a tv está: {tv2.Ligada}");


        }
    }
}