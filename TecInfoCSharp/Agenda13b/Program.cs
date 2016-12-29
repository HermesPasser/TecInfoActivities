using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda13b_matrizMultiplica2Diagonal
{
    class Agenda13b_matrizMultiplica2Diagonal
    {
        static private void div()
        {
            int[] aVetor = new int[12];
            int nRecebe, nContador = 0;

            Console.WriteLine("Só serão aceitos números divisiveis por 2 ou 3.");
            while (nContador <= 11)
            {
                Console.WriteLine("Entre com o número " + nContador + ": ");
                string a = "";

                try
                {
                    a = Console.ReadLine();
                    nRecebe = int.Parse(a);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Parse error.");
                    return;
                }

                if ((nRecebe % 2) == 0)
                {
                    aVetor[nContador] = nRecebe;
                    nContador += 1;
                }
                else
                {
                    if ((nRecebe % 3) == 0)
                    {
                        aVetor[nContador] = nRecebe;
                        nContador += 1;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }

            }

            Console.Clear();

            Console.WriteLine("Mostrando os valores: ");
            for (int x = 0; x < 12; x++)
            {
                Console.WriteLine("vetor " + x + ": " + aVetor[x]);
            }
        }

        static void Main(string[] args)
        {
            div();
            Console.WriteLine("Encerrando programa...");
            Console.ReadKey();
        }
    }
}