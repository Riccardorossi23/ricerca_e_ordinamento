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


            const int TANTI = 50;
            double[] numeri = new double[TANTI];
            Random random = new Random();

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = random.Next(1, 100);


            }
        }
    }
}
           
             
