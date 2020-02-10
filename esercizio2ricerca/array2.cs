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


            bool swapped;
            const int tanti = 10;
            int[] numeri = new int[tanti];
            Random random = new Random();

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = random.Next(1, 100);
                swapped = false;
                for (int j = 1; j < (10 - i); j++)
                {
                    if (numeri[j - 1] > numeri[j])
                    {
                        int temp = numeri[j - 1];
                        numeri[j - 1] = numeri[j];
                        numeri[j] = temp;
                        swapped = true;
                        Console.WriteLine($"{temp}");
                    }
                }
                if (!swapped)
                    break;
             


            }
            Console.ReadLine();
        }
    }
}
    

           
             
