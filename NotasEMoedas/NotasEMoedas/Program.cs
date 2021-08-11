using System;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quoficiente, resto, notas, moedas;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Vamos multiplicar N por 100 e forçar a conversão para int.
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado, pois o tipo double
            // as vezes da problema de arredondamento (por exemplo: se digitarmos
            // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
            // dai o casting resultaria em 57680 e nao 57681 como desejado)

            resto = (int)(N * 100.0 + 0.5);
            Console.WriteLine("NOTAS:");

            // como multiplicamos o valor por 100 acima, o valor de cada nota
            // também deverá ser multiplicado por 100 a seguir

            notas = 100;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 50;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 20;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 10;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 5;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 2;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos

            moedas = 100;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 1.00");
            resto = resto % moedas;

            moedas = 50;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.50");
            resto = resto % moedas;

            moedas = 25;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.25");
            resto = resto % moedas;

            moedas = 10;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.10");
            resto = resto % moedas;

            moedas = 5;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.05");            
            resto = resto % moedas;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}
