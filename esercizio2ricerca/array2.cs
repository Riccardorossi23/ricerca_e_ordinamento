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
            int x,y;
            int temp;
            const int tanti = 10;
            int [] numeri = new int[tanti];
            Random rnd = new Random();
            for (x=0;x<tanti-1;x++)
            {
                for (y = 0; y < tanti - 1; y++)
                {
                    numeri[y+1] = rnd.Next(1, 100);
                    if (numeri[y]>numeri[y+1])
                    {
                        
                        temp = numeri[y];
                        numeri[y] = numeri[y + 1];
                        numeri[y + 1] = temp;
                        Console.WriteLine($"{temp}");

                    }
                }
            }

            Console.ReadLine();
        }
    }
}
    

           
             
