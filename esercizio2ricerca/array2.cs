using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio2ricerca
{
    class array2
    {
        static void Main(string[] args)
        {

            int n = numeri.Length;
            bool swapped;
            const int tanti = 50;
            int[] numeri = new int[tanti];
            Random random = new Random();

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = random.Next(1, 100);
                swapped = false;
                for (int j = 1; j < (n - i); j++)
                    if (numeri[j - 1] > numeri[j])
                    {
                        int temp = numeri[j - 1];
                        numeri[j - 1] = numeri[j];
                        numeri[j] = temp;
                        swapped = true;
                    }
                    if (!swapped)
                    break;
                Console.WriteLine($"{swapped}");

                }
            }
    }
}
           
             
