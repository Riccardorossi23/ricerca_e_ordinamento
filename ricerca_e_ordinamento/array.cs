﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ricerca_e_ordinamento
{
    class array
    {
        static void Main(string[] args)
        {
            const int tanti = 100;
            double[] numeri = new double[tanti];
            Random rnd = new Random();
            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = rnd.Next(1, 100);
                int cont = 0;
                for (int j = 0; j < numeri.Length; j++)
                {
                    if (numeri[i] == numeri[j])
                    {
                        cont = cont + 1;
                    }
                }
                Console.WriteLine(numeri[i]+ " quante volte si ripete? " + "si ripete  "  +  cont +  " volte");
            }
            Console.ReadLine();
        }
    }
}
        
    

