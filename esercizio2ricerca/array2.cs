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




            List<string> numeri = new List<string>();
            Random random = new Random();
            
            for (int i = 0; i < numeri.Count; i++)
            {

                int n = random.Next(0,100);
                numeri.Add(n);
                foreach ( numeri in n)
                {
                    Console.WriteLine(n);
                }


            }
            numeri.Sort();
            Console.WriteLine($"{numeri}");

            Console.ReadLine();
        }
    }
}
    

           
             
